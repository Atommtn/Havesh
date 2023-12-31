using Havesh.Model.Data;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.GrainInterfaces.Common;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Olive;
using Orleans.Runtime;

namespace Havesh.Domain.Infrastructure
{
	public class GrainEntityDependency
	{
		private readonly Dictionary<Type, List<GrainTypeAction>> _dependentGrainsToEntity = new();

		private Type _currentGrain;
		public void SetGrainContext<T>() where T : IGrain
		{
			_currentGrain = typeof(T);
		}

		public void DependContextToEntity<T>(
			bool entityHasGrainId = false,
			GrainActionOnEntityChangeEnum grainActionOnEntityChangeEnum = GrainActionOnEntityChangeEnum.ResetGrainCache
			) where T : BaseModel
		{
			var entities = _dependentGrainsToEntity.GetOrAdd(_currentGrain , () => new List<GrainTypeAction>());
			if(entities.Any(x=>x.EntityType == typeof(T)))
				return;

			entities.Add(new GrainTypeAction(typeof(T) , grainActionOnEntityChangeEnum , entityHasGrainId));
		}

		private async Task ResetGrains(BaseModel entity, GrainType grainType, IClusterClient _clusterClient,
			GrainActionOnEntityChangeEnum grainActionOnEntityChangeEnum, bool grainIdIsEntityId)
		{
			var managementGrain = _clusterClient.GetGrain<IManagementGrain>(0);
			var activeGrains = await managementGrain.GetActiveGrains(grainType);

			foreach (var grain in activeGrains.Select(_clusterClient.GetGrain<IResetSupportManagerGrain>))
			{
				switch (grainActionOnEntityChangeEnum)
				{
					case GrainActionOnEntityChangeEnum.DeactivateGrain:
						await grain.DeactivateGrainAsync();
						break;
					case GrainActionOnEntityChangeEnum.ResetGrainCache:
						await grain.ResetGrainCacheAsync();
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(grainActionOnEntityChangeEnum), grainActionOnEntityChangeEnum, null);
				}
			}

			foreach (var grain in activeGrains.Select(_clusterClient.GetGrain<IResetSupportGrain>))
			{
				if (grainIdIsEntityId)
				{
					var grainPrimaryKey = grain.GetGrainId().Key.Value.ToString();
					if(grainPrimaryKey != entity.Id.ToString())
						continue;
				}
				switch (grainActionOnEntityChangeEnum)
				{
					case GrainActionOnEntityChangeEnum.DeactivateGrain:
						await grain.DeactivateGrainAsync();
						break;
					case GrainActionOnEntityChangeEnum.ResetGrainCache:
						await grain.ResetGrainCacheAsync();
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(grainActionOnEntityChangeEnum), grainActionOnEntityChangeEnum, null);
				}
			}
		}

		public async Task ResetGrainsDependsOn(object entity, IClusterClient _clusterClient)
		{
			//Console.Beep();
			//await Task.Delay(1000);

			var grainsToReset = _dependentGrainsToEntity
				.Where(x=>x.Value.Any(t=> t.EntityType == entity.GetType() ))
				.ToImmutableArray();


			foreach (var kv in grainsToReset)
			{
				var grainType = GrainType.Create(kv.Key.Name.ToLower().TrimStart("i").TrimEnd("grain"));
				var item = kv.Value.First(x=>x.EntityType == entity.GetType());
				await ResetGrains(entity as BaseModel, grainType, _clusterClient,item.Action , item.byId);
			}
		}
	}

	public static class CacheDependencyExtensions
	{
		public static GrainEntityDependency Grain<G>(this GrainEntityDependency dependency) where G : IGrain
		{
			dependency.SetGrainContext<G>();
			return dependency;
		}
		public static GrainEntityDependency ManagerGrain<G>(this GrainEntityDependency dependency) where G : IGrain
		{
			dependency.SetGrainContext<G>();
			return dependency;
		}

		public static GrainEntityDependency DependsOn<E>(this GrainEntityDependency dependency) where E : BaseModel
		{
			dependency.DependContextToEntity<E>(false , GrainActionOnEntityChangeEnum.ResetGrainCache);
			return dependency;
		}

		public static GrainEntityDependency DependsOn<E>(this GrainEntityDependency dependency,
			GrainActionOnEntityChangeEnum changeActionEnum = GrainActionOnEntityChangeEnum.ResetGrainCache)
			where E : BaseModel
		{
			dependency.DependContextToEntity<E>(false,changeActionEnum);
			return dependency;
		}

		public static GrainEntityDependency DependsOn<E>(this GrainEntityDependency dependency,
			bool entityHasGrainId = false,
			GrainActionOnEntityChangeEnum changeActionEnum = GrainActionOnEntityChangeEnum.ResetGrainCache)
			where E : BaseModel
		{
			dependency.DependContextToEntity<E>(entityHasGrainId,changeActionEnum);
			return dependency;
		}

	}

	public enum GrainActionOnEntityChangeEnum
	{
		DeactivateGrain,ResetGrainCache
	}

	public record GrainTypeAction(Type EntityType, GrainActionOnEntityChangeEnum Action, bool byId);

}

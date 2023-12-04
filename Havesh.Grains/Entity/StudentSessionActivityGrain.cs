using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.Grains.Common;
using Havesh.Grains.GrainState;
using Havesh.Grains.Manager;
using Havesh.Model.Model;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;

namespace Havesh.Grains.Entity;

public class StudentSessionActivityGrain :
    HaveshGrain<StudentSessionActivity>
    , IStudentSessionActivity
{
    public StudentSessionActivityGrain(
        [PersistentState(nameof(StudentSessionActivityGrain) , HaveshConstants.GrainStorageProviderName)]
        IPersistentState<HaveshGrainState<StudentSessionActivity>> persistentState,
        IGrainContext grainContext,
        DataProviderService dataProviderService,
        ILogger<HaveshGrain<StudentSessionActivity>> logger)
        : base(persistentState, grainContext, dataProviderService, logger)
    {
    }

    protected override StudentSessionActivity? GetEntity(int id)
    {
        return DataProviderService.GetStudentSessionActivity(id);
    }

    protected override void UpdateEntity(StudentSessionActivity entity)
    {
        DataProviderService.SaveStudentSessionActivity(entity);
    }
}
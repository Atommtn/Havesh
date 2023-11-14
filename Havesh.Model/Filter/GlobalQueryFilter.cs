using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Havesh.Model.Data;

namespace Havesh.Model.Filter
{
    internal class GlobalQueryFilter
    {
        public LambdaExpression GenerateQueryFilterLambdaExpression(Type type)
        {
            // we should generate:  e => e.IsDeleted == false
            // or: e => !e.IsDeleted

            // e =>
            var parameter = Expression.Parameter(type, "e");

            // false
            var falseConstant = Expression.Constant(false);

            // e.IsDeleted
            var propertyAccess = Expression.PropertyOrField(parameter, nameof(ICanBeSoftDeleted.IsDeleted));

            // e.IsDeleted == false
            var equalExpression = Expression.Equal(propertyAccess, falseConstant);

            // e => e.IsDeleted == false
            var lambda = Expression.Lambda(equalExpression, parameter);

            return lambda;
        }
    }
}

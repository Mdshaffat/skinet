using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specification
{
    public interface ISpecification<T>
    {
         Expression<Func<T, bool>> Criteria{get;}
         List<Expression<Func<T, object>>> Includes{get;}

         Expression<Func<T, Object>> OrderBy {get; }
         Expression<Func<T, Object>> OrderByDecending{get; }
    }
}
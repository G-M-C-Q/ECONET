using Core.Entities;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructuree.Data
{
    public class SpecificationEvaluator<TEntity> where TEntity :BaseEntity
    {
        //don't need to generate a new insatnce of class
        //return IQueryable
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> spec)
        {
            var query = inputQuery;

            if (spec.Criteria != null )
            {
                query = query.Where(spec.Criteria); 
            }
            //Evaluate the includes 

            query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));

            return query;
        }
    }
}
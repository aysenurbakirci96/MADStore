﻿using MADStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Core.DAL.Entity_Framework
{
    public class EFRepositoryBase<TEntity, TContext> : IRepository<TEntity>
        where TEntity : BaseEntity, new()
        where TContext : DbContext, new()
    {
        TContext ctx = EFSingletonContext<TContext>.MadStoreDb;
        public void Add(TEntity entity)
        {
            ctx.Entry(entity).State = EntityState.Added;
            ctx.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            ctx.Entry(entity).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            ctx.Entry(entity).State = EntityState.Deleted;
            ctx.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return ctx.Set<TEntity>().Where(filter).SingleOrDefault();
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
            {
                return ctx.Set<TEntity>().ToList();
            }
            return ctx.Set<TEntity>().Where(filter).ToList();
        }
    }
}

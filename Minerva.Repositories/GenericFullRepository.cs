﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minerva.Entities;

namespace Minerva.Repositories
{
    public abstract class GenericFullRepository<C, T> :
        GenericRepository<C,T> where T : AbstractFullEntity where C : DbContext, new () {
            
        public virtual void Add(T entity)
        {
            entity.CreatedTime = DateTime.Now;

            base.Add(entity);
            Context.Set<T>().Add(entity);
        }
        
        public virtual void Edit(T entity)
        {
            entity.ModificationTime = DateTime.Now;

            base.Edit(entity);
        }
        
        public virtual void Delete(T entity)
        {
            entity.CreatedTime = DateTime.Now;

            base.Delete(entity);
        }
        
    }
}
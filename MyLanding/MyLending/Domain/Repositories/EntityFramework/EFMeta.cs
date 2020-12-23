using Microsoft.EntityFrameworkCore;
using MyLending.Domain.Entities;
using MyLending.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Repositories.EntityFramework
{
    public class EFMeta : IMeta
    {
        private readonly AppDbContext context;
        public EFMeta(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteMeta(Guid id)
        {
            context.Meta.Remove(new Meta { Id = id });
            context.SaveChanges();
        }

        public Meta GetMeta()
        {
            return context.Meta.FirstOrDefault();
        }

        public void SaveMeta(Meta entity)
        {
            if (entity.Id == default) context.Entry(entity).State = EntityState.Added;
            else context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

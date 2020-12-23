using Microsoft.EntityFrameworkCore;
using MyLending.Domain.Entities;
using MyLending.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Repositories.EntityFramework
{
    public class EFExperience : IExperience
    {
        private readonly AppDbContext context;
        public EFExperience(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteExperience(Guid id)
        {
            context.Experience.Remove(new Experience { Id = id });
            context.SaveChanges();
        }

        public Experience GetExperienceById(Guid id)
        {
            return context.Experience.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Experience> GetExperience()
        {
            return context.Experience;
        }

        public void SaveExperience(Experience entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

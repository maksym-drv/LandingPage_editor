using Microsoft.EntityFrameworkCore;
using MyLending.Domain.Entities;
using MyLending.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Repositories.EntityFramework
{
    public class EFEducation : IEducation
    {
        private readonly AppDbContext context;
        public EFEducation(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteEducation(Guid id)
        {
            context.Education.Remove(new Education { Id = id });
            context.SaveChanges();
        }

        public Education GetEducationById(Guid id)
        {
            return context.Education.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Education> GetEducation()
        {
            return context.Education;
        }

        public void SaveEducation(Education entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

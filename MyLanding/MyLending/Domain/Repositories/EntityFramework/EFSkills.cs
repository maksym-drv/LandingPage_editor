using Microsoft.EntityFrameworkCore;
using MyLending.Domain.Entities;
using MyLending.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Repositories.EntityFramework
{
    public class EFSkills : ISkills
    {
        private readonly AppDbContext context;
        public EFSkills(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteSkills(Guid id)
        {
            context.Skills.Remove(new Skills { Id = id });
            context.SaveChanges();
        }

        public Skills GetSkillsById(Guid id)
        {
            return context.Skills.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Skills> GetSkills()
        {
            return context.Skills;
        }

        public void SaveSkills(Skills entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

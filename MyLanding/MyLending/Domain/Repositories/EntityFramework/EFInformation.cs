using Microsoft.EntityFrameworkCore;
using MyLending.Domain.Entities;
using MyLending.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Repositories.EntityFramework
{
    public class EFInformation : IInformation
    {
        private readonly AppDbContext context;
        public EFInformation(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteInformation(Guid id)
        {
            context.Information.Remove(new Information { Id = id });
            context.SaveChanges();
        }

        public Information GetInformationByCodeWord(string codeWord)
        {
            return context.Information.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public void SaveInformation(Information entity)
        {
            if (entity.Id == default) context.Entry(entity).State = EntityState.Added;
            else context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

using MyLending.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Repositories.Abstract
{
    public interface IExperience
    {
        IQueryable<Experience> GetExperience();
        Experience GetExperienceById(Guid id);
        void SaveExperience(Experience entity);
        void DeleteExperience(Guid id);
    }
}

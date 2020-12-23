using MyLending.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Repositories.Abstract
{
    public interface IEducation
    {
        IQueryable<Education> GetEducation();
        Education GetEducationById(Guid id);
        void SaveEducation(Education entity);
        void DeleteEducation(Guid id);
    }
}

using MyLending.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Repositories.Abstract
{
    public interface ISkills
    {
        IQueryable<Skills> GetSkills();
        Skills GetSkillsById(Guid id);
        void SaveSkills(Skills entity);
        void DeleteSkills(Guid id);
    }
}

using MyLending.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain
{
    public class DataManager
    {
        public IInformation Information { get; set; }
        public IMeta Meta { get; set; }
        public ISkills Skills { get; set; }
        public IExperience Experience { get; set; }
        public IEducation Education { get; set; }
        public DataManager(IInformation information , IMeta meta, ISkills skills, IExperience experience, IEducation education)
        {
            Information = information;
            Meta = meta;
            Skills = skills;
            Experience = experience;
            Education = education;
        }
    }
}

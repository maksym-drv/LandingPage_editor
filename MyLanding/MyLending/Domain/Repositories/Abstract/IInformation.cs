using MyLending.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Repositories.Abstract
{
    public interface IInformation
    {
        Information GetInformationByCodeWord(string codeWord);
        void SaveInformation(Information entity);
        void DeleteInformation(Guid id);
    }
}

using MyLending.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Repositories.Abstract
{
    public interface IMeta
    {
        Meta GetMeta();
        void SaveMeta(Meta entity);
        void DeleteMeta(Guid id);
    }
}

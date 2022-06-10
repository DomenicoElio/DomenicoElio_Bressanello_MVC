using Restaurant_Core.Entities;
using Restaurant_Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Core.Interfaces
{
    public interface IRepoPiatti : IRepository<Piatto>
    {
        Piatto GetById(int id);
    }
}

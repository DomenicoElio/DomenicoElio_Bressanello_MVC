using System;
using Restaurant_Core.Entities;
using Restaurant_Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Core.Interfaces
{
    public interface IRepoMenu : IRepository<Menu>
    {
        Menu GetById(int id);
    }
}

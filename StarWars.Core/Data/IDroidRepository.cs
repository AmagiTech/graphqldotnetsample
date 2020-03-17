using StarWars.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Core.Data
{
    public interface IDroidRepository : IBaseRepository<Droid, int> { }
}

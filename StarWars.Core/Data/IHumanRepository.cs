using StarWars.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars.Core.Data
{
    public interface IHumanRepository : IBaseRepository<Human, int> { }
}

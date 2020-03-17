using GraphQL.Types;
using StarWars.Core.Data;
using StarWars.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Api.Models
{
    public class StarWarsQuery : ObjectGraphType
    {
        private IDroidRepository droidRepository { get; set; }
        public StarWarsQuery(IDroidRepository droidRepository)
        {
            this.droidRepository = droidRepository;
            Field<DroidType>("hero",
                resolve: context => this.droidRepository.Get(2001));
        }
    }
}

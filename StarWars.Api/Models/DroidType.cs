using GraphQL.Types;
using StarWars.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Api.Models
{
    public class DroidType : ObjectGraphType<Droid>
    {
        public DroidType()
        {
            Field(x => x.Id).Description("The Id of the Droid");
            Field(x => x.Name, nullable: true).Description("The name of the Droid");
        }
    }
}

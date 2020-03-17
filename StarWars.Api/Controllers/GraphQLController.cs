using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using StarWars.Api.Models;
using StarWars.Data.InMemory;

namespace StarWars.Api.Controllers
{
    [Route("graphql")]
    public class GraphQLController : Controller
    {
        private StarWarsQuery starWarsQuery { get; set; }

        public GraphQLController(StarWarsQuery starWarsQuery)
        {
            this.starWarsQuery = starWarsQuery;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            var schema = new Schema { Query = starWarsQuery };
            var result = await new DocumentExecuter().ExecuteAsync(_ =>
                {
                    _.Schema = schema;
                    _.Query = query.Query;
                }).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
                return BadRequest();
            return Ok(result.Data);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
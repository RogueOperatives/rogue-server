using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RogueEngine.Core.Contracts;
using RogueEngine.DataAccess;

namespace RogueServer.Api
{
    [Route("api/[controller]")]
    public class UnitsController : Controller
    {
        [HttpGet]
        public IEnumerable<IUnit> Get()
        {
            return RepositoryIndex.Instance.UnitRepository.GetAllUnits();
        }

        [HttpGet("{id}")]
        public IUnit Get(string id)
        {
            return RepositoryIndex.Instance.UnitRepository.GetUnitById(Guid.Parse(id));
        }
    }
}

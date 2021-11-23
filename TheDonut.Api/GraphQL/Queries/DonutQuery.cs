using System.Collections.Generic;
using TheDonut.Api.Interfaces;
using TheDonut.Api.Models;

namespace TheDonut.Api.GraphQL.Queries
{
    public class DonutQuery
    {
        IDonutService _donutService = null;

        public DonutQuery(IDonutService donutService)
        {
            _donutService = donutService;
        }

        public List<Donut> Donuts => _donutService.GetAllDonuts();
    }
}
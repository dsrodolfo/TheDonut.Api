using System.Collections.Generic;
using TheDonut.Api.Interfaces;
using TheDonut.Api.Models;

namespace TheDonut.Api.Services
{
    public class DonutService : IDonutService
    {
        public List<Donut> GetAllDonuts()
        {
            List<Donut> donuts = new();

            Donut chocolateBelgaDonut = new() { Id = 1, Name = "Chocolate Belga", Price = 8.50 };
            Donut chocolateBrancoDonut = new() { Id = 2, Name = "Chocolate Branco", Price = 7.50 };
            Donut frutasVermelhasDonut = new() { Id = 3, Name = "Frutas Vermelhas", Price = 6.50 };

            donuts.Add(chocolateBelgaDonut);
            donuts.Add(chocolateBrancoDonut);
            donuts.Add(frutasVermelhasDonut);

            return donuts;
        }
    }
}
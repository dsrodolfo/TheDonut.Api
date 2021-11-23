using System.Collections.Generic;
using TheDonut.Api.Models;

namespace TheDonut.Api.Interfaces
{
    public interface IDonutService
    {
        List<Donut> GetAllDonuts();
    }
}
using chef.BLL.DTOs;
using chef.BLL.Entities;
using chef.BLL.Repositories.Interfaces;
using System.Collections.Generic;

namespace chef.DAL.Repositories.Interfaces
{
    public interface IDishRepository : IRepository<Dish>
    {
        Dish GetById(int id);
        (int maxPortions, int maxTime, int maxWeight, float maxPrice) GetMaxValues();
    }
}

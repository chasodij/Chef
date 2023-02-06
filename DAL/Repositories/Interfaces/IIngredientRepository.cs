using chef.BLL.Entities;
using chef.BLL.Repositories.Interfaces;
using System.Collections.Generic;

namespace chef.DAL.Repositories.Interfaces
{
    public interface IIngredientRepository : IRepository<Ingredient>
    {
        List<Ingredient> GetAllByDishId(int id);
    }
}

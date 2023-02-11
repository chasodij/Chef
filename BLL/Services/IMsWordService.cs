using chef.BLL.DTOs;

namespace chef.BLL.Services
{
    public interface IMsWordService
    {
        void CreateDishCardFile(DishCardDTO dishCardDTO, string path);
    }
}

using ApiCall.InputData;
using Microsoft.AspNetCore.Mvc;

namespace ApiCall.BusinessLogic
{
    public interface IShoppingRepository
    {
        Task<IEnumerable<ShoppingInput>> GetAllItems();

        Task<ShoppingInput> Add(ShoppingInput shoppingInput);

        Task<ShoppingInput> GetItem(int number);
        //Task<ShoppingInput> ModifyProduct(ShoppingInput shoppingInput);

        //Task<IActionResult> GetByBrandNAme(string name);

    }
}

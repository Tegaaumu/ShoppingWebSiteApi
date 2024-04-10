using ApiCall.InputData;

namespace ApiCall.BusinessLogic
{
    public interface IShoppingRepository
    {
        Task<IEnumerable<ShoppingInput>> GetAllItems();

        Task<ShoppingInput> Add(ShoppingInput shoppingInput);

    }
}

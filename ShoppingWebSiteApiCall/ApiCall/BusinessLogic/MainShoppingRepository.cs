using ApiCall.InputData;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ApiCall.BusinessLogic
{
    public class MainShoppingRepository : IShoppingRepository
    {
        public ApplicationDBContext? _applicationDBContext;
        public MainShoppingRepository(ApplicationDBContext? applicationDBContext)
        {
         _applicationDBContext = applicationDBContext;
         //_applicationDBContext = applicationDBContext ?? throw new ArgumentNullException(nameof(_applicationDBContext));
        }
        public  async Task<ShoppingInput> Add(ShoppingInput shoppingInput)
        {
            _applicationDBContext!.Add(shoppingInput);
            await _applicationDBContext.SaveChangesAsync();
            return shoppingInput;
        }

        public async Task<IEnumerable<ShoppingInput>> GetAllItems()
        {
            if (_applicationDBContext!.ShoppingInput.Count<ShoppingInput>() == 0 || _applicationDBContext!.ShoppingInput == null)
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("This Current database is an empty one please input values to the database");
                Console.ResetColor();
                return Enumerable.Empty<ShoppingInput>();
            }
            return _applicationDBContext.ShoppingInput;
        }
    }
}

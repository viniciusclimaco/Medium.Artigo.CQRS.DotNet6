using CodersInRio.Library.Models;

namespace CodersInRio.Library.Repositories
{
    public interface ICoffeeRepository
    {
        List<CoffeeModel> GetAll();
        CoffeeModel Add(string firstName, string lastName);
    }
}

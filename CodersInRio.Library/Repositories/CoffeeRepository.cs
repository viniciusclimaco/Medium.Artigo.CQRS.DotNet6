using CodersInRio.Library.Models;

namespace CodersInRio.Library.Repositories
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private List<CoffeeModel> _coffees = new();

        public CoffeeRepository()
        {
            _coffees.Add(new CoffeeModel { Id = 1, Name = "Expresso", Size = "Large" });
            _coffees.Add(new CoffeeModel { Id = 2, Name = "Latte", Size = "Medium" });
        }

        public CoffeeModel Add(string name, string size)
        {
            CoffeeModel _coffee = new() { Name = name, Size = size };
            _coffee.Id = _coffees.Max(x => x.Id) + 1;
            _coffees.Add(_coffee);
            return _coffee;            
        }

        public List<CoffeeModel> GetAll()
        {
            return _coffees;
        }
    }
}

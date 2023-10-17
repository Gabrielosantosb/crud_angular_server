using System.Collections.Generic;
using WebApplication4.Model;

namespace WebApplication4.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person Delete(long id);
        Person FindById(long id);
        List<Person> FindAll();
        

        Person Update(Person person);
    }
}

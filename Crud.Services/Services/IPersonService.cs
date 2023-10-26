using Crud.ORM.Entity;
using System.Collections.Generic;

namespace Crud.Services.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person Update(Person person);
        Person Delete(long id);
        Person FindById(long id);
        List<Person> FindAll();
        List<Person> DeleteAll();

    }
}

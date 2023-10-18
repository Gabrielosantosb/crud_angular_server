using System;
using System.Collections.Generic;
using System.Threading;
using WebApplication4.Model;

namespace WebApplication4.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }
        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name",
                LastName = "Person LastName",
                Description = "Descricao Aqui"
                //Address = "SomeAdress",
                //Gender = "Male"
            };
        }


        public Person Create(Person person)
        {
            
            return person;
        }

        public Person Delete(long id)
        {
            throw new NotImplementedException();
        }


        public Person Update(Person person)
        {
            //Ir ate base de dados e atualizar()
            return person;
        }
        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Description = "DescricaoAqui" + i
                //Address = "SomeAdress" + i,
                //Gender = "Male" + i
            };
        }

        private long IncrementAndGet()
        {

            return Interlocked.Increment(ref count);
        }
    }
}

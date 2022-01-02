using RestWithAPSNET5.Model;
using System.Collections.Generic;

namespace RestWithAPSNET5.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        Person Delete(long id);
    }
}

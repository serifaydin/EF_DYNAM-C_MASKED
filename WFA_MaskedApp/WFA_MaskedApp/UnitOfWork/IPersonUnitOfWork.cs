using System.Collections.Generic;
using WFA_MaskedApp.DataModels;

namespace WFA_MaskedApp.UnitOfWork
{
    public interface IPersonUnitOfWork
    {
        void Add(Person model);
        IList<Person> GetPersons();
    }
}
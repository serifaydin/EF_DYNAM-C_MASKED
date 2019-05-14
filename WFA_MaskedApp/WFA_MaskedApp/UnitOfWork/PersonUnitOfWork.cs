using System.Collections.Generic;
using System.Linq;
using WFA_MaskedApp.DataLibrary;
using WFA_MaskedApp.DataModels;

namespace WFA_MaskedApp.UnitOfWork
{
    public class PersonUnitOfWork : IPersonUnitOfWork
    {
        private readonly UnMaskedContext _unMaskedContext;

        public PersonUnitOfWork()
        {
            _unMaskedContext = new UnMaskedContext();
        }

        public void Add(Person model)
        {
            _unMaskedContext.Persons.Add(model);
            _unMaskedContext.SaveChanges();
        }

        public IList<Person> GetPersons()
        {
            return _unMaskedContext.Persons.ToList();
        }
    }
}
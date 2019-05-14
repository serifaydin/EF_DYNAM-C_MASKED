using System.Collections.Generic;
using System.Linq;
using WFA_MaskedApp.DataLibrary;
using WFA_MaskedApp.DataModels;

namespace WFA_MaskedApp.UnitOfWork
{
    public class MaskedPersonUnitOfWork : IMaskedPersonUnitOfWork
    {
        private readonly MaskedContext _maskedContext;

        public MaskedPersonUnitOfWork()
        {
            _maskedContext = new MaskedContext();
        }
        public IList<Person> GetMaskedPersons()
        {
            return _maskedContext.Persons.ToList();
        }
    }
}
using System.Collections.Generic;
using WFA_MaskedApp.DataModels;

namespace WFA_MaskedApp.UnitOfWork
{
    public interface IMaskedPersonUnitOfWork
    {
        IList<Person> GetMaskedPersons();
    }
}
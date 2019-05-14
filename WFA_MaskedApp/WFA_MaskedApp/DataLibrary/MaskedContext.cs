using System.Data.Entity;
using WFA_MaskedApp.DataModels;

namespace WFA_MaskedApp.DataLibrary
{
    public partial class MaskedContext : DbContext
    {
        public MaskedContext() :
            base("name=MaskedModel")
        {
        }

        public virtual DbSet<Person> Persons { get; set; }
    }
}
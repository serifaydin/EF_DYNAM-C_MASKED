using System.Data.Entity;
using WFA_MaskedApp.DataModels;

namespace WFA_MaskedApp.DataLibrary
{
    public partial class UnMaskedContext : DbContext
    {
        public UnMaskedContext() 
            : base("name=UnmaskedModel")
        {
        }

        public virtual DbSet<Person> Persons { get; set; }
    }
}
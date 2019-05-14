using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WFA_MaskedApp.DataModels
{
    [Table("Person")]
    public class Person
    {
        [Column("Id")]
        public int Id { get; set; }

        [StringLength(200)]
        [Column("Name")]
        public string Name { get; set; }

        [StringLength(200)]
        [Column("SurName")]
        public string SurName { get; set; }

        [StringLength(200)]
        [Column("EMail")]
        public string EMail { get; set; }

        [StringLength(200)]
        [Column("Adress")]
        public string Adress { get; set; }

        [StringLength(200)]
        [Column("Phone")]
        public string Phone { get; set; }

        [StringLength(11)]
        [Column("PrivateKey")]
        public string PrivateKey { get; set; }
    }
}
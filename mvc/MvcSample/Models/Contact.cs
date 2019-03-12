using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSample.DAL
{
    [Table("contacts_mvc")]
    public class Contact
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column("email")]
        public string Email { get; set; }

        [Required]
        [Column("contact_name")]
        public string Name { get; set; }
    }
}

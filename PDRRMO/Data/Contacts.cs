using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PDRRMO.Data
{
    public partial class Contacts
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}

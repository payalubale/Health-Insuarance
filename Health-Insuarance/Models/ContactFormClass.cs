using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Health_Insuarance.Models
{
    public class ContactFormClass
    {
        [Key]

        public int Userid { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public string Mobileno { get; set; }

        public string Message { get; set; }
    }
}

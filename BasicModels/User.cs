using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicModels
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public string MobileNum { get; set; }
        public virtual Country City { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastEditDate { get; set; }
        public bool IsActive { get; set; }
        public virtual UserType UserType { get; set; }
        override public string ToString() {
            return Name + " " + Family;
        }
    }
}

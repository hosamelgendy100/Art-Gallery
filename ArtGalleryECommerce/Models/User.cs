using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Guid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string CitizenshipNo { get; set; }
        //public int CartID { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }

        public User()
        {
            this.IsActive = true;
            this.CreationDate = DateTime.Now;
        }
    }
}

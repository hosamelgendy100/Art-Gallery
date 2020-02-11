using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Models
{
    public class Artist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public bool IsActive { get; set; }
        private DateTime creationDate;

        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = DateTime.Now; }
        }

        public Artist()
        {
            this.creationDate = DateTime.Now;
        }
    }
}

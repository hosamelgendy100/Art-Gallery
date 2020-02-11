using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }

        private DateTime creationDate;

        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = DateTime.Now; }
        }
    }
}

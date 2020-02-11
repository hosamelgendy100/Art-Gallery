using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Models
{
    public class ProductType
    {
        public int ID { get; set; }
        public string Type { get; set; }
        private DateTime creationDate;

        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = DateTime.Now; }
        }

        public ProductType()
        {
            this.creationDate = DateTime.Now;
        }
    }
}

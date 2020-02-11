using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Models.Common
{
    public static class Common
    {
        public enum ProductState
        {
            Sold,
            Inactive,
            Active
        };

        public enum OrderState
        {
            Active,
            Canceled,
            Completed
        };
    }
}

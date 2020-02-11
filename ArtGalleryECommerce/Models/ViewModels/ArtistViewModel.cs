using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Models.ViewModels
{
    [NotMapped]
    public class ArtistViewModel : Artist
    {
        [NotMapped]
        public IQueryable<Artist> Artists { get; set; }
        [NotMapped]
        public Artist ArtistInstance { get; set; }
        [NotMapped]
        public string FullName { get; set; }
        [NotMapped]
        public int ArtistID { get; set; }
        [NotMapped]
        public int SelectedArtistID { get; set; }
        [NotMapped]
        public string SelectedArtistName { get; set; }
    }
}

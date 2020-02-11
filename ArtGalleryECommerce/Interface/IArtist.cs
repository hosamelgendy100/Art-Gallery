using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Interface
{
    public interface IArtist
    {
        IQueryable<Artist> Artists { get; }
        ArtistViewModel GetArtists();
        ArtistViewModel GetArtists(int? ID);
        Artist GetByID(int ID);
        
        bool AddArtist(Artist artist);
        bool UpdateArtist(Artist artist);
        bool DelArtist(Artist artist);
    }
}

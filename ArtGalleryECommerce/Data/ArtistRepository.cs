using ArtGalleryECommerce.Interface;
using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Data
{
    public class ArtistRepository : IArtist
    {
        private Context context;
        public ArtistRepository(Context _context)
        {
            context = _context;
        }

        public IQueryable<Artist> Artists => context.Artists;

        public ArtistViewModel GetArtists()
        {
            ArtistViewModel avm = new ArtistViewModel();
            avm.Artists = context.Artists;
            return avm;
        }

        public ArtistViewModel GetArtists(int? ID)
        {
            ArtistViewModel avm = new ArtistViewModel();
            avm.Artists = context.Artists;
            avm.SelectedArtistID = (int)ID;
            avm.SelectedArtistName = context.Artists.Where(x => x.ID == ID).FirstOrDefault().Name + " " + context.Artists.Where(x => x.ID == ID).FirstOrDefault().Surname;
            return avm;
        }

        public Artist GetByID(int ID)
        {
            //ArtistViewModel artist = new ArtistViewModel();
            //artist.ArtistInstance = context.Artists.Where(x => x.ID == ID).FirstOrDefault();
            var artist = context.Artists.Where(x => x.ID == ID).FirstOrDefault();

            return artist;
        }

        public bool AddArtist(Artist artist)
        {
            artist.IsActive = true;
            context.Artists.Add(artist);
            return (context.SaveChanges() > 0) ? true : false;
        }

        public bool UpdateArtist(Artist artist)
        {
            context.Artists.Update(artist);
            return (context.SaveChanges() > 0) ? true : false;
        }

        public bool DelArtist(Artist artist)
        {
            //artist.IsActive = false;
            context.Artists.Remove(artist);
            return (context.SaveChanges() > 0) ? true : false;
        }
    }
}

using Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class AlbumsViewModel
    {

        public List<Album> ListAlbums { get; set; }
        public SelectList Genres { get; set; }
        public SelectList Artists { get; set; }

        public int artistID { get; set; }
        public int genreID { get; set; }
        public string titleFilter { get; set; }
    }
}

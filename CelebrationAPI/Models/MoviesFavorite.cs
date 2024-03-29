﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CelebrationAPI.Models
{
    public partial class MoviesFavorite
    {
     
      

        [Key]
        public string ImdbId { get; set; }
        public string Title { get; set; }
        public int? Year { get; set; }
        public string Rated { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Poster { get; set; }
        public MoviesFavorite()
        {
        }

        public MoviesFavorite(string imdbId, string title, int year, string rated, string genre, string director, string poster)
        {
            ImdbId = imdbId.ToString();
            Title = title.ToString();
            Year = int.Parse(year.ToString());
            Rated = rated.ToString();
            Genre = genre.ToString();
            Director = director.ToString();
            Poster = poster.ToString();
        }
    }


}

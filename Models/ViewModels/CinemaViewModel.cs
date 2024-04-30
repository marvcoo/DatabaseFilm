using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace DatabaseFilm.Models.ViewModels
{
    public class CinemaViewModel
    {
        public string ImgPath {get; set;}
        public int Id {get; set;}
        public string Titolo {get; set;}
        public string Regista {get; set;}
        public string Genere {get; set;}
        public string Nazionalita {get; set;}
        public int AnnoProduzione {get; set;}

        public static CinemaViewModel FromDataRow(DataRow cinemaRow)
        {
            var cinemaViewModel = new CinemaViewModel
            {
                ImgPath = "/file.png",
                Titolo= Convert.ToString(cinemaRow["Titolo"]),
                Regista = Convert.ToString(cinemaRow["Regista"]),
                Genere = Convert.ToString(cinemaRow["Genere"]),
                Nazionalita = Convert.ToString(cinemaRow["Nazionalita"]),
                AnnoProduzione = Convert.ToInt32(cinemaRow["AnnoProduzione"]),
                Id = Convert.ToInt32(cinemaRow["CodFilm"])
            };
            return cinemaViewModel;
        }
    }
}
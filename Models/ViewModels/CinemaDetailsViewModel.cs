using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using DatabaseFilm.Models.ViewModels;

namespace DatabaseFilm.Models.ViewModels
{
    public class CinemaDetailViewModel : CinemaViewModel
    {
        public string Descrizione {get; set;}
        public List<AttoriViewModel> Attori {get; set;}

        public static new CinemaDetailViewModel FromDataRow(DataRow cinemaRow)
        {
            var cinemaDetailViewModel = new CinemaDetailViewModel()
            {
                Titolo = Convert.ToString(cinemaRow["Titolo"]),
                AnnoProduzione = Convert.ToInt32(cinemaRow["AnnoProduzione"]),
                Regista = Convert.ToString(cinemaRow["Regista"]),
                Genere = Convert.ToString(cinemaRow["Genere"]),
                Attori = new List<AttoriViewModel>()
            };
            return cinemaDetailViewModel;
        }
    }
}
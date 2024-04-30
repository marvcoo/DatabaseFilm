using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseFilm.Models.ViewModels;

namespace DatabaseFilm.Models.Services.Application
{
    public interface ICinemaService
    {
        List<CinemaViewModel> GetCinemas();
        CinemaDetailViewModel GetCinema(int id);
        void AddCinema(string Titolo, string Anno, string Genere);
    }
}
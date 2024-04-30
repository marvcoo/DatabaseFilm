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
<<<<<<< HEAD
=======
        CinemaDetailViewModel GetCinema(int id);
<<<<<<< HEAD
>>>>>>> e6deb95081e9a60508a572c658882f1cd8ee3f6e
=======
        void AddCinema(string Titolo, string Anno, string Genere);
>>>>>>> efed80331ea95d1f61b1af0d66c8ff443b930d02
    }
}
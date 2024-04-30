using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseFilm.Models.Services.Infrastructures;
using System.Data;

using DatabaseFilm.Models.ViewModels;

namespace DatabaseFilm.Models.Services.Application
{
    public class AdoNetCinemaService : ICinemaService 
    {
        private readonly IDatabaseAccessor db;

        public AdoNetCinemaService(IDatabaseAccessor db)
        {
            this.db=db;
        }
        public List<CinemaViewModel> GetCinemas()
        {
<<<<<<< HEAD
            string query = "SELECT CodFilm, Titolo, Regista, Nazionalita, AnnoProduzione, Genere FROM film";
=======
            // string query = "SELECT CodFilm, Titolo, Regista, Nazionalita, AnnoProduzione, Genere FROM film";
            FormattableString query = $"SELECT CodFilm, Titolo, Regista, Nazionalita, AnnoProduzione, Genere FROM film";
>>>>>>> e6deb95081e9a60508a572c658882f1cd8ee3f6e
            DataSet dataSet= db.Query(query);
            var dataTable= dataSet.Tables[0];
            var cinemaList = new List<CinemaViewModel>();  
            foreach(DataRow cinemaRow in dataTable.Rows)
            {
                CinemaViewModel cinema = CinemaViewModel.FromDataRow(cinemaRow);
                cinemaList.Add(cinema);
            }
            return cinemaList;
        }
<<<<<<< HEAD
       
=======
        public CinemaDetailViewModel GetCinema(int id)
        {
            FormattableString query = $@"SELECT CodFilm, Titolo, Regista, film.Nazionalita, AnnoProduzione, Genere FROM film WHERE CodFilm = {id};
                                    SELECT attori.CodAttore, Nome, AnnoNascita, attori.Nazionalita FROM attori JOIN recita ON attori.CodAttore = recita.CodAttore JOIN film ON recita.IdFilm = film.CodFilm  WHERE film.CodFilm = {id}";
            DataSet dataSet = db.Query(query);
            var cinemaTable = dataSet.Tables[0];

            if (cinemaTable.Rows.Count != 1)
            {
                throw new InvalidOperationException($"Did not return exactly 1 row for Cinema{id}");
            }
            var cinemaRow = cinemaTable.Rows[0];
            var cinemaDetailViewModel = CinemaDetailViewModel.FromDataRow(cinemaRow);
            var actorTable = dataSet.Tables[1];

            foreach (DataRow actorRow in actorTable.Rows)
            {
                AttoriViewModel actorViewModel = AttoriViewModel.FromDataRow(actorRow);
                cinemaDetailViewModel.Attori.Add(actorViewModel);
            }
            return cinemaDetailViewModel;
        }
>>>>>>> e6deb95081e9a60508a572c658882f1cd8ee3f6e
    }
}
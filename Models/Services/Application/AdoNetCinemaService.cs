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
            string query = "SELECT CodFilm, Titolo, Regista, Nazionalita, AnnoProduzione, Genere FROM film";
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
       
    }
}
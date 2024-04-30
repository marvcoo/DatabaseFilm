using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace DatabaseFilm.Models.ViewModels
{
    public class AttoriViewModel
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public int AnnoNascita {get; set;}
        public string Nazionalita {get; set;}

        public static AttoriViewModel FromDataRow(DataRow dataRow)
        {
            var attoriViewModel = new AttoriViewModel
            {
                Id = Convert.ToInt32(dataRow["CodAttore"]),
                Nome = Convert.ToString(dataRow["Nome"]),
                AnnoNascita = Convert.ToInt32(dataRow["AnnoNascita"]),
                Nazionalita = Convert.ToString(dataRow["Nazionalita"])
            };
            return attoriViewModel;
        }
    }
}
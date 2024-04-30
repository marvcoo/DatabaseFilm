using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
namespace DatabaseFilm.Models.Services.Infrastructures
{
    public interface IDatabaseAccessor // interfaccia che rappresenta il servizio infrastrutturale
    {
        DataSet Query(FormattableString query); // metodo che eseguira una query select passata come parametro
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
namespace DatabaseFilm.Models.Services.Infrastructures
{
    public interface IDatabaseAccessor // interfaccia che rappresenta il servizio infrastrutturale
    {
<<<<<<< HEAD
        DataSet Query(string query); // metodo che eseguira una query select passata come parametro
=======
        DataSet Query(FormattableString query); // metodo che eseguira una query select passata come parametro
>>>>>>> e6deb95081e9a60508a572c658882f1cd8ee3f6e
    }
}
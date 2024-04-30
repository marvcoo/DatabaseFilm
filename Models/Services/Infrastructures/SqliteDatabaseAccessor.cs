using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Microsoft.Data.Sqlite;

namespace DatabaseFilm.Models.Services.Infrastructures
{
    public class SqliteDatabaseAccessor : IDatabaseAccessor
    {
<<<<<<< HEAD
        public DataSet Query(string query)
        {
=======
        public DataSet Query(FormattableString formattableQuery)
        {
            var queryArguments = formattableQuery.GetArguments();
            var sqliteParameters = new List<SqliteParameter>();
            for (var i = 0; i < queryArguments.Length; i++)
            {
                var parameter = new SqliteParameter(i.ToString(), queryArguments[i]);
                sqliteParameters.Add(parameter);
                queryArguments[i] = "@"+i;
            }
            string query = formattableQuery.ToString();

>>>>>>> e6deb95081e9a60508a572c658882f1cd8ee3f6e
            using(var conn = new SqliteConnection("Data Source=Data/cinema.db"))
            { 
                conn.Open();
                using(var cmd=new SqliteCommand(query, conn))
                { 
<<<<<<< HEAD
                    using(var reader = cmd.ExecuteReader())
                    { 
                        var dataSet = new DataSet();
                        dataSet.EnforceConstraints=false;
                        var dataTable= new DataTable();
                        dataSet.Tables.Add(dataTable);
                        dataTable.Load(reader);
=======
                    cmd.Parameters.AddRange(sqliteParameters);

                    using(var reader = cmd.ExecuteReader())
                    {
                        var dataSet = new DataSet();
                        dataSet.EnforceConstraints=false;
                        do
                        {                        
                            var dataTable= new DataTable();
                            dataSet.Tables.Add(dataTable);
                            dataTable.Load(reader);
                        } while (!reader.IsClosed);

>>>>>>> e6deb95081e9a60508a572c658882f1cd8ee3f6e
                        return dataSet;
                    }
                }
            }
        }
    }
}
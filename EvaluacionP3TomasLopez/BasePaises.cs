using EvaluacionP3TomasLopez.ModelsTLopez;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionP3TomasLopez
{
    public class BasePaises
    {
        readonly SQLiteAsyncConnection conn;
        public BasePaises(string path) 
        {
            conn= new SQLiteAsyncConnection(path);
            conn.CreateTableAsync<PaisDB>().Wait();
        }


        public Task<List<PaisDB>> GetAllPaises()
        {

            return conn.Table<PaisDB>().ToListAsync();
        }

        public Task<int> GuardarPais(PaisDB paisDB) {
            return conn.InsertAsync(paisDB);
        }

        public Task<int> BorrarPais(PaisDB paisDB) { 
            return conn.DeleteAsync(paisDB);
        }

    }
}

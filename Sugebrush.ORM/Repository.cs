using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Npgsql;

namespace Sugebrush.ORM
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private string _connectionString;

        public Repository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public T Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetCollection()
        {
            using (var db = new NpgsqlConnection(_connectionString))
            {
                db.Open();

                // TODO: Get table from T type name or ...
                var query = "SELECT * FROM public.suser";
                var result = db.Query<T>(query).ToList();

                db.Close();

                return result; 
            }
        }
    }
}
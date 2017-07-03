using Dapper;
using Npgsql;
using Sagebrush.DbModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sugebrush.ORM
{
    public class TestQuery
    {
        private string connectionString = @"User ID=qfvvjywlxzuszt;Password=079852df3ec9b14c88d60c9973e3cb8e06d5083fcf15ac057c7b31863b07a35f;Host=ec2-107-20-226-93.compute-1.amazonaws.com;Port=5432;Database=d2m436bl0ll49d;
                                            Pooling=true;SslMode=Require;Trust Server Certificate=true";
        public IList<SUser> GetUsers()
        {
            List<SUser> list;
            using (var conn = new NpgsqlConnection(connectionString))
            {

                conn.Open();
                var querySQL = @"SELECT id, login, phone FROM public.suser;";
                list = conn.Query<SUser>(querySQL).ToList();
            }
            return list;
        }
    }
}

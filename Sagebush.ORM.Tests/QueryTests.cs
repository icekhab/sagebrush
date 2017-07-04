using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Sugebrush.ORM;
using Xunit;

namespace Sagebush.ORM.Tests
{
    class SysUser : BaseEntity
    {
        public string Login { get; set; }
        public long Phone { get; set; }
    }

    public class QueryTests
    {
        [Fact]
        public void GetUsers()
        {
            var connectionString =
                "User ID=qfvvjywlxzuszt;Password=079852df3ec9b14c88d60c9973e3cb8e06d5083fcf15ac057c7b31863b07a35f;Host=ec2-107-20-226-93.compute-1.amazonaws.com;Port=5432;Database=d2m436bl0ll49d;Pooling=true;SslMode=Require;Trust Server Certificate=true";
            var usersRepo = new Repository<SysUser>(connectionString);
            Assert.NotEmpty(usersRepo.GetCollection());
        }
    }
}

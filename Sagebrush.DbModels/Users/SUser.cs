using System;
using System.Collections.Generic;
using System.Text;

namespace Sagebrush.DbModels.Users
{
    public class SUser
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public long Phone { get; set; }
    }
}

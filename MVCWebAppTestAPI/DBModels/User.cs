using System;
using System.Collections.Generic;

namespace MVCWebAppTestAPI.DBModels
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? IdNumber { get; set; }
    }
}

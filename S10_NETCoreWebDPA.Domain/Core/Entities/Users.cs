using System;
using System.Collections.Generic;

#nullable disable

namespace S10_NETCoreWebDPA.Domain.Core.Entities
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public bool? Status { get; set; }
    }
}

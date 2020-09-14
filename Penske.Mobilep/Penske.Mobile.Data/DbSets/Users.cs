using System;
using System.Collections.Generic;

namespace Penske.Mobilep.Data
{
    public partial class Users
    {
        private string _email;

        public int Id { get; set; }
        public string Email
        {
            get => _email;
            set => _email = value.ToLower();
        }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int? Perfil { get; set; }
        public bool Active { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ComTypes;
using Doodle_Forms.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Doodle_Forms.Migrations
{
    public class User
    {
        public User() { }
        public User(string name, string email, string password, bool isAdmin)
        {
            Name = name;
            Email = email;
            PasswordHash = new Hash(password, Salt).ToString();
            IsAdmin = isAdmin;
        }

        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Salt { get; set; } = new Salt().ToString();
        public string PasswordHash { get; set; }
        public bool IsAdmin { get; set; }
    }
}

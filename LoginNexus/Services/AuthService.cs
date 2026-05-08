using LoginNexus.Models;

namespace LoginNexus.Services
{
    public class AuthService
    {
        private readonly List<User> _users = new()
    {
        new User { email = "daniel@nexus.edu", Password = "123", Role = "Professor", Name = "Dr. Paiva" },
        new User { email = "matheus@nexus.edu", Password = "123", Role = "Student", Name = "Matheus" }
    };

        public User? Authenticate(string email, string password)
        {
            return _users.FirstOrDefault(u => u.email == email && u.Password == password);
        }
    }
}
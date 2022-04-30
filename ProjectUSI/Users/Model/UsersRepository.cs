using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectUSI.Manager.Model;

namespace ProjectUSI.Users.Model
{
    public class UsersRepository
    {
        private List<User> _users;

        public UsersRepository()
        {
            string json = File.ReadAllText(@"C:\Users\ANJA\course-project-6\ProjectUSI\Data\Users.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
            _users = users;
        }
        
        public List<User> GetUsers()
        {
            return this._users;
        }

        public void SetUsers(List<User> value)
        {
            _users = value;
        }

        public User GetUserByEmail(string email)
        {
            foreach (User user in _users)
            {
                if (user.Email.Equals(email))
                {
                    return user;
                }
            }
            return null;
        }

        public void InsertUser(User user)
        {
            _users.Add(user);
        }

        public void DeleteUser(User user)
        {
            _users.Remove(user);
        }

        public void UpdateUser(User user)
        {
            User userForUpdate = GetUserByEmail(user.Email);
            _users.Remove(userForUpdate);
            userForUpdate.Email = user.Email;
            userForUpdate.Password = user.Password;
            userForUpdate.Role = user.Role;
            userForUpdate.Telephone = user.Telephone;
            userForUpdate.FirstName = user.FirstName;
            userForUpdate.LastName = user.LastName;
            userForUpdate.DateOfBirth = user.DateOfBirth;
            userForUpdate.LBO = user.LBO;
            _users.Add(userForUpdate);
        }
        
        public void Save()
        {
            File.WriteAllText(@"C:\Users\ANJA\course-project-6\ProjectUSI\Data\Users.json", JsonConvert.SerializeObject(_users));
        }
    }
}
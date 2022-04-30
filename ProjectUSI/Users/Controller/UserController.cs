using System;
using ProjectUSI.Users.Model;
using ProjectUSI.Users.View;

namespace ProjectUSI.Users.Controller
{
    public class UserController
    {
        private UsersRepository _usersRepository;
        private User _model;
        private LoginWindow _view;

        public UserController(UsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public bool CheckUser(string email, string password)
        {
            User user = _usersRepository.GetUserByEmail(email);
            if (user.Equals(null))
            {
                throw new NullReferenceException();
            }
            else
            {
                if (user.Password.Equals(password))
                {
                    return true;
                }

            }

            return false;
        }

        public User GetUserByEmail(string email)
        {
            return _usersRepository.GetUserByEmail(email);
        }
    }
}
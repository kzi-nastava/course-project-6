using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ProjectUSI.Users.Model
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public string Telephone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string LBO { get; set; }

        public override string ToString()
        {
            return Email + "\t" + FirstName + "\t" + LastName + "\t" + Role + "\t" + Telephone + "\t" + LBO;
        }
        public void Users()
        {
            User u1 = new User()
            {
                Email = "petar@gmail.com",
                Password = "pass123",
                DateOfBirth = DateTime.Now,
                FirstName = "Petar",
                LastName = "Petrovic",
                LBO = "01236547897",
                Role = Role.Manager,
                Telephone = "065421454"
            };
            User u2 = new User()
            {
                Email = "marko@gmail.com",
                Password = "pass523",
                DateOfBirth = DateTime.Now,
                FirstName = "Marko",
                LastName = "Markovic",
                LBO = "01236747897",
                Role = Role.Patient,
                Telephone = "065429454"
            };
            User u3 = new User()
            {
                Email = "janko@gmail.com",
                Password = "pass111",
                DateOfBirth = DateTime.Now,
                FirstName = "Janko",
                LastName = "Jankovic",
                LBO = "01236785897",
                Role = Role.Doctor,
                Telephone = "0611329454"
            };
            List<User> users = new List<User>();
            users.Add(u1);
            users.Add(u2);
            
            File.WriteAllText(@"C:\Users\ANJA\course-project-6\ProjectUSI\Data\Users.json", JsonConvert.SerializeObject(users));
            
        }

        public List<User> ReadUsers()
        {
            string json = File.ReadAllText(@"C:\Users\ANJA\course-project-6\ProjectUSI\Data\Users.json");
            var users = JsonConvert.DeserializeObject<List<User>>(json);
            return users;
        }
    }
}
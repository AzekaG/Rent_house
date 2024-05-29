using Rent_house.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_house.DAL.Interfaces
{
    public interface IRepositoryUser<User> where User : Entities.User
    {
        public Task<IEnumerable<User>> GetUserList();

        public Task<User> GetUserById(int id);

        public Task<User> GetUserByEmail(string email);

        public Task Create(User user);

        public void Update(User user);

        public Task Delete(int id);

        public Task<bool> IsUserExist(int id);




    }
}

using Microsoft.EntityFrameworkCore;
using Rent_house.DAL.EF;
using Rent_house.DAL.Entities;
using Rent_house.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_house.DAL.Repositories
{
    public class UserRepository : IRepositoryUser<User>
    {
        readonly HouseDbContext _userDbContext;


        public UserRepository(HouseDbContext userDbContext) => _userDbContext = userDbContext;

        public async Task<IEnumerable<User>> GetUserList() => await _userDbContext.Users.ToListAsync();

        public async Task<User> GetUserById(int id) => await _userDbContext.Users.SingleOrDefaultAsync(x => x.Id == id);

        public async Task<User> GetUserByEmail(string email) => await _userDbContext.Users.SingleOrDefaultAsync(x => x.Email == email);

        public async Task Create(User user) => await _userDbContext.Users.AddAsync(user);

        public async void Update(User user)
        {
            _userDbContext.Users.Update(user);

            //_userDbContext.Entry(user).State = EntityState.Modified;
            _userDbContext.SaveChanges();
        }
        public async Task Delete(int id)
        {
            if(await IsUserExist(id))
            {
                _userDbContext.Users.Remove(await GetUserById(id));
            }
            _userDbContext.SaveChanges();
        }

        public async Task<bool> IsUserExist(int id) => await _userDbContext.Users.AnyAsync(x => x.Id == id);



    }



}

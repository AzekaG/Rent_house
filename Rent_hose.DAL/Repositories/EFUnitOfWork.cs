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
    internal class EFUnitOfWork : IUnitOfWork
    {
        HouseDbContext _houseUserDbContext { get; set; }
        
        UserRepository _userRepository { get; set; }

        HouseRepository _houseRepository { get; set; }

        public EFUnitOfWork(HouseDbContext houseUserDbContext) => _houseUserDbContext = houseUserDbContext;

        public IRepositoryHouse<House> Houses
        {
            get
            {
                if(_houseRepository == null)
                {
                    _houseRepository = new HouseRepository(_houseUserDbContext);
                }
                return _houseRepository;
            }
        }

        public IRepositoryUser<User> Users
        {
            get
            {
                if (_userRepository == null) 
                {
                    _userRepository = new UserRepository(_houseUserDbContext);
                }
                return _userRepository;
            }
        }

        public async Task Save()
        {
            await _houseUserDbContext.SaveChangesAsync();
        }



    }
}

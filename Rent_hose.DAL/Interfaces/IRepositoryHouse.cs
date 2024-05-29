using Rent_house.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_house.DAL.Interfaces
{
    public interface IRepositoryHouse<House> where House : Entities.House
    {
        public Task<IEnumerable<House>> GetHouseList();

        public Task<IEnumerable<House>> GetAllHouseByUser(int userId);

        public Task<House> GetHouseById(int id);

        public Task Create(House house);

        public void Update(House house);

        public Task Delete(int id);

        public Task<bool> IsHouseExist(int id);









    }
}

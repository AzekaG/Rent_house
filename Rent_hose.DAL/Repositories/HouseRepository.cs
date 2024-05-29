using Microsoft.EntityFrameworkCore;
using Rent_house.DAL.EF;
using Rent_house.DAL.Entities;
using Rent_house.DAL.Interfaces;

namespace Rent_house.DAL.Repositories
{
    public class HouseRepository : IRepositoryHouse<House>
    {
        readonly HouseDbContext _houseDbContext;

        public HouseRepository(HouseDbContext houseDbContext) => _houseDbContext = houseDbContext;


        public async Task<IEnumerable<House>> GetHouseList() => await _houseDbContext.Houses.Include(x => x.Images_Path).Include(u => u.Owner).ToListAsync();


        public async Task<IEnumerable<House>> GetAllHouseByUser(int userId) => await _houseDbContext.Houses.Where(x => x.Owner.Id == userId).ToListAsync();


        public async Task<House> GetHouseById(int id) => await _houseDbContext.Houses.Where(x => x.Id == id).FirstOrDefaultAsync();


        public async Task Create(House house) => await _houseDbContext.Houses.AddAsync(house);


        public void Update(House house)  //NEED TO CHECK
        {
            //1 variant
            _houseDbContext.Houses.Update(house);

            //2 variant
            //_houseDbContext.Entry(house).State = EntityState.Modified;
        }

        public async Task Delete(int id)
        {
            var house = await _houseDbContext.Houses.FindAsync(id);
            if(house != null)
                _houseDbContext.Houses.Remove(house);
            await _houseDbContext.SaveChangesAsync();
        }


        public Task<bool> IsHouseExist(int id) => _houseDbContext.Houses.AnyAsync(x => x.Id == id);
      







    }
}

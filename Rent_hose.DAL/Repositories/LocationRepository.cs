using Microsoft.EntityFrameworkCore;
using Rent_house.DAL.EF;
using Rent_house.DAL.Entities;
using Rent_house.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_house.DAL.Repositories
{
    internal class LocationRepository : IRepositoryLocation
    {

        readonly HouseDbContext _houseDbContext;

        public LocationRepository(HouseDbContext houseDbContext)
        {
            _houseDbContext = houseDbContext;
        }



        public async Task<IEnumerable<City>> GetCityList() => await _houseDbContext.Cities.ToListAsync();
       

        public async Task<IEnumerable<Country>> GetCountryList() => await _houseDbContext.Countries.ToListAsync();


        public async Task<IEnumerable<District>> GetDistrictList() => await _houseDbContext.Districts.ToListAsync();



        public async Task<City> GetCityById(int id) => await _houseDbContext.Cities.FirstAsync(x => x.Id == id);

        public async Task<Country> GetCountryById(int id) => await _houseDbContext.Countries.FirstAsync(x => x.Id == id);

        public async Task<District> GetDistrictById(int id) => await _houseDbContext.Districts.FirstAsync(x => x.Id == id);



        public async Task CreateCity(City city) => await _houseDbContext.Cities.AddAsync(city);

        public async Task CreateCountry(Country country) => await _houseDbContext.Countries.AddAsync(country);

        public async Task CreateDistrict(District district) => await _houseDbContext.Districts.AddAsync(district);


        public async Task DeleteCity(int id)
        {
            if (await GetCityById(id) != null)
            {
                 _houseDbContext.Cities.Remove(await GetCityById(id));
            }
            _houseDbContext.SaveChanges();
        }

        public async Task DeleteCountry(int id)
        {
            if (await GetCountryById(id) != null)
            {
                _houseDbContext.Countries.Remove(await GetCountryById(id));
            }
            _houseDbContext.SaveChanges();
        }

        public async Task DeleteDistrict(int id)
        {
            if (await GetDistrictById(id) != null)
            {
                _houseDbContext.Districts.Remove(await GetDistrictById(id));
            }
            _houseDbContext.SaveChanges();
        }
    }
}

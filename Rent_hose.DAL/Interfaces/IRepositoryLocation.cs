using Rent_house.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_house.DAL.Interfaces
{
    public interface IRepositoryLocation
    {
        public Task<IEnumerable<City>> GetCityList();

        public Task<IEnumerable<Country>> GetCountryList();

        public Task<IEnumerable<District>> GetDistrictList();



        public Task<City> GetCityById(int id);

        public Task<Country> GetCountryById(int id);

        public Task<District> GetDistrictById(int id);



        public Task CreateCity(City city);

        public Task CreateCountry(Country country);

        public Task CreateDistrict(District district);


        public Task DeleteCity(int id);

        public Task DeleteCountry(int id);

        public Task DeleteDistrict(int id);









    }
}

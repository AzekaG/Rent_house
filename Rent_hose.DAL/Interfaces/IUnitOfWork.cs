using Rent_house.DAL.Entities;


namespace Rent_house.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        public IRepositoryHouse<House> Houses { get; }
        public IRepositoryUser<User> Users { get; }




        public Task Save();
    }
}

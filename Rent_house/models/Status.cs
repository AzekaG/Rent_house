namespace Rent_house.models
{
    public class Status
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<User> User { get; set; }

        public Status() 
        {
            User = new List<User>();
        }
    }
}

namespace Rent_house.models
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public string? Number { get; set; }
        public string? Password { get; set; }

        public string? Salt { get; set; }

        public Status? Status { get ; set; }

        public bool Active { get; set; }

        public List<House>? Houses { get; set; }


        public User()
        {
            Houses = new List<House>();
        }
       
    }
}

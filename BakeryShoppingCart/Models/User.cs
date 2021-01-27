namespace BakeryShoppingCart.Models
{
    public class User
    {
        public User()
        {
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; internal set; }
        public string Password { get; internal set; }
    }
}

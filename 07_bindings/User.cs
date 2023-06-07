namespace _07_bindings
{
    public class User
    {
        public string Username { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return $"User {Username} has socre of {Score}";
        }
    }
}

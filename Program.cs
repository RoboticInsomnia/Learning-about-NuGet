using Newtonsoft.Json; // to use Newtonsoft.Json API

namespace Nuget.Quickstart
{
    public class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account
            {
                Name = "Orion Dev",
                Email = "Orion@nuget.org",
                DOB = new DateTime(1984, 11, 19, 0, 0, 0, DateTimeKind.Utc), 
            };

            string json = JsonConvert.SerializeObject(account, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
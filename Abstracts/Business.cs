using System.Collections.Generic;

namespace theater.Abstracts
{
    public abstract class Business
    {
        public string Name { get; set; }
        public string PrimaryAddress { get; set; }
        public List<string> Addresses { get; set; }
        public Dictionary<string, string> Licenses { get; set; }

        public virtual void AddLocation(string x)
        {
            System.Console.WriteLine("BUSINESS ADD LOCATION: "  + x);
            Addresses.Add(x);
        }

        public Business(string name, string address)
        {
            Name = name;
            PrimaryAddress = address;
            Addresses = new List<string>();
            Addresses.Add(PrimaryAddress);
            Licenses = new Dictionary<string, string>();
        }

    }
}
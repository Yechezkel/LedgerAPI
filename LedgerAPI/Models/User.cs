using LedgerAPI.Models;
using System.Text.Json.Serialization;

namespace LedgerAPI
{
    public class User
    {
        [JsonIgnore]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [JsonIgnore]
        public List<Ledger> Ledgers { get; set; }=new List<Ledger>();

    }
}

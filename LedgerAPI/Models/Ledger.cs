using System.Text.Json.Serialization;

namespace LedgerAPI.Models
{
    public class Ledger
    {
        [JsonIgnore]
        public int LedgerId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
        [JsonIgnore]
        public List<User> Members { get; set; }=new List<User>();
    }
}

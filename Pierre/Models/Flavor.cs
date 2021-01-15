using System.Collections.Generic;

namespace Pierre.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.Treats = new HashSet<FlavorTreat>();
        }
        public int FlavorId { get; set; }
        public string FlavorType { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<FlavorTreat> Treats { get; set; }
    }
}
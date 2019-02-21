using System.Collections.Generic;

namespace Demo.Models
{
    public class IpRange
    {
        public int Id { get; set; }

        public string Range { get; set; }

        public string Mask { get; set; }

        public bool IsUnused { get; set; }

        public ICollection<Setad> Setads { get; set; }
    }
}
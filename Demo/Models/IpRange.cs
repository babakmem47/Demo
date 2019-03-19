using System;
using System.Collections.Generic;

namespace Demo.Models
{
    public class IpRange
    {
        public IpRange()
        {
            Setads = new List<Setad>();
        }

        public int Id { get; set; }

        public string Range { get; set; }

        public string Mask { get; set; }

        public bool IsUnused { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public ICollection<Setad> Setads { get; set; }
    }
}

using System.Collections.Generic;

namespace Demo.Models
{
    public class Province
    {
        public int Id { get; set; }

        public string ProvinceName { get; set; }

        public string CityCenter { get; set; }

        public string PreTelCode { get; set; }

        public ICollection<Setad> Setads { get; set; }
    }
}
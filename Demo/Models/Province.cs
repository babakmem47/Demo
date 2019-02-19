
namespace Demo.Models
{
    public class Province
    {
        public int Id { get; set; }

        public string ProvinceName { get; set; }

        public byte Octet3 { get; set; }

        public string CityCenter { get; set; }

        public string PreTelCode { get; set; }

        public Setad Setad { get; set; }

        public int SetadId { get; set; }
    }
}
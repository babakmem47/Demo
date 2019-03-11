namespace Demo.Models
{
    public class Setad
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Shakhes { get; set; }

        public bool IsModiriatShoab { get; set; }

        public string Address { get; set; }

        public IpRange IpRange { get; set; }

        public int IpRangeId { get; set; }

        public string Email { get; set; }

        public Province Province { get; set; }

        public int? ProvinceId { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
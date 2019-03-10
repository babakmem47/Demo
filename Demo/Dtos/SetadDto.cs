namespace Demo.Dtos
{
    public class SetadDto
    {
        public string Name { get; set; }
        public string Shakhes { get; set; }
        public bool IsModiriatShoab { get; set; }
        public string Address { get; set; }
        public IpRangeDto IpRange { get; set; }
        public string Email { get; set; }
        public ProvinceDto Province { get; set; }
        public int? ProvinceId { get; set; }
    }

}
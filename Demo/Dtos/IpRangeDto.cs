using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Demo.Dtos
{
    public class IpRangeDto
    {
        public IpRangeDto()
        {
            SetadDtos = new Collection<SetadDto>();
        }

        public string Range { get; set; }
        public string Mask { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public ICollection<SetadDto> SetadDtos { get; set; }
    }
}
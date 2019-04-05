using Demo.Models;
using System;
using System.Collections.Generic;

namespace Demo.Dtos
{
    public class IpRangeDto
    {
        public int IprangeId { get; set; }
        public string Range { get; set; }
        public string Mask { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        //public IEnumerable<Setad> SetadDtos { get; set; }

        public string RelatedSetad { get; set; }
    }
}
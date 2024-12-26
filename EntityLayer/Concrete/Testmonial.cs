using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testmonial
    {
        [Key]
        public int TestmonialId { get; set; }
        public string TestmonialName { get; set; }
        public string TestmonialCompany { get; set; }
        public string TestmonialComment { get; set; }
        public string TestmonialImage { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int PortfolioId { get; set; }
        public string PortfolioName { get; set; }
        public string PortfolioUrl { get; set; }
        public string PortfolioProject { get; set; }
        public string PortfolioImage { get; set; }
    }
}

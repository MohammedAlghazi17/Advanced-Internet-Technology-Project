using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stockmarket.Models
{
    public class Price
    {
        private ICollection<Company> _companies;
        public Price()
        {
            _companies = new List<Company>();

        }

        public int CurrentPrice { get; set; }
        public int Volume { get; set; }
         
        public int date { get; set; }

        public virtual ICollection<Company> Companies
        {
            get { return _companies; }
            set { _companies = value; }
        }

        

    }
}
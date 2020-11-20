using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stockmarket.Models
{
    public class Exchange
    {
        private ICollection<Company> _companies;
        public Exchange()
        {
            _companies = new List<Company>();
        }
        public string Name { get; set; }

        public virtual ICollection<Company> Companies
        {
            get { return _companies; }
            set { _companies = value; }
        }
        

    }
}
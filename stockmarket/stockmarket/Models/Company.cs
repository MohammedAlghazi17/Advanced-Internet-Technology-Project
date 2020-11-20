using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stockmarket.Models
{
    public class Company
    {
        private ICollection<Exchange> _exchanges;
        public Company()
        {
            _exchanges = new List<Exchange>();


        }
        public string CompanyName { get; set; }
        public string CompanyTicker { get; set; }

        public virtual ICollection<Exchange> Exchanges
        {
            get { return _exchanges; }
            set { _exchanges = value; }
        }
    }
}
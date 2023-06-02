using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    public class Costomer
    {
        public Costomer(string phone, string neme, string surneme)
        {
            PhoneNamber = phone;
            NameСustomer = neme;
            SurnemCustomer = surneme;
        }

        public string PhoneNamber { get; set; }
        public string NameСustomer { get; set; }
        public string SurnemCustomer { get; set; }
    }
}

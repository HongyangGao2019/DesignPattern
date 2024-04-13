using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Factory:ISellClothes
    {
        Customer customer;
        public Factory(Customer customer)
        {
            this.customer = customer;
        }
        public void SellClothes(){
            Console.WriteLine($"sell to {customer.name}");
        }
    }
}
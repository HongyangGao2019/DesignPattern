using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Proxy:ISellClothes
    {
        Factory factory;
        public Proxy(Customer customer){
            factory=new Factory(customer);
        }
        public void SellClothes(){
            factory.SellClothes();
        }
    }
}
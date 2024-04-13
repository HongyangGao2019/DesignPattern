using ProxyPattern;

Customer customer=new Customer("xiaohong");
Proxy proxy=new Proxy(customer);
proxy.SellClothes();
Console.ReadKey();
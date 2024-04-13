using DecoratorPattern;

AbstractPerson person=new NormalPerson();
AbstractDecorator pants=new Pants();
AbstractDecorator tShirt=new TShirt();
AbstractDecorator underwear=new Underwear();
underwear.SetWearPerson(person);
pants.SetWearPerson(underwear);
tShirt.SetWearPerson(pants);
tShirt.Show();
Console.ReadKey();
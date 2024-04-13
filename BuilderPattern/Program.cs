using BuilderPattern;

DishDirector dishDirector= new DishDirector();
Dish friedPatato=new FriedPatato();
dishDirector.Cook(friedPatato);
Console.ReadKey();

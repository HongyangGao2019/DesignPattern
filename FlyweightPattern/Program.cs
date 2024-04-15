using System.Xml;
using FlyweightPattern;

PeopleFactory peopleFactory=new PeopleFactory();
People people01=peopleFactory.GetPeopleCitizenship("Chinese");
// blak.ShowSkin(new User("Gogo",SkinColor.Yellow));
People people02=peopleFactory.GetPeopleCitizenship("Chinese");
<<<<<<< HEAD
People people03=peopleFactory.GetPeopleCitizenship("English");
=======
>>>>>>> be9e73f728846f7d773c19370643d4541a175eb9
peopleFactory.ShowCitizenshipCount();

((IRegister)people01).Register("Gao",SkinColor.Yellow);
((IRegister)people02).Register("Guang",SkinColor.Black);
people01.ShowID();
people02.ShowID();

Console.WriteLine("-----After Modify");
((IRegister)people01).ModifyName("Kao");
people01.ShowID();
// whit.ShowSkin(new User("Gogo",SkinColor.White));
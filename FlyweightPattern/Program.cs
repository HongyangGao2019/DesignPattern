using System.Xml;
using FlyweightPattern;

PeopleFactory peopleFactory=new PeopleFactory();
People people01=peopleFactory.GetPeopleCitizenship("Chinese");
// blak.ShowSkin(new User("Gogo",SkinColor.Yellow));
People people02=peopleFactory.GetPeopleCitizenship("Chinese");
peopleFactory.ShowCitizenshipCount();

((IRegister)people01).Register("Gao",SkinColor.Yellow);
((IRegister)people02).Register("Guang",SkinColor.Black);
people01.ShowID();
people02.ShowID();

Console.WriteLine("-----After Modify");
((IRegister)people01).ModifyName("Kao");
people01.ShowID();
// whit.ShowSkin(new User("Gogo",SkinColor.White));
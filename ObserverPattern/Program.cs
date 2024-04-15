using ObserverPattern;

Bell bell= new Bell();
IObserver teacher= new Teacher("Mr.Li");
IObserver tony=new Student("Tony");
IObserver jenny=new Student("Jenny");
bell.Attach(teacher);
bell.Attach(tony);
bell.Attach(jenny);
bell.Notify();
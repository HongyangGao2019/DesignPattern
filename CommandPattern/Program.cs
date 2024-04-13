using CommandPattern;

Reciever student=new Student();
Command command=new DoHomework();
Commander teacher=new Teacher();

command.SetCommand(student);
teacher.AddCommander(command);
teacher.Notify();
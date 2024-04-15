using InterpreterPattern;

Context context=new Context();
context.Input="That is B";
AbstractInterpreter interpreter=new ConcreteInterpreter();
interpreter.Interpret(context);
Console.WriteLine($"{context.Output}");
using InterpreterPattern;

Context context=new Context();
context.Input="That is ";
AbstractInterpreter interpreter=new ConcreteInterpreter();
interpreter.Interpret(context);
Console.WriteLine($"{context.Output}");
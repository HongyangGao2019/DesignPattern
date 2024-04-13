using ChainOfResponsibilityPattern;

Handler grandfather= new GrandfatherHandler();
Handler father= new FatherHandler();
Handler son= new SonHandler();

son.SetNextHandler(father);
father.SetNextHandler(grandfather);

son.Handle(Family.Father);
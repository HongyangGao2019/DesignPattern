using CompositePattern;

Level level0=new EasyLevel("Level0");

Level level00=new EasyLevel("level00");
Level level01=new DifficultLevel("level01");
level0.Add(level00);
level0.Add(level01);

Level level010=new NormalLevel("level010");
level01.Add(level010);
level0.ShowLevelInfo(1);


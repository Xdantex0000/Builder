using Builder;

BuilderA builder = new();
Director director = new(builder);

director.Make();

Console.WriteLine(builder.GetResult().GetDescription());

builder.Reset();
director.Make("simple");

Console.WriteLine(builder.GetResult().GetDescription());

BuilderB builderB = new();
director.ChangeBuilder(builderB);

director.Make();

Console.WriteLine(builderB.GetResult().GetDescription());

builderB.Reset();
director.Make("simple");

Console.WriteLine(builderB.GetResult().GetDescription());
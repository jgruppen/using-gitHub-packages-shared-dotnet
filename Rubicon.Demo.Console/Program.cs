

Rubicon.Demo.Shared.Service service = new Rubicon.Demo.Shared.Service();

int x = 10;
int y = 20;

int plusResult = service.Plus(x, y);
int minusResult = service.Minus(x, y);

Console.WriteLine($"Plus:  {x} + {y} = {plusResult}");
Console.WriteLine($"Minus: {x} + {y} = {minusResult}");
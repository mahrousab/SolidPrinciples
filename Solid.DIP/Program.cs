using Solid.DIP;

HighLevel highLevel = new HighLevel(new LowLevel());
Console.WriteLine(highLevel.DisplayMessage());
// before using LSP 

/*
using Solid.LSP.Before;

Lexus lexus =  new Mercedes();

Console.WriteLine(lexus.Color());

*/
// After using LSP 
using Solid.LSP.After;


IVehicle vehicle = new Lexus();

vehicle = new Mercedes();
Console.WriteLine(vehicle.Color());
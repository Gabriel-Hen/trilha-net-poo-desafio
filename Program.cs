using DesafioPOO.Models;

Console.WriteLine("Smartphone modelo nokia:");

Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia2", imei: "123", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine();
Console.WriteLine("Smartphone modelo Iphone:");

Smartphone iphone = new Iphone(numero: "123456", modelo: "Iphone2", imei: "123", memoria: 32);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");
using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "987654", modelo: "Nokinha", imei: "147852", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo(nomeApp: "Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "741852", modelo: "Pro", imei: "987654", memoria: 124);
nokia.Ligar();
iphone.InstalarAplicativo(nomeApp: "Telegram");
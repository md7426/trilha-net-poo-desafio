using DesafioPOO.Models;

Console.WriteLine("Smartphone da Nokia:");
Nokia nokia = new Nokia(numero: "1234567899", modelo: "modelo 1", imei: "837463567273876", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Github");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "1234567899", modelo: "modelo 1", imei: "837463567273876", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
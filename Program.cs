using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "98996-8999", modelo: "Tijolão", imei: "111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ApresentarDados();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "97563-2541", modelo: "Pro 15", imei: "222222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
iphone.ApresentarDados();

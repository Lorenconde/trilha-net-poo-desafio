using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "99999-1111", modelo: "Nokia Tijolão", imei: "123456789", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake Game");

Console.WriteLine("\n------------------------------\n");

Smartphone iphone = new Iphone(numero: "88888-0000", modelo: "iPhone 15 Pro", imei: "987654321", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

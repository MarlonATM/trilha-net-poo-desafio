using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("999454222", "N90", "74OD45", 8);
Console.WriteLine($"Smartphone número {nokia.Numero}:");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.Write("\n");

Smartphone iphone = new Iphone("999727299", "14 PRO", "26UBFD98", 8);
Console.WriteLine($"Smartphone número {iphone.Numero}: ");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("COD");
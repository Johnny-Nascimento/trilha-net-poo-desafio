using DesafioPOO.Models;

Console.WriteLine("IPHONE");
Iphone iphone = new Iphone("1234", "5", "1234", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Angry Birds");

Console.WriteLine("NOKIA");
Nokia nokia = new Nokia("567", "10", "567", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Angry Birds");
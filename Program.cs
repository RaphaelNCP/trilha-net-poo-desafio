using DesafioPOO.Models;

Nokia nokia = new("123456789", "Nokia 3310", "123456789", 16);
Iphone iphone = new("987654321", "Iphone 12", "987654321", 128);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
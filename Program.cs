using DesafioPOO.Models;

Nokia nokia = new Nokia("47912341234","1234","Nokia 5", 32);
Iphone iphone= new Iphone("47912341234","1234","Iphone 7", 64);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
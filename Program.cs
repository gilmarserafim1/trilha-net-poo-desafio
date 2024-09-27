using DesafioPOO.Models;

Nokia nokia = new Nokia("+55(11)99999-9999", "G11 Plus", "654684546548", 64);
Iphone iphone = new Iphone("+55(11)99000-0000", "16 Pró Max", "84946565468", 256);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
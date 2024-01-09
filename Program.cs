using DesafioPOO.Models;

Nokia n1 = new Nokia("99696-9696", "C2", "123456", 32);
n1.Ligar();
n1.InstalarAplicativo("Whatsapp");

Iphone i1 = new Iphone("99898-9898", "14 Pro Max", "654321", 128);
i1.ReceberLigacao();
i1.InstalarAplicativo("Telegram");
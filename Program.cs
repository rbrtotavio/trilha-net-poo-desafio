using DesafioPOO.Models;

// OK
Console.WriteLine("Smartphone Nokia =============");
Smartphone nokia = new Nokia(
    numero:"24601", modelo: "Bookworm 12", imei: "40028922", memoria: 64);

nokia.Ligar();
nokia.InstalarAplicativo("Obsidian.md");

Console.WriteLine("Smartphone Iphone ============");
Smartphone iphone = new Iphone(
    numero:"2345678", modelo: "IqDelicia 15", imei: "26122000", memoria: 128);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Notion");
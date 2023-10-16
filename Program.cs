using DesafioPOO.Models;

Smartphone iphone = new Iphone(numero: "859923456", modelo: "15", imei: 24356, memoria: 125);
iphone.Ligar();
iphone.InstalarAplicativo("Call of dutty mobile");

Smartphone nokia = new Nokia(numero: "85993445866", modelo: "55", imei: 87534, memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");
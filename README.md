# QRKodOlusturucu
 
QR kod oluşturmak için gerekli olan QRCoder paketini yüklememiz lazım. Paket Yönetici Konsoluna bu kodu yazarak paketi yükleyebilirsiniz.
Install-Package QRCoder -Version 1.4.3


Kod içindeki QRCodeGenerator.ECCLevel.H komutundaki H,L,Q,M farklı düzeltme oranları sunuyor burada en kaliteli QR kodu oluşturmak için H olanı kullanıyoruz.
Düzeltme oranları ise şu şekilde:

Level L = yaklaşık %7 civarında düzeltme sağlar.
Level M = yaklaşık %15 civarında düzeltme sağlar.
Level Q = yaklaşık %25 civarında düzeltme sağlar.
Level H = yaklaşık %30 civarında düzeltme sağlar.


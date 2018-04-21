# Türkçe-İngilizce Sözlük Uygulaması

Visual Studio 2013 Geliştirme Ortamında C# Programlama Dili İle Hazırlanmış Basit Bir Çeviri Uygulamasıdır.

## Kullanım

İngilizce-Türkçe Çeviride İngilizce Kelime Kutusuna Aramak İstediğiniz Kelimeyi Tam Olarak Yazın Ve Listede Kelimeye Tıklayın.<br />
Çevirisi Türkçe Kelime Kutusunda Çıkacaktır...<br />
Türkçe-İngilizce Çeviri Seçeneğinde De Aynı Adımları Uygulayarak Çeviriye Ulaşabilirsiniz. <br />

## Kurulum

1-) 'DboSozluk' Adında Veritabanı Oluşturun. <br /> <br />
2-) Oluşturduğunuz Veritabanında 'TBL_KELIMELER' İsimle Tablo Oluşturun. <br /> <br />
3-) Bu Tabloda ID,INGILIZCE,TURKCE Alanları Oluşturun.ID Birincil Anahtar Ve Otomatik Artan Olsun.INGILIZCE VE TURKCE varchar(50) Olabilir. <br /> <br />
4-) FrmIngilizce.cs Ve FrmTurkce.cs İçinde Bulunan SqlConnection baglanti Da Ki Veritabanı Adresini Kendi Veritabanı Adresini İle Değiştirin. <br /> <br />

### Örnek Resimler

![Resim1](https://github.com/berkekurnaz/CSharpExamples/blob/master/SozlukUygulamasi/Resimler/Sozluk1.png) <br />
![Resim2](https://github.com/berkekurnaz/CSharpExamples/blob/master/SozlukUygulamasi/Resimler/Sozluk2.png) <br />
![Resim3](https://github.com/berkekurnaz/CSharpExamples/blob/master/SozlukUygulamasi/Resimler/Sozluk3.png) <br />

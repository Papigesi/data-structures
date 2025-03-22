Metropol kentlerden 8 tanesi şehirler dizisinde verilmiştir:  
    Şehirler = {İstanbul, Roma, Paris, Madrid, New York, Moskova, Londra, Pekin} 

Seyahat planınızı oluşturunuz: 8 şehir içerisinden random 4 farklı şehri seyahat planına ekleyen 
(kodu) yazınız. İkinci şehrin seçiminde ilk seçilen şehri listeden çıkartıp kalan 7 şehir 
içerisinden random seçim yaptırabilirsiniz. Not: Çok yakın zamanlarda farklı random sayılar 
üretmek için, Random nesnesini static olarak fonksiyonun dışında & üstünde tanımlamalısınız  
    static Random r = new Random(); 
    static void Main(string[] args) 
    { for (int i = 0; i < 10; ++i) 
        Console.WriteLine(r.Next(50)); } 
        
b) a seçeneğinde oluşturduğunuz seyahat planınızdaki 4 şehir için, tüm farklı şehir ikilileri 
kombinasyonlarını, her bir elemanı ŞehirÇifti nesnesi olan şehirÇiftleri dizisine aktaran 
metodu yazınız. ŞehirÇifti sınıfı, şehirAdları dizisi (2 elemanlı) ve puan bilgilerini 
içermelidir. Lab. örneği kapsamında puan değerlerini 100 üzerinden random verebilirsiniz. 
İstanbul, Londra, New York ve Moskova için bazı kombinasyonlar { (İstanbul, Londra, 70), 
(İstanbul, New York, 80), (Londra, Moskova, 60), … }

c) şehirÇiftleri dizisini sırayla dolaşarak tüm elemanlarının bilgilerini ekrana listeleyen 
metodu yazınız.  

d) şehirÇiftleri dizisini sırayla dolaşarak içinde İstanbul olan tüm şehir çiftlerini ekrana 
listeleyen metodu yazınız.
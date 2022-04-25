# Yapi-Market-Proje
## Proje önerisi açıklaması:
E-Ticaret sitelerinin veya küçük çaplı yapı market işletmelerinin kullanabileceği. Üye yönetiminin olduğu, sonradan yeni ürünlerin eklenebilen yani güncelleştirebilen bir alım satım otomasyon projesidir. Bu zamana kadar öğrendiğimiz bilgileri kullanarak ve geliştirerek yapmayı amaçlıyorum.

proje öneri: hülya demirel

## UML :
![Yapi market uml (2)](https://user-images.githubusercontent.com/100669779/165162745-02798101-a73d-43b0-911a-4900adb5ebe6.png)
## Proje nasıl çalışır 
Uygulama Nasıl Kullanılır İçeriğinde Neler var ?

### Giriş kısmı 

+ Giriş kısmında kullanıcı adı ve şifre kısmını doldurarak uygulamayı aktif kullanmaya başlanır eğer yeni kayıt var ise altta bulunan kayıt ol kısma tıklayarak kullanılmaya başlanır.

### Müzik ekleme

+ Hem uygulama çalışsın hem de işyerinde evlerde ofislerde vs kullanıcı isterse müzik çalma kısmından müzik dinleyebilir dilerse ekleyebilir

### Personeller 

+ Bu bölümde personel kaydı listesi personellere ait bilgiler tutulur.
+ Kullanıcı dilerse eğer şirket işyeri sahibi ise personeler güncelleme kısmından silme ekleme yapabilir.

### Satışlar 

+ Bu bölüm günlük satış ve genel satış olmak üzere ikiye ayrılır.
+ Günlük satışta kullanıcı o zamana kadar yaptığı tüm satışları gününe müşteri bilgisine ücretine sayısına kadar tüm genel satış bilgilerini tutar.

### Ürünler 
+ Bu bölümde ise ürünlere ait tüm bilgiler bulunur alındığı tutartan satıldığı tutara kadar fiyat adet stok durumu alınan satılan sipariş tarihleri bulunur.

### Çıkış
+ Bu bölümde de kullanıcının işlerini bitirdikden sonra buradan güvenli bir çıkış yapabileci kısım bulunur.

## Database Gereksinimleri
### Tablolar
1. #### Giriş Tablosu
+ | id (int)           | email  (varchar50)          | kullaniadi(varchar20)  | sifre(varchar20)  |
  | ------------------ |:---------------------------:| ----------------------:| -----------------:|
2. #### Ürünler Tablosu
+ | id (int)           | urunIsim  (varchar50)       | urunFiyat (varchar50)  | urunStok (varchar50)  | urunBoyut (varchar50)  |
  | ------------------ |:---------------------------:| ----------------------:| -----------------:| -----------------:|
3. #### Satışlar Tablosu
+ | id (int)           | satisIsim (varchar50)      | satisFiyat(varchar50)  | 
  | ------------------ |:---------------------------:| ----------------------:| 
4. #### Personel Tablosu
+ | id (int)           | isim(varchar50)       | soyisim(varchar50)  | maas(varchar50)  | email(varchar50)  | telno(varchar50) | adres(varchar150)  |
  | ------------------ |:---------------------:| -------------------:| ----------------:| -----------------:| ----------------:| -------------------:|
5. #### Günlükler Tablosu
+ | id (int)           | gunlukSatis(varchar50)      | 
  | ------------------ |:---------------------------:|

## Zaman Çizelgesi
 
  12.03.2022 ==== Projeye karar verildi.
  13.03.2022 ==== UML ile use-case sernaryosu yapılıp paylaşıldı.
  25.03.2022 ==== Proje taslağı kuruldu.
  26.04.2022 ==== Kodlar yazılmaya başlandı.
  26.04.2022 ==== İlk cs'ler paylaşıldı.
  

# Otel-Rezervasyon-Uygulamasi
- Kullanıcı yapmak istediği işleme göre Yönetici ve Müşteri modülü olmak üzere iki şekilde giriş yapabilecek.
  
- Müşteri modülünde müşteri kendinden istenilen bilgileri sisteme girerek istediği odayı seçebilecek ve rezervasyonunu yapabilecek.
  
- Yönetici modülünde ise yönetici kullanıcı adı ve şifresiyle giriş yaptıktan sonra rezervasyonları görüntüleyebilecek, güncelleyebilecek ve rezervasyonları iptal edebilecek.
  #
  #
  ## Diyagramlar
  ### Class Diyagramı
  ![Class](https://github.com/user-attachments/assets/87ea3a3b-e04d-47c5-8946-35022247db5f)

  ### UseCase Diyagramı
  ![UseCase](https://github.com/user-attachments/assets/825c04e4-8a5c-4291-a94b-70f3c7b18481)

  ### ER Diyagramı
  ![ER](https://github.com/user-attachments/assets/910cca84-4d10-499f-9dd3-bac415ebb9dd)

## Proje Görüntüleri
### Kullanıcı Giriş Sayfası
![kullanicigiris](https://github.com/user-attachments/assets/aacbf0b0-e9f8-4414-84d6-7a64159683b1)
- Kullanıcını yapmak istediği işleme göre giriş yapacağı ekran bu şekildedir.
- Rezervasyon yapmak isteyen müşteri, Müşteri Girişini seçerken; rezervasyonları görüntülemek, güncellemek veya iptal etmek isteyen yönetici (Resepsiyon Görevlisi de diyebiliriz) Yönetici Girişini seçecektir.

### Müşteri Giriş Sayfası 
![musterirezervasyon](https://github.com/user-attachments/assets/2e809395-e704-49d7-9756-27de45623e04)
- Müşteri Girişini seçtikten sonra ulaşılan ekrandır.
- Otelle ilgili bilgiler yukarda yazmaktadır.
- Müşteri bu sayfadan gerekli bilgileri doldurduktan sonra odayı seçip rezervasyon yap butonundan rezervasyonunu oluşturabilmektedir.
- Eğer rezervasyonla ilgili birşeyi değiştirmek, güncellemek, rezervasyonunu iptal etmek yada otelle ilgili detaylı bilgi isterse yukarıdaki bilgilerde yazan numarayla iletişime geçip yönetici girişi yapabilme yetkisine sahip görevliyle yani resepsiyon görevlisiyle yada direkt yöneticiyle konuşup yapmak istediği işlemi gerçekleştirmiş olacak. (Yönetici anasayfasının ekran görüntüsünde daha iyi anlaaşılırdır)

### Yönetici Giriş Sayfası  
![yoneticigiris](https://github.com/user-attachments/assets/53f9bbb4-0a69-4b4a-a5e1-754e79b13b8a)
- Yönetici Girişini seçtikten sonra ulaşılan ekrandır.
- Yönetici anasayfasına ulaşması için kullanıcıdan kullanıcı adı ve şifre bilgisi istenir.
  
  ![yoneticihataligiris](https://github.com/user-attachments/assets/09a190fd-d02c-42b0-80b6-f2df665d98f4)
- Doğru girilmediğinde ekrana kullanıcı adı veya şifresinin yanlış olduğuna dair bu şekilde bir uyarı gelecektir.

### Yönetici Anasayfası
![yoneticianasayfa](https://github.com/user-attachments/assets/328cb0e0-c4c3-4183-a278-81ceb31d3165)
- Yönetici kullanıcı adı ve şifresi doğru girildikten sonra ulaşılan sayfadır.
- Yönetici anasayfası bu şekilde ekrana gelmektedir.

 ### Yönetici Anasayfası - Müşteri Bilgileri Görüntüle Butonu
 ![yoneticimsuterigoruntuleme](https://github.com/user-attachments/assets/842a3cde-1a76-484b-a42d-ac55f8f25b1f)
- Butona tıklandığı zaman rezervasyon yapmış olan müşterilerin bilgileri bu şekilde gösterilmektedir.
  
### Yönetici Anasayfası - Müşteri Arama Butonu
 ![yoneticimusteriarama](https://github.com/user-attachments/assets/6cdcbc73-8fc3-4b45-a636-4b8798162733)
 - Arama isme göre gerçekleşir.
   
### Yönetici Anasayfası - Müşteri Bilgilerini Yansıtma ve Güncelleme
![yoneticimusteribilgiyansıtma](https://github.com/user-attachments/assets/04f2c898-8159-45da-a384-4985f3fb92b7)
- Müşterinin Müşteri No'suna çift tıklandığı zaman bu şekilde bilgileri sol taraftaki alana yansıtılacaktır.
  
![yoneticimusteriguncelleme1](https://github.com/user-attachments/assets/3c4d84b2-71a4-4141-8300-21c46b164be2)

![yoneticimusteriguncelleme2](https://github.com/user-attachments/assets/77aff09d-4bff-4114-9808-ac49119fbc32)

- Güncelleme yapılacak işlem bu şekilde gerçekleşir. (Örnekte müşterinin soyadı değiştirilmiştir)

### Yönetici Anasayfası - Temizle Butonu 
  ![yoneticitemzilebutonu1](https://github.com/user-attachments/assets/2d1e8132-8d4e-4b0e-bb47-94c6c117fccd)

  ![yoneticitemizlebutonu2](https://github.com/user-attachments/assets/934ed188-6d49-4948-8f66-5576d20a61bf)
- Müşteri bilgilerinin yansıtmasını silmek için temizle butonu bu şekilde kullanılır.

### Yönetici Anasayfası - Rezervasyon İptal Etme
![yoneticirezervasyoniptal1](https://github.com/user-attachments/assets/8f96fae9-adc9-4d0c-b7d5-6ae7aed870a4)

![yoneticirezervasyoniptal2](https://github.com/user-attachments/assets/09deeed8-0627-4d1d-a99b-712736b029bd)

![yoneticirezervasyoniptal3](https://github.com/user-attachments/assets/ac387a86-9ff2-4d55-8a65-3f0c72eb246d)
- Yönetici rezervasyonu iptal et butonuna bastıktan sonra rezervasyon iptal edilmiş olur ve müşteri bilgilerinin görüntülendiği alandan da silinir.

  
#
#
## Youtube 
- Video anlatımı için;
- https://youtu.be/YE9UPFt-oW4
  



  



  

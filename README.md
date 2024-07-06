# Banka Mini Uygulaması

Bu proje, kullanıcıların banka hesaplarına giriş yapmalarını, hesap bilgilerini görüntülemelerini, para transferi yapmalarını ve yeni hesap oluşturmalarını sağlayan bir Windows Forms uygulamasıdır.

## Özellikler

- **Giriş Yapma:** Kullanıcılar hesap numaraları ve şifreleri ile sisteme giriş yapabilirler.
- **Hesap Bilgilerini Görüntüleme:** Kullanıcılar hesap numaralarını, ad-soyad, TC kimlik numarası, telefon numarası ve hesap bakiyesini görüntüleyebilirler.
- **Para Transferi:** Kullanıcılar başka bir hesaba para transferi yapabilirler.
- **Hesap Oluşturma:** Yeni kullanıcılar sisteme kayıt olarak yeni bir hesap oluşturabilirler.

## Kullanılan Teknolojiler

- **Programlama Dili:** C#
- **Geliştirme Ortamı:** Visual Studio 2022
- **Framework:** .NET Framework
- **Veritabanı:** Microsoft SQL Server
- **Arayüz Bileşenleri:** Windows Forms
- **Veritabanı İşlemleri:** System.Data.SqlClient kütüphanesi

## Kurulum ve Kullanım

1. **Proje Dosyalarını İndirme:**
git clone https://github.com/kullanici-adi/proje-adi.git
cd proje-adi

2. **Visual Studio ile Projeyi Açma:**
- `Dosya` -> `Aç` -> `Proje/Çözüm Aç` menüsünden projenin `.sln` dosyasını seçin.

3. **Veritabanı Ayarları:**
- `DbBankaProjeTest` adlı bir SQL Server veritabanı oluşturun ve tabloları oluşturmak için gerekli SQL komutlarını çalıştırın.

4. **Uygulamayı Çalıştırma:**
- `Ctrl + F5` tuşlarına basarak veya `Başlat` butonuna tıklayarak uygulamayı çalıştırabilirsiniz.

## Kullanım Kılavuzu

### Giriş Yapma

- **Hesap Numarası ve Şifre Girme:**
- Kullanıcı, hesap numarasını ve şifresini ilgili alanlara girer.
- `Giriş Yap` butonuna tıklayarak giriş yapar.
- Eğer bilgiler doğru ise, kullanıcı hesap bilgileri sayfasına yönlendirilir. Aksi takdirde hata mesajı gösterilir.

### Hesap Bilgilerini Görüntüleme

- **Hesap Bilgileri:**
- Giriş yaptıktan sonra kullanıcı, hesap numarası, ad-soyad, TC kimlik numarası, telefon numarası ve bakiye bilgilerini görüntüler.

### Para Transferi

- **Para Gönderme:**
- Kullanıcı, gönderilecek tutarı ve alıcı hesap numarasını girer.
- `Gönder` butonuna tıklayarak para transferini gerçekleştirir.
- İşlem başarılı ise, bakiye güncellenir ve başarı mesajı gösterilir.

### Hesap Oluşturma

- **Yeni Hesap Oluşturma:**
- Kullanıcı, ad, soyad, TC kimlik numarası, telefon numarası, hesap numarası ve şifre bilgilerini girer.
- `Hesap Oluştur` butonuna tıklayarak yeni hesap oluşturur.
- Hesap numarasını otomatik olarak oluşturmak için `Hesap Numarası Oluştur` butonuna tıklanabilir.

## Kod Açıklamaları

### Form1 Sınıfı

`Form1` sınıfı, kullanıcıların sisteme giriş yapmalarını sağlar.

#### lnkKayitOl_LinkClicked Olayı

- Kullanıcıyı kayıt olma formuna yönlendirir.

#### button1_Click Olayı

- **Veritabanı Bağlantısı:**
- Veritabanına bağlanır ve kullanıcı bilgilerini kontrol eder.
- **Giriş Kontrolü:**
- Hesap numarası ve şifre doğruluğunu kontrol eder.
- Doğru ise kullanıcıyı hesap bilgileri sayfasına yönlendirir, yanlış ise hata mesajı gösterir.

### Form2 Sınıfı

`Form2` sınıfı, kullanıcıların hesap bilgilerini görüntülemelerini ve para transferi yapmalarını sağlar.

#### Form2_Load Olayı

- **Hesap Bilgilerini Getirme:**
- Kullanıcının hesap bilgilerini ve bakiyesini veritabanından getirir ve ilgili alanlara yerleştirir.

#### btnGonder_Click Olayı

- **Para Transferi:**
- Gönderilen ve gönderen hesapların bakiyelerini günceller ve veritabanına kaydeder.
- İşlem başarılı ise kullanıcıya mesaj gösterir.

### Form3 Sınıfı

`Form3` sınıfı, kullanıcıların yeni hesap oluşturmalarını sağlar.

#### button1_Click Olayı

- **Hesap Oluşturma:**
- Kullanıcının girdiği bilgileri veritabanına kaydeder ve yeni hesap oluşturur.
- İşlem başarılı ise kullanıcıya mesaj gösterir.

#### button2_Click Olayı

- **Hesap Numarası Oluşturma:**
- Rastgele bir hesap numarası oluşturur ve ilgili alana yerleştirir.

## Ekran Görüntüleri

### *Giriş ekranı*

![banka_form_!](https://github.com/huseynaktas/Banka_Mini_App/assets/114494075/64a41579-9928-40a3-94af-74eb82544ff9)

### *Hesap bilgileri ile havale ekranı*

![banka_form_2](https://github.com/huseynaktas/Banka_Mini_App/assets/114494075/a4a837ed-c21e-464f-be5e-63183ea6436f)

### *Kayıt olma ekranı*

![banka_form_3](https://github.com/huseynaktas/Banka_Mini_App/assets/114494075/4a9e1a2b-f7e8-4afe-97ae-f0b45ea39718)

## Katkıda Bulunanlar

- **Murat Yücedağ** - Proje Sahibi
- **hakts** - Proje Geliştiricisi


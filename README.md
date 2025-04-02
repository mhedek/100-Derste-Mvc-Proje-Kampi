# 🚀 MVC Proje Kampı - Katmanlı Mimari & EF Core 🚀

## 📖 Ders İçeriği

### 📌 MVC'ye Giriş
✅ MVC yapısı nasıl çalışır?  
✅ Controller, Model ve View yapıları  
✅ İlk ASP.NET MVC projesi oluşturma  

### 🛠 Veri Tabanı Yönetimi
✅ **Entity Framework Core** kullanımı  
✅ **Migration işlemleri**  
✅ **CRUD işlemleri (Create, Read, Update, Delete)**  
✅ **Repository Pattern** ile veritabanı yönetimi  

### 🔒 Authentication & Authorization
✅ Kullanıcı kayıt, giriş ve rol yönetimi  
✅ Identity kullanarak güvenlik mekanizmaları  
✅ JWT ile Token bazlı kimlik doğrulama  

### 📡 API Entegrasyonu
✅ **RESTful API kullanımı**  
✅ **Dış servislerden veri çekme** (OpenWeather, Google Maps API vb.)  
✅ **AJAX ile dinamik veri güncelleme**  

### 🎨 Frontend & UI Geliştirme
✅ **Bootstrap & jQuery** kullanımı  
✅ **AJAX ile asenkron işlemler**  
✅ **Datatables, Chart.js gibi kütüphanelerle veri görselleştirme


✅ **Bu projede neler öğreneceksiniz?**  
✔️ Katmanlı Mimari Yapısı (Entity, Data Access, Business, Presentation)  
✔️ Entity Framework Core ile Veritabanı İşlemleri  
✔️ Migration Yönetimi ve Veritabanı Güncellemeleri  
✔️ Tabloların Oluşturulması ve İlişkisel Yapılar  

---

## 📌 **Proje Yapısı ve Katmanlar**

Bu proje, **4 ana katmandan** oluşmaktadır:

📂 **1. Entity Layer (Varlık Katmanı)**  
- Veritabanındaki tabloları temsil eden sınıfları içerir.  
- **Örnek:** `About`, `Category`, `Heading` gibi entity'ler burada yer alır.  

📂 **2. Data Access Layer (Veri Erişim Katmanı - DAL)**  
- Entity Framework Core kullanarak CRUD işlemlerini gerçekleştirir.  
- **Repository Design Pattern** uygulanmıştır.  
- **Örnek:** `GenericRepository`, `IRepository`, `CategoryRepository`  

📂 **3. Business Layer (İş Katmanı - BLL)**  
- Veri erişim işlemleri ile iş kurallarını birbirinden ayırır.  
- İş kurallarını yönetir ve doğrulamalar içerir.  
- **Örnek:** `CategoryManager`  

📂 **4. Presentation Layer (Sunum Katmanı - UI)**  
- Kullanıcıya arayüz sağlar.    

---

## 🔗 **Entity Layer (Varlık Katmanı)**
Entity katmanı, **veritabanı tablolarını temsil eden** sınıflardan oluşur.  
Örnek bir **Category** (Kategori) entity’si:
```csharp
public class Category
{
    [Key]
    public int CategoryID { get; set; }

    [StringLength(50)]
    public string CategoryName { get; set; }

    [StringLength(200)]
    public string CategoryDescription { get; set; }
    public bool CategoryStatus { get; set; }

    public ICollection<Heading> Headings { get; set; }
}
```

---

                                                # PROJE GÖRSELLERİ #

![Mvc Login Paneli](MVCKamp/AdminLTE-3.0.4/web/images/Ekran görüntüsü 2025-03-19 040259.png)                                                

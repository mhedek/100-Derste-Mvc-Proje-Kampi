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

### 🎨 Frontend & UI Geliştirme
✅ **Bootstrap & jQuery** kullanımı    
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

![Admin Giriş Paneli](https://github.com/user-attachments/assets/fc314e52-6bd1-4fac-b9e9-13e07cc87f6b)

---

![Kategori İşlemleri](https://github.com/user-attachments/assets/06aefcf8-11d8-4a32-8133-d408e5861b8b)

---

![Hata Sayfası](https://github.com/user-attachments/assets/1947848a-55ef-44ae-86c9-2f7c25174774)

---

![Mesaj İşlemleri](https://github.com/user-attachments/assets/6fe3d530-70a8-478b-8a5e-f9c6efe5ec39)

---

![Başlıklar](https://github.com/user-attachments/assets/0840fc03-6c8f-4afd-96aa-bc177723e86c)

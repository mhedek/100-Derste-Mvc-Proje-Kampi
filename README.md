# 🚀 MVC Proje Kampı - Katmanlı Mimari & EF Core 🚀


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
Örnek bir **Category** (Ürün) entity’si:

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

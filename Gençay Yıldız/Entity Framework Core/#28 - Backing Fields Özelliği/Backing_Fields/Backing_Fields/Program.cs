using Microsoft.EntityFrameworkCore;

BackingFieldDbContext context = new();

var person = await context.Persons.FindAsync(1);
//Person person2 = new()
//{
//    Name = "Person 101",
//    Department = "Departman 101"
//};



Console.Read();

#region Backing Fields
//EF Core'da veritabanındaki tablolara karşılık gelen entity class'ları içerisindeki property'lerin (veritabanında modelleme yapılan tablonun içerisindeki kolonlara karşılık gelen) yerine fieldları kullanmamızı sağlayan özelliktir. Bir başka deyişle EF Core'da entity sınıfları içerisinde kolonlara karşılık gelen property'lerin yerine fieldları kullanmamızı sağlayan bir özelliktir.
//Tablo içerisindeki kolonları entity class'ları içerisinde property'ler ile değil field'larla temsil etmemizi sağlayan bir özelliktir.
//Veritabanından sorgulama yaparken property'ini get set bloklarına field'ın değerini atayarak field'ı devreye alabiliriz.
//Eğer ki sen backing field kullanıyorsan veritabanıyla olan iletişim etkileşim sürecinde bir encapsulation gerçekleştirebilirsin
//Eğer ki veritabanından gelecek olan verileri Property'lerde değilde fieldlarda karşılamak istersen backing field özelliğini kullanabilirsin
//class Person
//{
//    public int Id { get; set; }
//    public string name;
//    public string Name { get => name.Substring(0, 3); set => name = value.Substring(0, 3); }
//    public string Department { get; set; }
//}
#endregion

#region BackingField Attributes

//class Person
//{
//    public int Id { get; set; }
//    public string name;
//    [BackingField(nameof(name))]
//    public string Name { get; set; }
//    public string Department { get; set; }
//}
#endregion

#region HasField Fluent API
//Fluent API'da HasField metodu BackingField özelliğine karşılık gelmektedir.
//class Person
//{
//    public int Id { get; set; }
//    public string name;
//    public string Name { get; set; }
//    public string Department { get; set; }
//}
#endregion

#region Field And Property Access
//EF Core sorgulama sürecinde entity içerisindeki propertyleri ya da field'ları kullanıp kullanmayacağının davranışını bizlere belirtmektedir.

//EF Core hiçbir ayarlama yoksa varsayılan olarak propertyler üzerinden verileri işler, eğerki backing field bildiriliyorsa field üzerinden işler yok eğer backin field bildirildiği halde davranış belirtiliyorsa ne belirtilmişse ona göre işlemeyi devam ettirir.

//UsePropertyAccessMode => Bu metot üzerinden davranış modellemesi gerçekleştirilebilir.
#endregion

#region Field-Only Properties
//Entity'lerde bazı değerleri alabilmek için propertyler yerine metotların kullanıldığı durumda yahut ilgili entity içerisinde belirli alanların hiç gösterilmek istenmediği durumlarda biz Field-Only Properties özelliğini kullanmayı tercih ederiz.
//Entity'lerde değerleri almak için property'ler yerine metotların kullanıldığı veya belirli alanların hiç gösterilememesi gerektiği durumlarda(primary key kolonu) kullanılabilir.


class Person
{
    public int Id { get; set; }
    public string name;
    public string Department { get; set; }

    public string GetName()
        => name;
    public string SetName(string value)
        => this.name = value;
}
#endregion

class BackingFieldDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=BackingFieldDb;User ID=SA;Password=1q2w3e4r!.;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Person>()
        //    .Property(p => p.Name)
        //    .HasField(nameof(Person.name))
        //    .UsePropertyAccessMode(PropertyAccessMode.PreferProperty);

        //Field : Veri erişim süreçlerinde sadece fieldların kullanılmasını söyler Eğer field'ın kullanılamayacağı durum söz konusu olursa bir exception fırlatır.
        //FieldDuringConstruction : Veri erişim süreçlerinde ilgili entity'den bir nesne oluşturulma sürecinde field'ların kullanılmasını söyler.
        //Property :Veri erişim süreçlerinde sadece Property'nin kullanılmasını söyler Eğer property'nin durum söz konusuysa(read-only,write-only) bir exception fırlatır.
        //PreferField : Field'ı kullan
        //PreferFieldDuringConstruction : Nesne üretim sürecinde field'ı kullan 
        //PreferProperty : Proeperty'leri kullan

        modelBuilder.Entity<Person>()
            .Property(nameof(Person.name));//Burada name field'ına Person'daki bir property muamelesi yapması gerektiğini söylüyorum
    }
}


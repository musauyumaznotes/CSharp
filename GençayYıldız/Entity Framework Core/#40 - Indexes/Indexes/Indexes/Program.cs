using Microsoft.EntityFrameworkCore;

ApplicationDbContext context = new();

#region Index Nedir?
//Bir sütuna dayalı sorgulama süreçlerini daha verimli ve performanslı hale getirmek için kullanılan bir yapıdır/veritabanı nesnesidir.
//Bir kolona index atanırsa sorguların daha az maliyetli, yüksek performanslı ve verimli gerçekleştirilecektir. çalışacaktır.
#endregion
#region Indexleme Nasıl Yapılır?
//Gelenkesel davranışa göre bir tabloda primary key,froeign key ve alternate key söz konusuysa bunların hepsine karşılık otomatik olarak bir indexleme durumu söz konusu olacaktır.
//PK, FK ve AK olan kolonlar otomatik olarak indexlenir.
//Default indexler dışında ekstradan irademizle farklı kolonlara indexler atamak istiyorsak bunu yapabilmek için data annotation yada fluent API olmak üzere iki farklı özellikten istifade edebiliriz.

#region Index Attribute'u
//[Index(nameof(Name))] => Employee entity'sine karşılık gelecek/generate edilecek tabloda Name property'sine karşılık gelecek kolona bir tane index ata.
//class Employee
//{
//    public int Id { get; set; }
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public int Salary { get; set; }
//}
#endregion
#region HasIndexMetodu
//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//    modelBuilder.Entity<Employee>()
//        .HasIndex(e => e.Name);
//}
#endregion
#endregion
#region Composite Index
//Composite olan sorgulama süreçlerinde bir anlam ifade edecektir ama sadece tek bir kolon üstünde bir ifade etmeyecektir. Yani composite yapılanma bütünleşik olarak bir anlam ifade eder. Yani kolonları atomik olarak sorgularsan orada composite index bir anlam ifade etmeyecektir.
//context.Employees.Where(e => e.Name == "" || e.Surname == "");

//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//    //modelBuilder.Entity<Employee>()
//    //    .HasIndex(e => e.Name);
//    modelBuilder.Entity<Employee>()
//        .HasIndex(e => new { e.Surname, e.Name });
//}
//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//    //modelBuilder.Entity<Employee>()
//    //    .HasIndex(e => e.Name);
//    //modelBuilder.Entity<Employee>()
//    //    .HasIndex(e => new { e.Surname, e.Name });
//    modelBuilder.Entity<Employee>()
//       .HasIndex(nameof(Employee.Name), nameof(Employee.Surname));
//}


//[Index(nameof(Name), nameof(Surname))]
//class Employee
//{
//    public int Id { get; set; }
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public int Salary { get; set; }
//}


#endregion
#region Birden Fazla Index Tanımlama
//[Index(nameof(Name))]
//[Index(nameof(Surname))]
//[Index(nameof(Name), nameof(Surname))]
//class Employee
//{
//    public int Id { get; set; }
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public int Salary { get; set; }
//}
#endregion
#region Index Uniqueness
//Indexler default halleriyle unique değillerdir. Yani bir kolonu indexlediyseniz eğer default hali mükerrer/tekrar edebilir.
//[Index(nameof(Name), IsUnique = true)]
//class Employee
//{
//    public int Id { get; set; }
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public int Salary { get; set; }
//}
//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//    modelBuilder.Entity<Employee>()
//      .HasIndex(e => e.Name)
//      .IsUnique();
//}

#endregion
#region Index Sort Order - Sıralama Düzeni (EF Core 7.0)
//Index durumlarında indexlerin kullanıldığı noktalarda sıralama operasyonu iyi bir performans için önem arz etmektedir. Özellikle bu index Composite Index ise bu önem daha da artmaktadır.
//Index oluşturduğumuzda default olarak sıralama davranışı ascending'tir. Yani küçükten büyüğe doğru alfanumerik olarak bir artış gösterir.

#region AllDescending - Attribute
//Tüm indexlemelerde decending davranışının bütünsel olarak konfigürasyonunu sağlar.

//[Index(nameof(Name),AllDescending = true)]
//class Employee
//{
//    public int Id { get; set; }
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public int Salary { get; set; }
//}
#endregion
#region IsDescending - Attribute
//Indexleme sürecindeki her bir kolona göre sıralama davranışını hususi ayarlamak istiyorsak kullanılır.

//[Index(nameof(Name), nameof(Surname), IsDescending = new[] { true, false })]
//class Employee
//{
//    public int Id { get; set; }
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public int Salary { get; set; }
//}
#endregion
#region IsDescending Metodu
//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//    modelBuilder.Entity<Employee>()
//        .HasIndex(e => new { e.Name, e.Surname })
//        .IsDescending(true, false);
//}
#endregion
#endregion
#region Index Name
//[Index(nameof(Name), Name = "Index")]
//class Employee
//{
//public int Id { get; set; }
//public string? Name { get; set; }
//public string? Surname { get; set; }
//public int Salary { get; set; }
//}

//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//modelBuilder.Entity<Employee>()
//.HasIndex(e => new { e.Name, e.Surname })
//.HasDatabaseName("name_index");
//}
#endregion
#region Index Filter
//Index yapılanması arkada bir index tablosu oluşturacaktır ve bu index tablosuna indexlenen verileri taşıyacaktır. Haliyle buradaki verilerin yoğunluğunu düşürebilmek ve index tablosundaki maliyeti azaltabilmek için filterlar uygulayabiliyoruz.

//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//    modelBuilder.Entity<Employee>()
//        .HasIndex(e => new { e.Name, e.Surname })
//        .HasFilter("[NAME] IS NOT NULL");
//}
#endregion
#region Included Columns
//Index dışında kalan bir property'i/kolonu sorguya ekleyip sonuç olarak elde etmek istediğimiz durumlar söz konusuysa işte bu tarz durumlarda eklenecek olan ekstradan kolonları bildirebilir ve bunlarıda index tablosuna dahil edebilirsin.
#region IncludeProperties Metodu
//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//    modelBuilder.Entity<Employee>()
//        .HasIndex(e => new { e.Name, e.Surname })
//        .IncludeProperties(e => e.Salary);
//}
#endregion
#endregion

//[Index(nameof(Name))]
//[Index(nameof(Surname))]
//[Index(nameof(Name),nameof(Surname))]
//[Index(nameof(Name), IsUnique = true)]
//[Index(nameof(Name),AllDescending = true)]
//[Index(nameof(Name),nameof(Surname),IsDescending = new[] {true,false})]
//[Index(nameof(Name), Name ="Index")]
class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public int Salary { get; set; }
}

class ApplicationDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Employee>()
        //    .HasIndex(e => e.Name);
        //modelBuilder.Entity<Employee>()
        //    .HasIndex(e => new { e.Surname, e.Name });
        //modelBuilder.Entity<Employee>()
        //   .HasIndex(nameof(Employee.Name), nameof(Employee.Surname));
        //modelBuilder.Entity<Employee>()
        //  .HasIndex(e=>e.Name)
        //  .IsUnique();
        //modelBuilder.Entity<Employee>()
        //    .HasIndex(e => new { e.Name, e.Surname })
        //    .IsDescending(true,false);
        //modelBuilder.Entity<Employee>()
        //    .HasIndex(e => new { e.Name, e.Surname })
        //    .HasDatabaseName("name_index");
        //modelBuilder.Entity<Employee>()
        //    .HasIndex(e => new { e.Name, e.Surname })
        //    .HasFilter("[NAME] IS NOT NULL");
        modelBuilder.Entity<Employee>()
            .HasIndex(e => new { e.Name, e.Surname })
            .IncludeProperties(e =>  e.Salary );   
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433; Database=ApplicationDb;User ID=SA;Password=1q2w3e4r!.;");
    }
}
using Microsoft.EntityFrameworkCore;


#region Configurations | Fluent API

#region Composite Key
//Bir tabloda birden fazla kolonun kümülatif olarak Primary(kimlik) davranışı sergilediği yapıdır. Yani biz tek bir kolonu değilde aynı anda birden fazla kolonu Primary key yapmak istiyorsak buna Composite Key denir.
//Tablolarda birden fazla kolonu kümülatif olarak Primary key yapmak istiyorsak buna Composite Key denir.
#endregion

#region HasDefaultSchema
//Bir veritabanı oluşturduğumuzda içindeki tabloların,view'ların,store procedure'lerin herkesin bir şeması vardır.
//EF Core üzerinden inşa edilen herhangi bir veritabanı nesnesi default olarak dbo şemasına sahiptir. Bunu özelleştirebilmek için kullanılan bir yapılandırmadır.
#endregion

#region Property
//Tabloların kolonlarını/sütunlarını belirlememizi sağlayan özelliktir.
#region HasDefaultValue
//İlgili property'e karşılık oluşturulacak kolona bir default değer atamamızı sağlayan bir yapılandırma.
//Tablodaki herhangi bir kolonun değer gönderilmediği durumlarda default olarak hangi değeri alacağını belirler.
#endregion

#region HasDefaultValueSql
//Sonucu default olarak bir SQL'in çalışması neticesinde vereceksek eğer bu özelliği kullanırız.
//Tablodaki herhangi bir kolonun değer gönderilmediği durumlarda default olarak hangi sql cümleciğinden değeri alacağını belirler.
#endregion
#endregion

#region HasComputedColumnSql
//Birden fazla kolonda veriler toplayıp hesaplama yapılan kolonlar oluşturulabilir.
//Bir entity tasarlarken birden fazla kolonu bir property'e bir kolona işlevsel olarak bağlayabilirim ve bu kolon diğer kolonlardaki verileri kullanarak bir sonuç üretebilir. İşte biz bunlara Computed Column(Hesaplanmış Kolonlar) diyoruz.
//Tablolarda birden fazla kolonlardaki verileri işleyerek değerini oluşturan kolonlara Computed Column denmektedir. EF Core üzerinden bu tarz Computed Column oluşturabilmek için kullanılan yapılandırmadır.
#endregion

#region HasConstraintName
//EF Core üzerinde oluşturduğumuz Constraint yapılandırmalarına default ismi yerine özelleştirilmiş bir isim verebiliriz.
//EF Core üzerinden oluşturulam constraint'lere default isim yerine özelleştirilmiş bir isim verebilmek için kullanılan yapılandırmadır.
#endregion

#region HasData
//SeedData => Çalışma verileri oluşturma yöntemimiz olacak EF Core ile migration yaparken veritabanını modellerken içerisinde hazı verilerimiz olsun işte bu verileri yazılım kısmından hızlıca Migration kısmında göndermek istiyorsak Bunlara SeedData diyeceğiz. İşte bu SeedData'ları oluşturmamızı sağlayan bir konfigürasyonel bir değerdir. Seed data oluşturulurken manuel olarak primary key değerleri verilir.
//Sonraki derslerimizde Seed Data isimli bir konuyu inceleyeceğiz. Bu konuda migrate sürecinde veritabanını inşa ederken bir yandan da yazılım üzerinden hazır veriler oluşturmak istiyorsak eğer bunun yöntemini usülünü inceliyor olacağız.
//İşte HasData konfigürasyonu bu operasyonun yapılandırma ayağıdır.
//HasData ile migrate sürecinde oluşturulacak olan verilerin Primary Key olan id kolonlarına iradeli bir şekilde değerlerin girilmesi zorunludur!
#endregion

#region HasDiscriminator
//İleride entityler arasıdna kalıtımsal ilişkiler olduğu TPT ve TPH isminde konuları inceliyor olacağız. İşte bu konularla ilgili yapılandırmalarımız HasDiscriminator ve HasValue fonksiyonlarıdır. 
#region HasValue

#endregion

#endregion

#region HasField
//Backing Field özelliğini kullanmamızı sağlayan yapılandırmadır.
#endregion

#region HasNoKey
//Normal şartlarda EF Core'da tüm entity'lerin bir Primary Key kolonu olmak zorundadır. Eğer ki entity'de Primary Key kolonu olmayacaksa bunun bildirilmesi gerekmektedir! İşte bunun için kullanlan fonksiyondur.
#endregion

#region HasIndex
//Sonraki derslerimizde EF Core üzerinden index yapılanmasını detaylıca inceliyor olacağız.
//Bu yapılanmaya dair konfigürasyonlarımız HasIndex ve Index attribute'dur.
#endregion

#region HasQueryFilter
//İleride göreceğimiz Global Query Filter başlıklı dersimizin yapılandırmasıdır.
//Temeldeki görevi bir entity'e karşılık uygulama bazında global bir filtre koymaktır.
#endregion

#region DatabaseGenerated - ValueGeneratedOnAddOrUpdate, ValueGeneratedOnAdd, ValueGeneratedNever

#endregion
#endregion



class Person
{
    public int Id { get; set; }
    public int Id2 { get; set; }
    public int DepartmentId { get; set; }
    public string _name;
    public string Name { get => _name; set => _name = value; }
    public string Surname { get; set; }
    public decimal Salary { get; set; }
    public DateTime CreatedDate { get; set; }

    public Department Department { get; set; }

}
class Department
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Person> Persons { get; set; }
}
class Example
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Computed { get; set; }
}
class Entity
{
    public int Id { get; set; }
    public string X { get; set; }
}
class A : Entity
{
    public int Y { get; set; }
}
class B : Entity
{
    public int Z { get; set; }
}
class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDb;User ID=SA;Password=1q2w3e4r!.;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region CompositeKey
        modelBuilder.Entity<Person>()
            //.HasKey(p=> new { p.Id,p.Id2});
            .HasKey("Id", "Id2");
        #endregion
        #region HasDefaultSchema
        modelBuilder.HasDefaultSchema("ahmet");
        #endregion
        #region Property
        modelBuilder.Entity<Person>()
            .Property(p => p.Salary);
        #region HasDefaultValue
        modelBuilder.Entity<Person>()
            .Property(p => p.Salary).HasDefaultValue(100);
        #endregion
        #region HasDefaultValueSql
        modelBuilder.Entity<Person>()
            .Property(p => p.CreatedDate)
            .HasDefaultValueSql("GETDATE()");
        #endregion
        #endregion
        #region HasComputedColumnSql
        modelBuilder.Entity<Example>()
            .Property(e => e.Computed)
            .HasComputedColumnSql("[X] + [Y]");
        #endregion
        #region HasConstraintName
        modelBuilder.Entity<Person>()
            .HasOne(p => p.Department)
            .WithMany(d => d.Persons)
            .HasForeignKey(p => p.DepartmentId)
            .HasConstraintName("ahmet");
        #endregion
        #region HasData
        modelBuilder.Entity<Department>()
            .HasData(
            new()
            {
                Name = "asd",
                Id = 1
            },
            new()
            {
                Name = "dsa",
                Id = 2
            });
        modelBuilder.Entity<Person>()
            .HasData(
            new Person
            {
                Id = 1,
                DepartmentId = 1,
                Name = "Ahmet",
                Surname = "Filanca",
                Salary = 100,
                CreatedDate = DateTime.Now
            },
            new Person
            {
                Id = 2,
                DepartmentId = 2,
                Name = "Mehmet",
                Surname = "Filanca",
                Salary = 200,
                CreatedDate = DateTime.Now
            });
        #endregion
        #region HasDiscriminator
        //modelBuilder.Entity<Entity>()
        //    .HasDiscriminator<int>("Ayirici")
        //    .HasValue<A>(1)
        //    .HasValue<B>(2)
        //    .HasValue<Entity>(3);
        #endregion
        #region HasField
        modelBuilder.Entity<Person>()
            .Property(p => p.Name)
            .HasField(nameof(Person._name));
        #endregion
        #region HasNoKey
        modelBuilder.Entity<Example>()
            .HasNoKey();
        #endregion
        #region HasIndex
        modelBuilder.Entity<Person>()
            .HasIndex(p => p.Name);
        #endregion
        #region HasQueryFilter
        modelBuilder.Entity<Person>()
            .HasQueryFilter(p=>p.CreatedDate.Year == DateTime.Now.Year);
        #endregion
    }
}
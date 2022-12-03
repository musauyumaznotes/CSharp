# Configurations | Fluent API
# Composite Key
- Bir tabloda birden fazla kolonun kümülatif olarak Primary(kimlik) davranışı sergilediği yapıdır. Yani biz tek bir kolonu değilde aynı anda birden fazla kolonu Primary key yapmak istiyorsak buna Composite Key denir.

- Tablolarda birden fazla kolonu kümülatif olarak Primary key yapmak istiyorsak buna Composite Key denir.

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            //.HasKey(p=> new { p.Id,p.Id2});
            .HasKey("Id", "Id2");
    }
```
# HasDefaultSchema
- Bir veritabanı oluşturduğumuzda içindeki tabloların,view'ların,store procedure'lerin herkesin bir şeması vardır.

- EF Core üzerinden inşa edilen herhangi bir veritabanı nesnesi default olarak dbo şemasına sahiptir. Bunu özelleştirebilmek için kullanılan bir yapılandırmadır.


```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("ahmet");
    }
```
# Property
- Tabloların kolonlarını/sütunlarını belirlememizi sağlayan özelliktir.
# HasDefaultValue
- İlgili property'e karşılık oluşturulacak kolona bir default değer atamamızı sağlayan bir yapılandırma.

- Tablodaki herhangi bir kolonun değer gönderilmediği durumlarda default olarak hangi değeri alacağını belirler.


# HasDefaultValueSql
- Sonucu default olarak bir SQL'in çalışması neticesinde vereceksek eğer bu özelliği kullanırız.

- Tablodaki herhangi bir kolonun değer gönderilmediği durumlarda default olarak hangi sql cümleciğinden değeri alacağını belirler.

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Property
        modelBuilder.Entity<Person>()
            .Property(p => p.Salary);
        #region HasDefaultValue
        modelBuilder.Entity<Person>()
            .Property(p => p.Salary).HasDefaultValue(100);
        #region HasDefaultValueSql
        modelBuilder.Entity<Person>()
            .Property(p => p.CreatedDate)
            .HasDefaultValueSql("GETDATE()");
    }
```

# HasComputedColumnSql
- Birden fazla kolonda veriler toplayıp hesaplama yapılan kolonlar oluşturulabilir.

- Bir entity tasarlarken birden fazla kolonu bir property'e bir kolona işlevsel olarak bağlayabilirim ve bu kolon diğer kolonlardaki verileri kullanarak bir sonuç üretebilir. İşte biz bunlara Computed Column(Hesaplanmış Kolonlar) diyoruz.

- Tablolarda birden fazla kolonlardaki verileri işleyerek değerini oluşturan kolonlara Computed Column denmektedir. EF Core üzerinden bu tarz Computed Column oluşturabilmek için kullanılan yapılandırmadır.

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Example>()
            .Property(e => e.Computed)
            .HasComputedColumnSql("[X] + [Y]");
    }
```

# HasConstraintName
- EF Core üzerinde oluşturduğumuz Constraint yapılandırmalarına default ismi yerine özelleştirilmiş bir isim verebiliriz.

- EF Core üzerinden oluşturulam constraint'lere default isim yerine özelleştirilmiş bir isim verebilmek için kullanılan yapılandırmadır.

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasOne(p => p.Department)
            .WithMany(d => d.Persons)
            .HasForeignKey(p => p.DepartmentId)
            .HasConstraintName("ahmet");
    }
```

# HasData
- SeedData => Çalışma verileri oluşturma yöntemimiz olacak EF Core ile migration yaparken veritabanını modellerken içerisinde hazı verilerimiz olsun işte bu verileri yazılım kısmından hızlıca Migration kısmında göndermek istiyorsak Bunlara SeedData diyeceğiz. İşte bu SeedData'ları oluşturmamızı sağlayan bir konfigürasyonel bir değerdir. Seed data oluşturulurken manuel olarak primary key değerleri verilir.

- Sonraki derslerimizde Seed Data isimli bir konuyu inceleyeceğiz. Bu konuda migrate sürecinde veritabanını inşa ederken bir yandan da yazılım üzerinden hazır veriler oluşturmak istiyorsak eğer bunun yöntemini usülünü inceliyor olacağız.

- İşte HasData konfigürasyonu bu operasyonun yapılandırma ayağıdır.

- HasData ile migrate sürecinde oluşturulacak olan verilerin Primary Key olan id kolonlarına iradeli bir şekilde değerlerin girilmesi zorunludur!

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
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
    }
```

# HasDiscriminator
- İleride entityler arasıdna kalıtımsal ilişkiler olduğu TPT ve TPH isminde konuları inceliyor olacağız. İşte bu konularla ilgili yapılandırmalarımız HasDiscriminator ve HasValue fonksiyonlarıdır. 
# HasValue

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
    { 
        modelBuilder.Entity<Entity>()
           .HasDiscriminator<int>("Ayirici")
           .HasValue<A>(1)
           .HasValue<B>(2)
           .HasValue<Entity>(3);
    }
```

# HasField
- Backing Field özelliğini kullanmamızı sağlayan yapılandırmadır.

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .Property(p => p.Name)
            .HasField(nameof(Person._name));
    }
```

# HasNoKey
- Normal şartlarda EF Core'da tüm entity'lerin bir Primary Key kolonu olmak zorundadır. Eğer ki entity'de Primary Key kolonu olmayacaksa bunun bildirilmesi gerekmektedir! İşte bunun için kullanlan fonksiyondur.

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Example>()
            .HasNoKey();
    }
```

# HasIndex
- Sonraki derslerimizde EF Core üzerinden index yapılanmasını detaylıca inceliyor olacağız.

- Bu yapılanmaya dair konfigürasyonlarımız HasIndex ve Index attribute'dur.

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasIndex(p => p.Name);
    }
```
# HasQueryFilter
- İleride göreceğimiz Global Query Filter başlıklı dersimizin yapılandırmasıdır.

- Temeldeki görevi bir entity'e karşılık uygulama bazında global bir filtre koymaktır.

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasQueryFilter(p=>p.CreatedDate.Year == DateTime.Now.Year);
    }
```
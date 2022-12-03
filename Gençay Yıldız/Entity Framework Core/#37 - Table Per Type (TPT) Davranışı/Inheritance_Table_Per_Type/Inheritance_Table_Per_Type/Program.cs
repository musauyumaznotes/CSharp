using Microsoft.EntityFrameworkCore;


ApplicationDbContext context = new();

#region Table Per Type (TPT) Nedir?
//Hiyerarşik kalıtımsal ilişkiye sahip entity'lerde her bir entity'e/türe/type'a karşılık bir tablo oluşturmamızı sağlayan modellemedir.
//TPT ilişkisel olan entity sınıfları üzerinde her bir entity'e karşılık tablo oluşturmakta ama oluşturduğu bu tabloları hiyerarşik düzleme uygun bir şekilde kendi aralarında birebir ilişkilendirmektedir.
//Entity'lerin aralarında kalıtımsal ilişkiye sahip olduğu durumlarda her bir türe/entity'e/tipe/referansa karşılık bir tablo generate eden davranıştır.
//Her generate edilen bu tablolar hiyerarşik düzlemde kendi aralarında birebir ilişkiye sahiptir.
#endregion
#region TPT Nasıl Uygulanır?
//TPT'yi uygulaaybilmek için öncelikle entity'lerin kendi aralarında olması gereken mantıkta inşa edilemesi gerekmektedir.
//Entity'ler DbSet olarak bildirilmelidir.
//Hiyerarşik olarak aralarında kalıtımsal ilişki olan tüm entity'ler OnModelCreating fonksiyonunda ToTable metodu ile konfigüre edilmelidir. Böylece EF Core kalıtımsal ilişki olan bu tablolar arasında TPT davranışının olduğunu anlayacaktır.
#endregion
#region TPT'de Veri Ekleme
//Technician technician = new() { Name = "Şuayip", Surname = "Yıldız", Department = "Yazılım", Branch = "Kodlama" };
//await context.Technicians.AddAsync(technician);

//Customer customer = new() {Name="Hilmi",Surname="Celayir",CompanyName="Çaykur" };
//await context.Customers.AddAsync(customer);
//await context.SaveChangesAsync();
#endregion
#region TPT'de Veri Silme
//TPT'de Herhangi bir veriyi siliyorsanız onunla ilişkili tüm veriler gidecektir.Cascade yapılanması/davranışı devreye girecektir.

//Employee? silinecek = await context.Employees.FindAsync(3);
//context.Employees.Remove(silinecek);
//await context.SaveChangesAsync();

//Person? silinecekPerson = await context.Persons.FindAsync(1);
//context.Persons.Remove(silinecekPerson);
//await context.SaveChangesAsync();
#endregion
#region TPT'de Veri Güncelleme
//Technician? technician = await context.Technicians.FindAsync(2);
//technician.Name = "Veli";
//await context.SaveChangesAsync();
#endregion
#region TPT'de Veri Sorgulama

//Employee employee = new() {Name ="Fatih",Surname ="Yavuz",Department ="ABC" };
//await context.Employees.AddAsync(employee);
//await context.SaveChangesAsync();

//var technicians = await context.Technicians.ToListAsync();
//var employees = await context.Employees.ToListAsync();
#endregion

//TPT'de her bir entity'e karşılık kalıtımsal düzlemde bir tablo oluşturulacağından ve birebir ilişki ile bu tablolar birbirine bağlanacağından dolayı tabiki de TPH'a göre ekstradan bir maliyet söz konusu olacaktır.

abstract class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
}
class Employee : Person
{
    public string? Department { get; set; }
}
class Customer : Person
{
    public string? CompanyName { get; set; }
}
class Technician : Employee
{
    public string? Branch { get; set; }
}
class ApplicationDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Technician> Technicians { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>().ToTable("Persons");
        modelBuilder.Entity<Employee>().ToTable("Employees");
        modelBuilder.Entity<Customer>().ToTable("Customers");
        modelBuilder.Entity<Technician>().ToTable("Technicians");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ApplicationDb;User ID=SA;Password=1q2w3e4r!.;");
    }
}
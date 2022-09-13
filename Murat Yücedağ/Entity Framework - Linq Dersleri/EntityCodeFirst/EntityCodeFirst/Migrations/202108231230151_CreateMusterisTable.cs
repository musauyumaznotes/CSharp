namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMusterisTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MusteriAd = c.String(),
                        MusteriSoyad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Musteris");
        }
    }
}

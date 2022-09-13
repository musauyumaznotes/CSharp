namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameMusteriUnvanToMusteriSoyadInMusterisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "MusteriSoyad", c => c.String());
            DropColumn("dbo.Musteris", "MusteriUnvan");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musteris", "MusteriUnvan", c => c.String());
            DropColumn("dbo.Musteris", "MusteriSoyad");
        }
    }
}

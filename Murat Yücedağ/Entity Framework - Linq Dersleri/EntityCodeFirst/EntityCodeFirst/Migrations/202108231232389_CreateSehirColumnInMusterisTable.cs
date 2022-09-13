namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSehirColumnInMusterisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "Sehir", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musteris", "Sehir");
        }
    }
}

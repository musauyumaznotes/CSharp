namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KategoriAdiToKategoriAdInKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriAd", c => c.String());
            Sql("update Kategoris set KategoriAd=KategoriAdi");
            DropColumn("dbo.Kategoris", "KategoriAdi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "KategoriAdi", c => c.String());
            Sql("update Kategoris set KategoriAdi=KategoriAd");
            DropColumn("dbo.Kategoris", "KategoriAd");
        }
    }
}

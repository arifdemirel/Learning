namespace Entity_CodeFirst_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategori",
                c => new
                    {
                        KategoriID = c.Int(nullable: false, identity: true),
                        KategoriAD = c.String(),
                    })
                .PrimaryKey(t => t.KategoriID);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        UrunID = c.Int(nullable: false, identity: true),
                        UrunAd = c.String(maxLength: 50),
                        UrunMarka = c.String(maxLength: 50),
                        UrunKategori = c.String(maxLength: 50),
                        UrunStok = c.Int(nullable: false),
                        Aciklama = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.UrunID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategori");
        }
    }
}

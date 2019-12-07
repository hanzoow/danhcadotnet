namespace Contact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyFirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietDanhBas",
                c => new
                    {
                        tenGoi = c.String(nullable: false, maxLength: 128),
                        diaChi = c.String(),
                        email = c.String(),
                        sdt = c.String(),
                        tenNhom = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.tenGoi)
                .ForeignKey("dbo.NhomDanhBas", t => t.tenNhom)
                .Index(t => t.tenNhom);
            
            CreateTable(
                "dbo.NhomDanhBas",
                c => new
                    {
                        TenNhom = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.TenNhom);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietDanhBas", "TenNhom", "dbo.NhomDanhBas");
            DropIndex("dbo.ChiTietDanhBas", new[] { "TenNhom" });
            DropTable("dbo.NhomDanhBas");
            DropTable("dbo.ChiTietDanhBas");
        }
    }
}

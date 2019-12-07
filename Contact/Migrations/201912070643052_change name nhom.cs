namespace Contact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changenamenhom : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ChiTietDanhBas", new[] { "TenNhom" });
            CreateIndex("dbo.ChiTietDanhBas", "tenNhom");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ChiTietDanhBas", new[] { "tenNhom" });
            CreateIndex("dbo.ChiTietDanhBas", "TenNhom");
        }
    }
}

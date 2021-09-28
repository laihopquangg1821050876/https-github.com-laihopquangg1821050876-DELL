namespace QLSV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDBversion10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SinhVien",
                c => new
                    {
                        Masv = c.Int(nullable: false, identity: true),
                        Tensv = c.String(),
                        Namsinhsv = c.DateTime(nullable: false),
                        Lopsv = c.String(),
                        SDTsv = c.String(),
                    })
                .PrimaryKey(t => t.Masv);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SinhVien");
        }
    }
}

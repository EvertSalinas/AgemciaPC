namespace Agemcia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addValeModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vales",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        numero = c.Int(nullable: false),
                        Reporte_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Reportes", t => t.Reporte_id)
                .Index(t => t.Reporte_id);
            
            AddColumn("dbo.Productoes", "Vale_id", c => c.Int());
            CreateIndex("dbo.Productoes", "Vale_id");
            AddForeignKey("dbo.Productoes", "Vale_id", "dbo.Vales", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vales", "Reporte_id", "dbo.Reportes");
            DropForeignKey("dbo.Productoes", "Vale_id", "dbo.Vales");
            DropIndex("dbo.Vales", new[] { "Reporte_id" });
            DropIndex("dbo.Productoes", new[] { "Vale_id" });
            DropColumn("dbo.Productoes", "Vale_id");
            DropTable("dbo.Vales");
        }
    }
}

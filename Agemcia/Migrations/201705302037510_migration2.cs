namespace Agemcia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Productoes", "nombre", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Productoes", "nombre", c => c.String());
        }
    }
}

namespace EmpleadosMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        antiguedad = c.Int(nullable: false),
                        edad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empleadoes");
        }
    }
}

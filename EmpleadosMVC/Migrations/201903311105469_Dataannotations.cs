namespace EmpleadosMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dataannotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empleadoes", "nombre", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Empleadoes", "categoria", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empleadoes", "categoria", c => c.String());
            AlterColumn("dbo.Empleadoes", "nombre", c => c.String());
        }
    }
}

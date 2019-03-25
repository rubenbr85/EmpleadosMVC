namespace EmpleadosMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Categoria : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleadoes", "categoria", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empleadoes", "categoria");
        }
    }
}

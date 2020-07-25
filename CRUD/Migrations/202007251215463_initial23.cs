namespace CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial23 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ActivoFijoes", "Descripción", c => c.String(nullable: false));
            AlterColumn("dbo.Departamentoes", "Descripcion", c => c.String(nullable: false));
            AlterColumn("dbo.TipoActivoes", "Descripcion", c => c.String(nullable: false));
            AlterColumn("dbo.Empleadoes", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Empleadoes", "Cedula", c => c.String(nullable: false));
            AlterColumn("dbo.Empleadoes", "TipoPersona", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empleadoes", "TipoPersona", c => c.String());
            AlterColumn("dbo.Empleadoes", "Cedula", c => c.String());
            AlterColumn("dbo.Empleadoes", "Nombre", c => c.String());
            AlterColumn("dbo.TipoActivoes", "Descripcion", c => c.String());
            AlterColumn("dbo.Departamentoes", "Descripcion", c => c.String());
            AlterColumn("dbo.ActivoFijoes", "Descripción", c => c.String());
        }
    }
}

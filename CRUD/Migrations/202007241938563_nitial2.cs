namespace CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nitial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleadoes", "DepartamentoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Empleadoes", "DepartamentoId");
            AddForeignKey("dbo.Empleadoes", "DepartamentoId", "dbo.Departamentoes", "Id", cascadeDelete: true);
            DropColumn("dbo.Empleadoes", "Departamento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Empleadoes", "Departamento", c => c.String());
            DropForeignKey("dbo.Empleadoes", "DepartamentoId", "dbo.Departamentoes");
            DropIndex("dbo.Empleadoes", new[] { "DepartamentoId" });
            DropColumn("dbo.Empleadoes", "DepartamentoId");
        }
    }
}

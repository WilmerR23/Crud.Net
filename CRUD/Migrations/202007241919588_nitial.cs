namespace CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActivoFijoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripción = c.String(),
                        DepartamentoId = c.Int(nullable: false),
                        TipoActivoId = c.Int(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        ValorCompra = c.Int(nullable: false),
                        DepreciaciónAcumulada = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamentoes", t => t.DepartamentoId, cascadeDelete: true)
                .ForeignKey("dbo.TipoActivoes", t => t.TipoActivoId, cascadeDelete: true)
                .Index(t => t.DepartamentoId)
                .Index(t => t.TipoActivoId);
            
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoActivoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        CuentaContableCompra = c.Int(nullable: false),
                        CuentaContableDepreciacion = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AsientoContables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoInventarioId = c.Int(nullable: false),
                        CuentaContable = c.Int(nullable: false),
                        MontoAsiento = c.Int(nullable: false),
                        Descripción = c.String(),
                        TipoMovimiento = c.String(),
                        FechaAsiento = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CalculoDepreciacions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AñoProceso = c.Int(nullable: false),
                        MesProceso = c.Int(nullable: false),
                        ActivoFijoId = c.Int(nullable: false),
                        DepreciaciónAcumulada = c.Int(nullable: false),
                        CuentaCompra = c.Int(nullable: false),
                        CuentaDepreciación = c.Int(nullable: false),
                        MontoDepreciado = c.Int(nullable: false),
                        FechaProceso = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ActivoFijoes", t => t.ActivoFijoId, cascadeDelete: true)
                .Index(t => t.ActivoFijoId);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Cedula = c.String(),
                        Departamento = c.String(),
                        TipoPersona = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaIngreso = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CalculoDepreciacions", "ActivoFijoId", "dbo.ActivoFijoes");
            DropForeignKey("dbo.ActivoFijoes", "TipoActivoId", "dbo.TipoActivoes");
            DropForeignKey("dbo.ActivoFijoes", "DepartamentoId", "dbo.Departamentoes");
            DropIndex("dbo.CalculoDepreciacions", new[] { "ActivoFijoId" });
            DropIndex("dbo.ActivoFijoes", new[] { "TipoActivoId" });
            DropIndex("dbo.ActivoFijoes", new[] { "DepartamentoId" });
            DropTable("dbo.Empleadoes");
            DropTable("dbo.CalculoDepreciacions");
            DropTable("dbo.AsientoContables");
            DropTable("dbo.TipoActivoes");
            DropTable("dbo.Departamentoes");
            DropTable("dbo.ActivoFijoes");
        }
    }
}

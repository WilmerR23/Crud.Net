namespace CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nitial3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActivoFijoes", "CalculoDepreciacion", c => c.Int(nullable: false));
            DropColumn("dbo.ActivoFijoes", "DepreciaciónAcumulada");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ActivoFijoes", "DepreciaciónAcumulada", c => c.Int(nullable: false));
            DropColumn("dbo.ActivoFijoes", "CalculoDepreciacion");
        }
    }
}

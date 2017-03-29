namespace SiPTV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INICIAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        pkCodigo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        PrecioUnitario = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkCodigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Productos");
        }
    }
}

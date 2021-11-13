namespace Desafio3DSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracion1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NombreCl = c.String(maxLength: 100),
                        ApellidoCl = c.String(maxLength: 100),
                        CorreoCl = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Pedidos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NombreCl = c.String(),
                        NombreProd = c.String(),
                        CantidadPedida = c.Int(nullable: false),
                        PrecioProd = c.String(),
                        Clientes_id = c.Int(),
                        Productos_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clientes", t => t.Clientes_id)
                .ForeignKey("dbo.Productos", t => t.Productos_id)
                .Index(t => t.Clientes_id)
                .Index(t => t.Productos_id);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NombreProd = c.String(maxLength: 200),
                        PrecioProd = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CantidadProd = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedidos", "Productos_id", "dbo.Productos");
            DropForeignKey("dbo.Pedidos", "Clientes_id", "dbo.Clientes");
            DropIndex("dbo.Pedidos", new[] { "Productos_id" });
            DropIndex("dbo.Pedidos", new[] { "Clientes_id" });
            DropTable("dbo.Productos");
            DropTable("dbo.Pedidos");
            DropTable("dbo.Clientes");
        }
    }
}

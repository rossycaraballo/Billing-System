namespace BillingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CondicionesPagoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 500),
                        CantidadDias = c.Int(nullable: false),
                        IdFactura = c.Int(nullable: false),
                        IdEstadoPago = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EstadoPagoes", t => t.IdEstadoPago, cascadeDelete: true)
                .ForeignKey("dbo.Facturas", t => t.IdFactura, cascadeDelete: true)
                .Index(t => t.IdFactura)
                .Index(t => t.IdEstadoPago);
            
            CreateTable(
                "dbo.EstadoPagoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Estado = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdFormaPago = c.Int(nullable: false),
                        IdVendedor = c.Int(nullable: false),
                        IdCliente = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Comentario = c.String(nullable: false, maxLength: 500),
                        IdProducto = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.IdCliente, cascadeDelete: true)
                .ForeignKey("dbo.FormaPagoes", t => t.IdFormaPago, cascadeDelete: true)
                .ForeignKey("dbo.Productoes", t => t.IdProducto, cascadeDelete: true)
                .ForeignKey("dbo.Vendedors", t => t.IdVendedor, cascadeDelete: true)
                .Index(t => t.IdFormaPago)
                .Index(t => t.IdVendedor)
                .Index(t => t.IdCliente)
                .Index(t => t.IdProducto);
            
            CreateTable(
                "dbo.FormaPagoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoFormaPago = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        CostoUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vendedors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 500),
                        PorcientoComision = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estado = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Clientes", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Clientes", "Documento", c => c.String(nullable: false));
            AlterColumn("dbo.Clientes", "Cuenta", c => c.String(nullable: false));
            AlterColumn("dbo.TipoDocumentoes", "Tipo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CondicionesPagoes", "IdFactura", "dbo.Facturas");
            DropForeignKey("dbo.Facturas", "IdVendedor", "dbo.Vendedors");
            DropForeignKey("dbo.Facturas", "IdProducto", "dbo.Productoes");
            DropForeignKey("dbo.Facturas", "IdFormaPago", "dbo.FormaPagoes");
            DropForeignKey("dbo.Facturas", "IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.CondicionesPagoes", "IdEstadoPago", "dbo.EstadoPagoes");
            DropIndex("dbo.Facturas", new[] { "IdProducto" });
            DropIndex("dbo.Facturas", new[] { "IdCliente" });
            DropIndex("dbo.Facturas", new[] { "IdVendedor" });
            DropIndex("dbo.Facturas", new[] { "IdFormaPago" });
            DropIndex("dbo.CondicionesPagoes", new[] { "IdEstadoPago" });
            DropIndex("dbo.CondicionesPagoes", new[] { "IdFactura" });
            AlterColumn("dbo.TipoDocumentoes", "Tipo", c => c.String());
            AlterColumn("dbo.Clientes", "Cuenta", c => c.String());
            AlterColumn("dbo.Clientes", "Documento", c => c.String());
            AlterColumn("dbo.Clientes", "Nombre", c => c.String());
            DropTable("dbo.Vendedors");
            DropTable("dbo.Productoes");
            DropTable("dbo.FormaPagoes");
            DropTable("dbo.Facturas");
            DropTable("dbo.EstadoPagoes");
            DropTable("dbo.CondicionesPagoes");
        }
    }
}

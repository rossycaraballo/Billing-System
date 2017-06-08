namespace BillingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Documento = c.String(),
                        Cuenta = c.String(),
                        Estado = c.Boolean(nullable: false),
                        IdTipoDocumento = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoDocumentoes", t => t.IdTipoDocumento, cascadeDelete: true)
                .Index(t => t.IdTipoDocumento);
            
            CreateTable(
                "dbo.TipoDocumentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "IdTipoDocumento", "dbo.TipoDocumentoes");
            DropIndex("dbo.Clientes", new[] { "IdTipoDocumento" });
            DropTable("dbo.TipoDocumentoes");
            DropTable("dbo.Clientes");
        }
    }
}

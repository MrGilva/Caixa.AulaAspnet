namespace Caixa.AulaAspnet.Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyParaTipoTelefoneEmTipoTelefone : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Telefones", "TipoTelefone_TipoTelefoneID", "dbo.TipoTelefones");
            DropIndex("dbo.Telefones", new[] { "TipoTelefone_TipoTelefoneID" });
            RenameColumn(table: "dbo.Telefones", name: "TipoTelefone_TipoTelefoneID", newName: "IdTipoTelefone");
            AlterColumn("dbo.Telefones", "IdTipoTelefone", c => c.Int(nullable: false));
            CreateIndex("dbo.Telefones", "IdTipoTelefone");
            AddForeignKey("dbo.Telefones", "IdTipoTelefone", "dbo.TipoTelefones", "TipoTelefoneID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telefones", "IdTipoTelefone", "dbo.TipoTelefones");
            DropIndex("dbo.Telefones", new[] { "IdTipoTelefone" });
            AlterColumn("dbo.Telefones", "IdTipoTelefone", c => c.Int());
            RenameColumn(table: "dbo.Telefones", name: "IdTipoTelefone", newName: "TipoTelefone_TipoTelefoneID");
            CreateIndex("dbo.Telefones", "TipoTelefone_TipoTelefoneID");
            AddForeignKey("dbo.Telefones", "TipoTelefone_TipoTelefoneID", "dbo.TipoTelefones", "TipoTelefoneID");
        }
    }
}

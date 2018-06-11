namespace AppGestionEMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGrupoClases : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GruposClases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        CapacidadAlumnosGrupo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GruposClases");
        }
    }
}

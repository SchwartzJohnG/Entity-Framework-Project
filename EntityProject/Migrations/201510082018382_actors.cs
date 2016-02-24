namespace EntityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Movie_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.Movie_Id)
                .Index(t => t.Movie_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Actors", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Actors", new[] { "Movie_Id" });
            DropTable("dbo.Actors");
        }
    }
}

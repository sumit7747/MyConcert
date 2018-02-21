namespace MyConcert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class applydataannotationsonconcertgenre : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.concerts", "Artist_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.concerts", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.concerts", new[] { "Artist_Id" });
            DropIndex("dbo.concerts", new[] { "Genre_Id" });
            AlterColumn("dbo.concerts", "Venue", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.concerts", "Artist_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.concerts", "Genre_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.concerts", "Artist_Id");
            CreateIndex("dbo.concerts", "Genre_Id");
            AddForeignKey("dbo.concerts", "Artist_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.concerts", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.concerts", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.concerts", "Artist_Id", "dbo.AspNetUsers");
            DropIndex("dbo.concerts", new[] { "Genre_Id" });
            DropIndex("dbo.concerts", new[] { "Artist_Id" });
            AlterColumn("dbo.Genres", "Name", c => c.String());
            AlterColumn("dbo.concerts", "Genre_Id", c => c.Int());
            AlterColumn("dbo.concerts", "Artist_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.concerts", "Venue", c => c.String());
            CreateIndex("dbo.concerts", "Genre_Id");
            CreateIndex("dbo.concerts", "Artist_Id");
            AddForeignKey("dbo.concerts", "Genre_Id", "dbo.Genres", "Id");
            AddForeignKey("dbo.concerts", "Artist_Id", "dbo.AspNetUsers", "Id");
        }
    }
}

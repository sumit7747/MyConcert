namespace MyConcert.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class seeddata : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into genres (Id,Name) Values (1,'Rock')");
            Sql("Insert into genres (Id,Name) Values (2,'Jazz')");
            Sql("Insert into genres (Id,Name) Values (3,'Bass')");
            Sql("Insert into genres (Id,Name) Values (4,'Country')");


        }

        public override void Down()
        {
            Sql("Delete from genere where Id IN (1,2,3,4)");
        }
    }
}

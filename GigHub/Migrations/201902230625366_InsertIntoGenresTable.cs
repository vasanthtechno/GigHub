namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InsertIntoGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES(NAME) VALUES ('Jazz')");
            Sql("INSERT INTO GENRES(NAME) VALUES ('Pop')");
            Sql("INSERT INTO GENRES(NAME) VALUES ('Classical')");
            Sql("INSERT INTO GENRES(NAME) VALUES ('Blues')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM GENRES WHERE ID IN (1,2,3,4)");
        }
    }
}

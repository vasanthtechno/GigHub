namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InsertIntoGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES VALUES (1, 'Jazz')");
            Sql("INSERT INTO GENRES VALUES (2, 'Pop')");
            Sql("INSERT INTO GENRES VALUES (3, 'Jazz')");
            Sql("INSERT INTO GENRES VALUES (4, 'Jazz')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM GENRES WHERE ID IN (1,2,3,4)");
        }
    }
}

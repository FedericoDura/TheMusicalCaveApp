namespace TheMusicalCaveApp.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestData : DbMigration
    {
        public override void Up()
        {
            //Adding Albums
            Sql(@"Insert into Albums Values('Slippery When Wet')");
            Sql(@"Insert into Albums Values('Led Zeppeling IV')");
            Sql(@"Insert into Albums Values('Slowhand')");
            Sql(@"Insert into Albums Values('Fragile')");
            Sql(@"Insert into Albums Values('Freedom at Point Zero')");

            //Adding Songs
            Sql(@"Insert into Tracks Values(1,'Let It Rock')");
            Sql(@"Insert into Tracks Values(1,'You Give Love a Bad Name')");
            Sql(@"Insert into Tracks Values(1,'Livin on a Prayer')");
            Sql(@"Insert into Tracks Values(1,'Social Disease')");
            Sql(@"Insert into Tracks Values(1,'Wanted Dead or Alive')");

            Sql(@"Insert into Tracks Values(2,'Black Dog')");
            Sql(@"Insert into Tracks Values(2,'Rock and Roll')");
            Sql(@"Insert into Tracks Values(2,'The Battle of Evermore')");
            Sql(@"Insert into Tracks Values(2,'Stairway to Heaven')");
            Sql(@"Insert into Tracks Values(2,'Misty Mountain Hop')");

            Sql(@"Insert into Tracks Values(3,'Cocaine')");
            Sql(@"Insert into Tracks Values(3,'Wonderful Tonight')");
            Sql(@"Insert into Tracks Values(3,'Lay Down Sally')");
            Sql(@"Insert into Tracks Values(3,'Next Time You See Her')");
            Sql(@"Insert into Tracks Values(3,'We are All the Way')");

            Sql(@"Insert into Tracks Values(4,'Roundabout')");
            Sql(@"Insert into Tracks Values(4,'Cans and Brahms')");
            Sql(@"Insert into Tracks Values(4,'We Have Heaven')");
            Sql(@"Insert into Tracks Values(4,'South Side of the Sky')");
            Sql(@"Insert into Tracks Values(4,'Five per Cent for Nothing')");

            Sql(@"Insert into Tracks Values(5,'Jane')");
            Sql(@"Insert into Tracks Values(5,'Lightning Rose')");
            Sql(@"Insert into Tracks Values(5,'Things to Come')");
            Sql(@"Insert into Tracks Values(5,'Awakening')");
            Sql(@"Insert into Tracks Values(5,'Girl with the Hungry Eyes')");
        }
        
        public override void Down()
        {
            
        }
    }
}

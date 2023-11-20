namespace ScoreManagementTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialScoreEntry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ScoreEntries",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Date = c.DateTime(nullable: false),
                    PlayerName = c.String(),
                    PlayerScore = c.Int(nullable: false),
                    GameType = c.String(),
                    Notes = c.String(),
                })
    .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.ScoreEntries");
        }
    }
}

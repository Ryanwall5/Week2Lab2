namespace Lab2_RyanWall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserCellFavoriteNBAAndDoYouPlayVG : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FavoriteNBATeam", c => c.String(nullable: false));
            AddColumn("dbo.Users", "DoYouPlayVG", c => c.Boolean(nullable: false));
            DropColumn("dbo.Users", "phoneNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "phoneNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "DoYouPlayVG");
            DropColumn("dbo.Users", "FavoriteNBATeam");
        }
    }
}

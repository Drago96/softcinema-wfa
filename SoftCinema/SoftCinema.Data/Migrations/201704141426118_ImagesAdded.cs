namespace SoftCinema.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ImagesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Size = c.Int(nullable: false),
                    Content = c.Binary(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.Images");
        }
    }
}
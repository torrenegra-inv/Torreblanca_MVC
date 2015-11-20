using FluentMigrator;

namespace SimpleBlog.Migrations
{
    [Migration(3)]
    public class _003_AddContentToPost : Migration
    {
        public override void Up()
        {
            Create.Column("content").OnTable("posts").AsCustom("TEXT");
        }

        public override void Down()
        {
            Delete.Column("content").FromTable("posts");
        }
    }
}
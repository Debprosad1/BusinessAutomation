using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessAutomation.Database.Migrations
{
    /// <inheritdoc />
    public partial class Brand_Id_Changed_To_Int : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE [dbo].[Brands] DROP CONSTRAINT [PK_Brands]");

            migrationBuilder.DropColumn(
               name: "Id",
               table: "Brands");

            migrationBuilder.AddColumn<int>(
               name: "Id",
               table: "Brands",
               type: "int",
               nullable: false).Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.Sql("ALTER TABLE [dbo].[Brands] ADD  CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED \r\n(\r\n\t[Id] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)");
            //migrationBuilder.AlterColumn<int>(
            //    name: "Id",
            //    table: "Brands",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)")
            //    .Annotation("SqlServer:Identity", "1, 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("ALTER TABLE [dbo].[Brands] DROP CONSTRAINT [PK_Brands]");

            migrationBuilder.DropColumn(
              name: "Id",
              table: "Brands");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Brands",
                type: "nvarchar(450)",
                nullable: false
               );
            migrationBuilder.Sql("ALTER TABLE [dbo].[Brands] ADD  CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED \r\n(\r\n\t[Id] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)");


        }
    }
}

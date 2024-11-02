using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeBlog.Data.Migrations
{
    public partial class SeedComppleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Images",
                newName: "FileName");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("7dbd3759-a9d3-49dc-9c99-974e69ac9b92"), "Admin Test", new DateTime(2024, 10, 6, 13, 41, 2, 621, DateTimeKind.Local).AddTicks(4007), null, null, false, null, null, "Visual Studio 2022" },
                    { new Guid("9d79512d-f19c-4872-982e-fc982916df52"), "Admin Test", new DateTime(2024, 10, 6, 13, 41, 2, 621, DateTimeKind.Local).AddTicks(4004), null, null, false, null, null, "ASP .NET Core" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("4eb578f7-2d83-4832-b0b6-483f12c5a5cc"), "Admin Test", new DateTime(2024, 10, 6, 13, 41, 2, 621, DateTimeKind.Local).AddTicks(4165), null, null, "images/vstest", "png", false, null, null },
                    { new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"), "Admin Test", new DateTime(2024, 10, 6, 13, 41, 2, 621, DateTimeKind.Local).AddTicks(4153), null, null, "images/testimage", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("66bb1619-43ca-4f51-9b9b-9127519d6228"), new Guid("9d79512d-f19c-4872-982e-fc982916df52"), "Lorem ipsum odor amet, consectetuer adipiscing elit. Magna donec nec inceptos luctus non. Hac dis nascetur facilisi orci risus iaculis. Sem dapibus aliquet sollicitudin dapibus pellentesque tortor mus. Netus duis sodales eu fermentum porttitor velit aptent vitae. Odio metus elementum phasellus tellus mi volutpat mi. Posuere ultricies convallis; class pulvinar nullam pharetra curabitur egestas. Aliquet eros eget eleifend etiam felis eu himenaeos. Interdum condimentum magnis iaculis viverra sociosqu et adipiscing lorem senectus.\r\n\r\nUltrices senectus iaculis lectus ut nisi potenti risus curae euismod. Iaculis scelerisque ad bibendum tellus mi nostra sed dis condimentum. Libero at quam aenean penatibus hac primis varius. Rhoncus velit venenatis dui natoque sodales lacinia ultrices. Vulputate fusce cursus nisi mi nam class cras. Parturient sed inceptos aliquet donec conubia elementum, ex venenatis ullamcorper. Tincidunt himenaeos tortor; metus cubilia volutpat congue vitae id. Cras mollis dis tempus quisque molestie auctor ultrices nascetur. Nunc laoreet varius, finibus diam hendrerit faucibus.\r\n\r\nEst eleifend faucibus purus class amet. Sodales ex rutrum nunc semper aliquet cubilia viverra ante. Interdum habitant primis primis varius mus felis nulla diam potenti. Sed dolor magnis mus quis litora. Et mattis amet nulla sapien finibus aptent. Sollicitudin suspendisse himenaeos commodo fermentum dis faucibus fringilla lectus. Fames integer urna tristique penatibus bibendum nostra. Sed primis erat efficitur ad hendrerit tincidunt felis egestas.", "Admin Test", new DateTime(2024, 10, 6, 13, 41, 2, 621, DateTimeKind.Local).AddTicks(3858), null, null, new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("d6cd3859-e5aa-4bf1-baf1-a2f24e0ac18e"), new Guid("7dbd3759-a9d3-49dc-9c99-974e69ac9b92"), "Lorem ipsum odor amet, consectetuer adipiscing elit. Magna donec nec inceptos luctus non. Hac dis nascetur facilisi orci risus iaculis. Sem dapibus aliquet sollicitudin dapibus pellentesque tortor mus. Netus duis sodales eu fermentum porttitor velit aptent vitae. Odio metus elementum phasellus tellus mi volutpat mi. Posuere ultricies convallis; class pulvinar nullam pharetra curabitur egestas. Aliquet eros eget eleifend etiam felis eu himenaeos. Interdum condimentum magnis iaculis viverra sociosqu et adipiscing lorem senectus.\r\n\r\nUltrices senectus iaculis lectus ut nisi potenti risus curae euismod. Iaculis scelerisque ad bibendum tellus mi nostra sed dis condimentum. Libero at quam aenean penatibus hac primis varius. Rhoncus velit venenatis dui natoque sodales lacinia ultrices. Vulputate fusce cursus nisi mi nam class cras. Parturient sed inceptos aliquet donec conubia elementum, ex venenatis ullamcorper. Tincidunt himenaeos tortor; metus cubilia volutpat congue vitae id. Cras mollis dis tempus quisque molestie auctor ultrices nascetur. Nunc laoreet varius, finibus diam hendrerit faucibus.\r\n\r\nEst eleifend faucibus purus class amet. Sodales ex rutrum nunc semper aliquet cubilia viverra ante. Interdum habitant primis primis varius mus felis nulla diam potenti. Sed dolor magnis mus quis litora. Et mattis amet nulla sapien finibus aptent. Sollicitudin suspendisse himenaeos commodo fermentum dis faucibus fringilla lectus. Fames integer urna tristique penatibus bibendum nostra. Sed primis erat efficitur ad hendrerit tincidunt felis egestas.", "Admin Test", new DateTime(2024, 10, 6, 13, 41, 2, 621, DateTimeKind.Local).AddTicks(3862), null, null, new Guid("4eb578f7-2d83-4832-b0b6-483f12c5a5cc"), false, null, null, "Visual Studio Deneme Makalesi 2", 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("66bb1619-43ca-4f51-9b9b-9127519d6228"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d6cd3859-e5aa-4bf1-baf1-a2f24e0ac18e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7dbd3759-a9d3-49dc-9c99-974e69ac9b92"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d79512d-f19c-4872-982e-fc982916df52"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4eb578f7-2d83-4832-b0b6-483f12c5a5cc"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"));

            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "Images",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeBlog.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7a0ec460-1800-4e62-a7a4-819f46f17c9f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("83f5b0ff-c2dd-40df-b86d-0ab9867388e3"));

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ImageId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("c599d11a-98af-48eb-bf4f-eadc3f4c9b6d"), new Guid("9d79512d-f19c-4872-982e-fc982916df52"), "Lorem ipsum odor amet, consectetuer adipiscing elit. Magna donec nec inceptos luctus non. Hac dis nascetur facilisi orci risus iaculis. Sem dapibus aliquet sollicitudin dapibus pellentesque tortor mus. Netus duis sodales eu fermentum porttitor velit aptent vitae. Odio metus elementum phasellus tellus mi volutpat mi. Posuere ultricies convallis; class pulvinar nullam pharetra curabitur egestas. Aliquet eros eget eleifend etiam felis eu himenaeos. Interdum condimentum magnis iaculis viverra sociosqu et adipiscing lorem senectus.\r\n\r\nUltrices senectus iaculis lectus ut nisi potenti risus curae euismod. Iaculis scelerisque ad bibendum tellus mi nostra sed dis condimentum. Libero at quam aenean penatibus hac primis varius. Rhoncus velit venenatis dui natoque sodales lacinia ultrices. Vulputate fusce cursus nisi mi nam class cras. Parturient sed inceptos aliquet donec conubia elementum, ex venenatis ullamcorper. Tincidunt himenaeos tortor; metus cubilia volutpat congue vitae id. Cras mollis dis tempus quisque molestie auctor ultrices nascetur. Nunc laoreet varius, finibus diam hendrerit faucibus.\r\n\r\nEst eleifend faucibus purus class amet. Sodales ex rutrum nunc semper aliquet cubilia viverra ante. Interdum habitant primis primis varius mus felis nulla diam potenti. Sed dolor magnis mus quis litora. Et mattis amet nulla sapien finibus aptent. Sollicitudin suspendisse himenaeos commodo fermentum dis faucibus fringilla lectus. Fames integer urna tristique penatibus bibendum nostra. Sed primis erat efficitur ad hendrerit tincidunt felis egestas.", "Admin Test", new DateTime(2024, 10, 21, 12, 52, 14, 11, DateTimeKind.Local).AddTicks(5780), null, null, new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"), false, null, null, "Visual Studio Deneme Makalesi 1", new Guid("897010e5-b0c4-4776-8630-c4fca38bfad7"), 15 },
                    { new Guid("f1b15505-1284-4cb0-8d6a-978bff9119a3"), new Guid("7dbd3759-a9d3-49dc-9c99-974e69ac9b92"), "Lorem ipsum odor amet, consectetuer adipiscing elit. Magna donec nec inceptos luctus non. Hac dis nascetur facilisi orci risus iaculis. Sem dapibus aliquet sollicitudin dapibus pellentesque tortor mus. Netus duis sodales eu fermentum porttitor velit aptent vitae. Odio metus elementum phasellus tellus mi volutpat mi. Posuere ultricies convallis; class pulvinar nullam pharetra curabitur egestas. Aliquet eros eget eleifend etiam felis eu himenaeos. Interdum condimentum magnis iaculis viverra sociosqu et adipiscing lorem senectus.\r\n\r\nUltrices senectus iaculis lectus ut nisi potenti risus curae euismod. Iaculis scelerisque ad bibendum tellus mi nostra sed dis condimentum. Libero at quam aenean penatibus hac primis varius. Rhoncus velit venenatis dui natoque sodales lacinia ultrices. Vulputate fusce cursus nisi mi nam class cras. Parturient sed inceptos aliquet donec conubia elementum, ex venenatis ullamcorper. Tincidunt himenaeos tortor; metus cubilia volutpat congue vitae id. Cras mollis dis tempus quisque molestie auctor ultrices nascetur. Nunc laoreet varius, finibus diam hendrerit faucibus.\r\n\r\nEst eleifend faucibus purus class amet. Sodales ex rutrum nunc semper aliquet cubilia viverra ante. Interdum habitant primis primis varius mus felis nulla diam potenti. Sed dolor magnis mus quis litora. Et mattis amet nulla sapien finibus aptent. Sollicitudin suspendisse himenaeos commodo fermentum dis faucibus fringilla lectus. Fames integer urna tristique penatibus bibendum nostra. Sed primis erat efficitur ad hendrerit tincidunt felis egestas.", "Admin Test", new DateTime(2024, 10, 21, 12, 52, 14, 11, DateTimeKind.Local).AddTicks(5786), null, null, new Guid("4eb578f7-2d83-4832-b0b6-483f12c5a5cc"), false, null, null, "Visual Studio Deneme Makalesi 2", new Guid("12ec1a48-7faa-43a0-afa3-e438928e5983"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3c25d1ee-c548-4ad1-a002-3aefeaac6037"),
                column: "ConcurrencyStamp",
                value: "e7c7d4a7-763b-4aec-8ec0-588eeea0b184");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8de3b7c6-5c8b-43ce-b764-1451667b4e5e"),
                column: "ConcurrencyStamp",
                value: "a23a1300-5004-4abf-b46b-9120d43b831f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59db774-f8e0-49af-a700-ab4dc816b6ed"),
                column: "ConcurrencyStamp",
                value: "2631beb2-7862-4a4f-b2fb-6ec2fdcc3efc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12ec1a48-7faa-43a0-afa3-e438928e5983"),
                columns: new[] { "ConcurrencyStamp", "ImageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56d40766-6d4f-4086-9cb8-023d54977ade", new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"), "AQAAAAEAACcQAAAAEGRjtHBgD6cbo17sRh9uzGx6UOn9DkEVy/1Nk5VWRfc+Q4lXW35Qj5DBgs2O7EY8fw==", "46c432cc-9c69-4f66-8b11-75daa60cb855" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("897010e5-b0c4-4776-8630-c4fca38bfad7"),
                columns: new[] { "ConcurrencyStamp", "ImageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e8d2999-3610-4833-98ce-e7194e9dee39", new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"), "AQAAAAEAACcQAAAAENRFRll8Buexlja2ouPGnKQkzljBJh+sr10HoX5lPitBChkoRf1J5Kv1fMjSrmOaVw==", "c9181591-c485-46eb-bb5a-b0ba4c0c6ef0" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7dbd3759-a9d3-49dc-9c99-974e69ac9b92"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 21, 12, 52, 14, 11, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d79512d-f19c-4872-982e-fc982916df52"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 21, 12, 52, 14, 11, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4eb578f7-2d83-4832-b0b6-483f12c5a5cc"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 21, 12, 52, 14, 11, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 21, 12, 52, 14, 11, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_UserId",
                table: "Articles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_UserId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_Articles_UserId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c599d11a-98af-48eb-bf4f-eadc3f4c9b6d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f1b15505-1284-4cb0-8d6a-978bff9119a3"));

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Articles");

            migrationBuilder.AlterColumn<Guid>(
                name: "ImageId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("7a0ec460-1800-4e62-a7a4-819f46f17c9f"), new Guid("9d79512d-f19c-4872-982e-fc982916df52"), "Lorem ipsum odor amet, consectetuer adipiscing elit. Magna donec nec inceptos luctus non. Hac dis nascetur facilisi orci risus iaculis. Sem dapibus aliquet sollicitudin dapibus pellentesque tortor mus. Netus duis sodales eu fermentum porttitor velit aptent vitae. Odio metus elementum phasellus tellus mi volutpat mi. Posuere ultricies convallis; class pulvinar nullam pharetra curabitur egestas. Aliquet eros eget eleifend etiam felis eu himenaeos. Interdum condimentum magnis iaculis viverra sociosqu et adipiscing lorem senectus.\r\n\r\nUltrices senectus iaculis lectus ut nisi potenti risus curae euismod. Iaculis scelerisque ad bibendum tellus mi nostra sed dis condimentum. Libero at quam aenean penatibus hac primis varius. Rhoncus velit venenatis dui natoque sodales lacinia ultrices. Vulputate fusce cursus nisi mi nam class cras. Parturient sed inceptos aliquet donec conubia elementum, ex venenatis ullamcorper. Tincidunt himenaeos tortor; metus cubilia volutpat congue vitae id. Cras mollis dis tempus quisque molestie auctor ultrices nascetur. Nunc laoreet varius, finibus diam hendrerit faucibus.\r\n\r\nEst eleifend faucibus purus class amet. Sodales ex rutrum nunc semper aliquet cubilia viverra ante. Interdum habitant primis primis varius mus felis nulla diam potenti. Sed dolor magnis mus quis litora. Et mattis amet nulla sapien finibus aptent. Sollicitudin suspendisse himenaeos commodo fermentum dis faucibus fringilla lectus. Fames integer urna tristique penatibus bibendum nostra. Sed primis erat efficitur ad hendrerit tincidunt felis egestas.", "Admin Test", new DateTime(2024, 10, 21, 9, 55, 0, 733, DateTimeKind.Local).AddTicks(6565), null, null, new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 },
                    { new Guid("83f5b0ff-c2dd-40df-b86d-0ab9867388e3"), new Guid("7dbd3759-a9d3-49dc-9c99-974e69ac9b92"), "Lorem ipsum odor amet, consectetuer adipiscing elit. Magna donec nec inceptos luctus non. Hac dis nascetur facilisi orci risus iaculis. Sem dapibus aliquet sollicitudin dapibus pellentesque tortor mus. Netus duis sodales eu fermentum porttitor velit aptent vitae. Odio metus elementum phasellus tellus mi volutpat mi. Posuere ultricies convallis; class pulvinar nullam pharetra curabitur egestas. Aliquet eros eget eleifend etiam felis eu himenaeos. Interdum condimentum magnis iaculis viverra sociosqu et adipiscing lorem senectus.\r\n\r\nUltrices senectus iaculis lectus ut nisi potenti risus curae euismod. Iaculis scelerisque ad bibendum tellus mi nostra sed dis condimentum. Libero at quam aenean penatibus hac primis varius. Rhoncus velit venenatis dui natoque sodales lacinia ultrices. Vulputate fusce cursus nisi mi nam class cras. Parturient sed inceptos aliquet donec conubia elementum, ex venenatis ullamcorper. Tincidunt himenaeos tortor; metus cubilia volutpat congue vitae id. Cras mollis dis tempus quisque molestie auctor ultrices nascetur. Nunc laoreet varius, finibus diam hendrerit faucibus.\r\n\r\nEst eleifend faucibus purus class amet. Sodales ex rutrum nunc semper aliquet cubilia viverra ante. Interdum habitant primis primis varius mus felis nulla diam potenti. Sed dolor magnis mus quis litora. Et mattis amet nulla sapien finibus aptent. Sollicitudin suspendisse himenaeos commodo fermentum dis faucibus fringilla lectus. Fames integer urna tristique penatibus bibendum nostra. Sed primis erat efficitur ad hendrerit tincidunt felis egestas.", "Admin Test", new DateTime(2024, 10, 21, 9, 55, 0, 733, DateTimeKind.Local).AddTicks(6570), null, null, new Guid("4eb578f7-2d83-4832-b0b6-483f12c5a5cc"), false, null, null, "Visual Studio Deneme Makalesi 2", 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3c25d1ee-c548-4ad1-a002-3aefeaac6037"),
                column: "ConcurrencyStamp",
                value: "e6fa48bf-2573-459e-91d5-4cfb31c85634");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8de3b7c6-5c8b-43ce-b764-1451667b4e5e"),
                column: "ConcurrencyStamp",
                value: "8bd64081-ab1b-46aa-b467-cef59fb71539");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59db774-f8e0-49af-a700-ab4dc816b6ed"),
                column: "ConcurrencyStamp",
                value: "5c959984-2bfe-476b-b658-9a9a4555a264");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12ec1a48-7faa-43a0-afa3-e438928e5983"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cc1b310-44b2-4a53-b7f4-c1710f169b59", "AQAAAAEAACcQAAAAEI6hPuM91s/0HyHDs/W2ySwjzDqmfCZBffP+P2kkfJFkqfM5LpwiKZ1T3KKK489uhw==", "1a9d7637-ca97-41fe-84df-ba8e1e8d7dda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("897010e5-b0c4-4776-8630-c4fca38bfad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "148a16d0-b48e-4b8d-a174-0a922bb9172f", "AQAAAAEAACcQAAAAEM2MR8Xl5YyK2QzbF8HUuiyWgzOYAfBwcz8ByVjgyzB7UCL0Dq7S/K48gUlnIwmd4Q==", "2d5c69c4-4163-41d3-b809-a11122de673c" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7dbd3759-a9d3-49dc-9c99-974e69ac9b92"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 21, 9, 55, 0, 733, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d79512d-f19c-4872-982e-fc982916df52"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 21, 9, 55, 0, 733, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4eb578f7-2d83-4832-b0b6-483f12c5a5cc"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 21, 9, 55, 0, 733, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 21, 9, 55, 0, 733, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

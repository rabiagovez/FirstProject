using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeBlog.Data.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c599d11a-98af-48eb-bf4f-eadc3f4c9b6d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f1b15505-1284-4cb0-8d6a-978bff9119a3"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("4a39ba31-2178-409b-96fd-4060c68c0582"), new Guid("7dbd3759-a9d3-49dc-9c99-974e69ac9b92"), "Lorem ipsum odor amet, consectetuer adipiscing elit. Magna donec nec inceptos luctus non. Hac dis nascetur facilisi orci risus iaculis. Sem dapibus aliquet sollicitudin dapibus pellentesque tortor mus. Netus duis sodales eu fermentum porttitor velit aptent vitae. Odio metus elementum phasellus tellus mi volutpat mi. Posuere ultricies convallis; class pulvinar nullam pharetra curabitur egestas. Aliquet eros eget eleifend etiam felis eu himenaeos. Interdum condimentum magnis iaculis viverra sociosqu et adipiscing lorem senectus.\r\n\r\nUltrices senectus iaculis lectus ut nisi potenti risus curae euismod. Iaculis scelerisque ad bibendum tellus mi nostra sed dis condimentum. Libero at quam aenean penatibus hac primis varius. Rhoncus velit venenatis dui natoque sodales lacinia ultrices. Vulputate fusce cursus nisi mi nam class cras. Parturient sed inceptos aliquet donec conubia elementum, ex venenatis ullamcorper. Tincidunt himenaeos tortor; metus cubilia volutpat congue vitae id. Cras mollis dis tempus quisque molestie auctor ultrices nascetur. Nunc laoreet varius, finibus diam hendrerit faucibus.\r\n\r\nEst eleifend faucibus purus class amet. Sodales ex rutrum nunc semper aliquet cubilia viverra ante. Interdum habitant primis primis varius mus felis nulla diam potenti. Sed dolor magnis mus quis litora. Et mattis amet nulla sapien finibus aptent. Sollicitudin suspendisse himenaeos commodo fermentum dis faucibus fringilla lectus. Fames integer urna tristique penatibus bibendum nostra. Sed primis erat efficitur ad hendrerit tincidunt felis egestas.", "Admin Test", new DateTime(2024, 11, 2, 18, 17, 34, 176, DateTimeKind.Local).AddTicks(7374), null, null, new Guid("4eb578f7-2d83-4832-b0b6-483f12c5a5cc"), false, null, null, "Visual Studio Deneme Makalesi 2", new Guid("12ec1a48-7faa-43a0-afa3-e438928e5983"), 15 },
                    { new Guid("5162c7fe-2712-4c7c-b466-31da3fa8d422"), new Guid("9d79512d-f19c-4872-982e-fc982916df52"), "Lorem ipsum odor amet, consectetuer adipiscing elit. Magna donec nec inceptos luctus non. Hac dis nascetur facilisi orci risus iaculis. Sem dapibus aliquet sollicitudin dapibus pellentesque tortor mus. Netus duis sodales eu fermentum porttitor velit aptent vitae. Odio metus elementum phasellus tellus mi volutpat mi. Posuere ultricies convallis; class pulvinar nullam pharetra curabitur egestas. Aliquet eros eget eleifend etiam felis eu himenaeos. Interdum condimentum magnis iaculis viverra sociosqu et adipiscing lorem senectus.\r\n\r\nUltrices senectus iaculis lectus ut nisi potenti risus curae euismod. Iaculis scelerisque ad bibendum tellus mi nostra sed dis condimentum. Libero at quam aenean penatibus hac primis varius. Rhoncus velit venenatis dui natoque sodales lacinia ultrices. Vulputate fusce cursus nisi mi nam class cras. Parturient sed inceptos aliquet donec conubia elementum, ex venenatis ullamcorper. Tincidunt himenaeos tortor; metus cubilia volutpat congue vitae id. Cras mollis dis tempus quisque molestie auctor ultrices nascetur. Nunc laoreet varius, finibus diam hendrerit faucibus.\r\n\r\nEst eleifend faucibus purus class amet. Sodales ex rutrum nunc semper aliquet cubilia viverra ante. Interdum habitant primis primis varius mus felis nulla diam potenti. Sed dolor magnis mus quis litora. Et mattis amet nulla sapien finibus aptent. Sollicitudin suspendisse himenaeos commodo fermentum dis faucibus fringilla lectus. Fames integer urna tristique penatibus bibendum nostra. Sed primis erat efficitur ad hendrerit tincidunt felis egestas.", "Admin Test", new DateTime(2024, 11, 2, 18, 17, 34, 176, DateTimeKind.Local).AddTicks(7364), null, null, new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"), false, null, null, "Visual Studio Deneme Makalesi 1", new Guid("897010e5-b0c4-4776-8630-c4fca38bfad7"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3c25d1ee-c548-4ad1-a002-3aefeaac6037"),
                column: "ConcurrencyStamp",
                value: "27075f13-caf2-4191-958b-6e49fb469937");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8de3b7c6-5c8b-43ce-b764-1451667b4e5e"),
                column: "ConcurrencyStamp",
                value: "75bc21aa-cc20-45f3-96b6-e884c51bd87f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59db774-f8e0-49af-a700-ab4dc816b6ed"),
                column: "ConcurrencyStamp",
                value: "7fb1170d-9a8c-4f51-94fd-65328fb09869");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12ec1a48-7faa-43a0-afa3-e438928e5983"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4302f04-488e-40fe-98b4-d832cdaf9af3", "AQAAAAEAACcQAAAAEBrvLNsK5HTGCSXxJX+JzFC2ZBJZ//FxMLC0OIH/T0dRx1ueQL948GjD9dazhvqk+A==", "52738111-8547-44af-ab9d-3379e8dafdd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("897010e5-b0c4-4776-8630-c4fca38bfad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3958b53a-2e6b-4986-b21f-6d67e705dd1f", "AQAAAAEAACcQAAAAEAp8RHAHUr5bHU6RNkvwXoLThWhymjFhTiwsU6QLhys3ATwD4BtxWh4npPzxbiLI1Q==", "482f1e82-0766-44d2-b0b3-f0a4b0653578" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7dbd3759-a9d3-49dc-9c99-974e69ac9b92"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 18, 17, 34, 176, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d79512d-f19c-4872-982e-fc982916df52"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 17, 34, 176, DateTimeKind.Local).AddTicks(7618), "ASP.NET Core" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4eb578f7-2d83-4832-b0b6-483f12c5a5cc"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 18, 17, 34, 176, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 18, 17, 34, 176, DateTimeKind.Local).AddTicks(7740));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4a39ba31-2178-409b-96fd-4060c68c0582"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5162c7fe-2712-4c7c-b466-31da3fa8d422"));

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56d40766-6d4f-4086-9cb8-023d54977ade", "AQAAAAEAACcQAAAAEGRjtHBgD6cbo17sRh9uzGx6UOn9DkEVy/1Nk5VWRfc+Q4lXW35Qj5DBgs2O7EY8fw==", "46c432cc-9c69-4f66-8b11-75daa60cb855" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("897010e5-b0c4-4776-8630-c4fca38bfad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e8d2999-3610-4833-98ce-e7194e9dee39", "AQAAAAEAACcQAAAAENRFRll8Buexlja2ouPGnKQkzljBJh+sr10HoX5lPitBChkoRf1J5Kv1fMjSrmOaVw==", "c9181591-c485-46eb-bb5a-b0ba4c0c6ef0" });

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
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 21, 12, 52, 14, 11, DateTimeKind.Local).AddTicks(5938), "ASP .NET Core" });

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
        }
    }
}

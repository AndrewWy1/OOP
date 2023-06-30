using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Musical_Equipment_Shop_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("275bc5ba-d018-42b9-94d9-51223885133f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("30c1fdcd-119b-48ff-bff0-8431a487bd4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3648f415-b813-4858-aa44-d0ae0526ee86"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("39c90a69-0453-4512-962c-eeb511678557"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("697dae8f-d1f3-45c2-8e6c-df50d3a905ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7dba1741-6469-4d9c-b40a-333941f9e253"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9fb06550-24a3-4190-839d-698343fdcd82"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a12b7259-70b5-416b-a05d-e7ebddd9a334"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa1df7e3-fa8f-4a1d-9e0b-4e623e72a40e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6b17bcd-f250-4b6b-bf1b-91e6f12cb166"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bafbb5f1-7532-4298-b605-2e9937fdd234"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c21b3a08-629f-4e43-aa24-3b7b010a9521"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cb95fb58-d5cb-420b-bb8f-e3b02182084d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ea57e523-1b57-470d-98c7-cf42709d49e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fefbc21f-1363-4d5c-8a9c-a07a80e2b553"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryTitle" },
                values: new object[,]
                {
                    { new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"), "DJEquipment" },
                    { new Guid("7d185505-f396-4704-ac5e-2203f86a380a"), "Keyboards" },
                    { new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "Drums" },
                    { new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "Guitars" },
                    { new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "Accessories" },
                    { new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"), "Winds" },
                    { new Guid("da5547d4-0adf-4c80-a7dc-5b94618d5532"), "Percussion" },
                    { new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "Amplifiers" },
                    { new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "Strings" },
                    { new Guid("f39c349b-1119-4a1d-bc63-8c9848068051"), "RecordingEquipment" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountriesTitle" },
                values: new object[,]
                {
                    { new Guid("1228d3ef-a3c6-4ff9-a405-343cc130cfa1"), "Guinea-Bissau" },
                    { new Guid("3e556bdc-a3b2-42f2-b127-d39697b301c5"), "Poland" },
                    { new Guid("476085dd-0fc7-40a4-9448-38d9ddf9efbb"), "Guam" },
                    { new Guid("502ecbff-3836-49d3-aa47-4e925967d629"), "Iran" },
                    { new Guid("58b43d19-8ef5-4b41-8bc9-80d47817f3c6"), "Bolivia" },
                    { new Guid("660ab565-5a88-414f-849c-6b734d34f7a5"), "Cuba" },
                    { new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), "Greenland" },
                    { new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"), "Bahamas" },
                    { new Guid("94469291-205f-4a03-ae14-a1a69b0f1b49"), "Fiji" },
                    { new Guid("a52ef42c-985e-4ccf-a729-2eee31527a50"), "Slovenia" },
                    { new Guid("b14acd1e-8f37-4f2f-b07b-32e9d51fb888"), "Australia" },
                    { new Guid("b7da32ed-5444-494f-b2e8-220460bbce1c"), "Wallis and Futuna" },
                    { new Guid("c32b3369-9e5c-487b-95f9-a521b5970072"), "Ukraine" },
                    { new Guid("d36c2368-edf4-42c9-839d-2f650be9f814"), "Reunion" },
                    { new Guid("de5ab3d4-bef0-496e-bd40-ba165043f423"), "Angola" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "CountriesId", "Title" },
                values: new object[,]
                {
                    { new Guid("01a6bf5a-fae9-4779-a6ed-51cae0221202"), new Guid("660ab565-5a88-414f-849c-6b734d34f7a5"), "Ankunding and Sons" },
                    { new Guid("03045a2a-10b1-477d-a4ef-ef7f190c91f2"), new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"), "Ritchie, Will and Gulgowski" },
                    { new Guid("054c7fc1-38b4-4304-b974-5218b0510d7c"), new Guid("502ecbff-3836-49d3-aa47-4e925967d629"), "Senger, Wilderman and Herman" },
                    { new Guid("1a673745-22a6-4bd7-88c0-3fcf61dfa889"), new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"), "Toy, Runte and Franecki" },
                    { new Guid("21bda159-f948-48d0-b047-f458f0cf311a"), new Guid("c32b3369-9e5c-487b-95f9-a521b5970072"), "McDermott, Strosin and Connelly" },
                    { new Guid("254a85a8-d2be-4bcd-a9c8-c8c8599bfc4c"), new Guid("58b43d19-8ef5-4b41-8bc9-80d47817f3c6"), "Schumm LLC" },
                    { new Guid("2669a37a-a304-485e-9ca8-d9160bffe06e"), new Guid("1228d3ef-a3c6-4ff9-a405-343cc130cfa1"), "Ortiz, King and Fritsch" },
                    { new Guid("2d31ac0c-6505-4309-91f2-2fb09224d571"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), "Ledner, Rolfson and Langworth" },
                    { new Guid("39e92326-a02d-42eb-9ebc-b470d296cf3a"), new Guid("a52ef42c-985e-4ccf-a729-2eee31527a50"), "Hoppe Inc" },
                    { new Guid("39e97df3-cf4d-41c5-829d-36d03c5602bc"), new Guid("b14acd1e-8f37-4f2f-b07b-32e9d51fb888"), "Lang, Spencer and Gleichner" },
                    { new Guid("3d9eda6a-5893-4fc3-a872-7a0b2c2f8cc9"), new Guid("3e556bdc-a3b2-42f2-b127-d39697b301c5"), "Walker, Pfannerstill and Hackett" },
                    { new Guid("47f12374-c031-48f7-941b-555c461a174d"), new Guid("c32b3369-9e5c-487b-95f9-a521b5970072"), "Tromp, Shields and Haley" },
                    { new Guid("481da6a2-6255-418a-87f0-568e3410f294"), new Guid("b14acd1e-8f37-4f2f-b07b-32e9d51fb888"), "Gutmann - Kshlerin" },
                    { new Guid("4d4afe26-d71d-474d-8e37-496fc12807c1"), new Guid("b14acd1e-8f37-4f2f-b07b-32e9d51fb888"), "Hermiston Group" },
                    { new Guid("4e8070d9-edbe-4681-870f-e9f45bc11a1f"), new Guid("b7da32ed-5444-494f-b2e8-220460bbce1c"), "Ward LLC" },
                    { new Guid("5301b249-14b0-4681-917c-ff4f2703a3e4"), new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"), "Dickinson, Quitzon and Tromp" },
                    { new Guid("5c47daa5-55a4-4a32-b54f-abcb7b5cd42e"), new Guid("1228d3ef-a3c6-4ff9-a405-343cc130cfa1"), "Gislason, Donnelly and Batz" },
                    { new Guid("5f331490-6687-4941-9b79-10b4f80ed4c1"), new Guid("502ecbff-3836-49d3-aa47-4e925967d629"), "Pouros Inc" },
                    { new Guid("603af906-25f9-4209-b20a-b0417119dca1"), new Guid("de5ab3d4-bef0-496e-bd40-ba165043f423"), "Bogisich Group" },
                    { new Guid("66c8b94b-c8fd-4a5c-b15b-5d8748d3a31a"), new Guid("660ab565-5a88-414f-849c-6b734d34f7a5"), "Adams LLC" },
                    { new Guid("688cf0b2-bdf9-4cda-822b-d787e054fba1"), new Guid("3e556bdc-a3b2-42f2-b127-d39697b301c5"), "Strosin Inc" },
                    { new Guid("797a621c-cddd-45fc-9c10-8dc0b23f2bf0"), new Guid("502ecbff-3836-49d3-aa47-4e925967d629"), "Wolf Group" },
                    { new Guid("7a45dda1-04e7-405c-afbf-a14580e98517"), new Guid("b14acd1e-8f37-4f2f-b07b-32e9d51fb888"), "O'Hara - Strosin" },
                    { new Guid("7bd1eb0c-386b-472e-bfc8-c84052f4a135"), new Guid("94469291-205f-4a03-ae14-a1a69b0f1b49"), "Dare Group" },
                    { new Guid("7ebf7dc0-0b6e-4e37-a253-052e6b1c6849"), new Guid("a52ef42c-985e-4ccf-a729-2eee31527a50"), "Kuhic - Pacocha" },
                    { new Guid("82612713-45b1-47d9-9d4b-07c61d483006"), new Guid("476085dd-0fc7-40a4-9448-38d9ddf9efbb"), "Windler LLC" },
                    { new Guid("88645c3d-f762-4f27-8c29-a4ec72fb57a7"), new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"), "Kutch - Kuvalis" },
                    { new Guid("88a8f184-a8e0-462c-bdcf-583ea7acc695"), new Guid("94469291-205f-4a03-ae14-a1a69b0f1b49"), "Gleason Group" },
                    { new Guid("890f74cc-152d-43fe-83b8-f83f37558303"), new Guid("3e556bdc-a3b2-42f2-b127-d39697b301c5"), "Steuber, O'Keefe and Krajcik" },
                    { new Guid("8a9425ee-8af9-4e0c-bddc-f9d18dd2c26e"), new Guid("3e556bdc-a3b2-42f2-b127-d39697b301c5"), "Windler and Sons" },
                    { new Guid("983b4282-f914-4543-bccb-2b4eaa316f89"), new Guid("3e556bdc-a3b2-42f2-b127-d39697b301c5"), "Gulgowski, Frami and Hammes" },
                    { new Guid("9b815cd5-192c-49c5-bfee-9d48d6ee95dc"), new Guid("c32b3369-9e5c-487b-95f9-a521b5970072"), "Romaguera LLC" },
                    { new Guid("a179b06d-f731-46f0-aa45-ca4808be2ffe"), new Guid("58b43d19-8ef5-4b41-8bc9-80d47817f3c6"), "Wyman, Goyette and Gorczany" },
                    { new Guid("a6ef265f-3895-45bf-ac25-792dc3a1344f"), new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"), "Orn - Koch" },
                    { new Guid("abcc1531-6f47-4397-81f6-876d3e2d3365"), new Guid("660ab565-5a88-414f-849c-6b734d34f7a5"), "Daugherty and Sons" },
                    { new Guid("af28e4a8-9a43-44c6-9f97-61df8604fccc"), new Guid("660ab565-5a88-414f-849c-6b734d34f7a5"), "Rath Group" },
                    { new Guid("b0be6e91-5584-42a1-b71e-6c4fab23703c"), new Guid("58b43d19-8ef5-4b41-8bc9-80d47817f3c6"), "Conn - Orn" },
                    { new Guid("b1a74265-0a2b-4d04-b2e6-52599520fb6d"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), "Rohan, Schinner and Gulgowski" },
                    { new Guid("b6ef5064-91ab-4742-9dfc-d347a9a61122"), new Guid("3e556bdc-a3b2-42f2-b127-d39697b301c5"), "Heller, Wilderman and Jacobs" },
                    { new Guid("ba5dcec5-ca83-402f-971d-e841b3f0ef40"), new Guid("58b43d19-8ef5-4b41-8bc9-80d47817f3c6"), "Swaniawski - Gleason" },
                    { new Guid("bd59f4fb-57aa-43d5-b419-1eb398e1b699"), new Guid("94469291-205f-4a03-ae14-a1a69b0f1b49"), "Muller - Ullrich" },
                    { new Guid("c2eb7c2e-1c61-42e4-ac98-20606a897f84"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), "Rohan - Abernathy" },
                    { new Guid("cc6cfaac-85d1-4a22-b896-675530cb9eff"), new Guid("502ecbff-3836-49d3-aa47-4e925967d629"), "Wolff - Raynor" },
                    { new Guid("cd8d1372-670d-4c9b-aadc-1365fc5b0c62"), new Guid("d36c2368-edf4-42c9-839d-2f650be9f814"), "Moore - Stamm" },
                    { new Guid("d0884778-b211-415a-a7db-c8a2ead8a861"), new Guid("476085dd-0fc7-40a4-9448-38d9ddf9efbb"), "Kihn, Bruen and Cummerata" },
                    { new Guid("d375201a-048b-4172-acba-2da90145e5b2"), new Guid("58b43d19-8ef5-4b41-8bc9-80d47817f3c6"), "Larson - Ullrich" },
                    { new Guid("da7736b1-e809-4736-858c-7f25fdf08d29"), new Guid("502ecbff-3836-49d3-aa47-4e925967d629"), "Satterfield - VonRueden" },
                    { new Guid("dd07e372-5c9d-4502-a0ee-46525e8a5247"), new Guid("de5ab3d4-bef0-496e-bd40-ba165043f423"), "Dooley, Moen and Konopelski" },
                    { new Guid("f11542ea-d390-4930-b710-a43379c04c07"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), "Von - Mosciski" },
                    { new Guid("fb604e01-c7f4-4f21-ab45-356b8a3f0487"), new Guid("3e556bdc-a3b2-42f2-b127-d39697b301c5"), "Bode, Conroy and Pacocha" }
                });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "Id", "CategoriesId", "Description", "InstrumentTitle", "ManufacturerId" },
                values: new object[,]
                {
                    { new Guid("000a5eaa-c997-4217-9707-3fdafd74fded"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "The Football Is Good For Training And Recreational Purposes", "Violin", new Guid("983b4282-f914-4543-bccb-2b4eaa316f89") },
                    { new Guid("00ad7d26-1e70-4a52-b6a1-544070d48b88"), new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "DrumSet", new Guid("82612713-45b1-47d9-9d4b-07c61d483006") },
                    { new Guid("0123dbe7-f259-4d00-8528-1be597161fe6"), new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Cello", new Guid("da7736b1-e809-4736-858c-7f25fdf08d29") },
                    { new Guid("01c2ac5a-5cfe-42d2-8a55-f27e505f5024"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "DrumSet", new Guid("66c8b94b-c8fd-4a5c-b15b-5d8748d3a31a") },
                    { new Guid("0296b6aa-748d-4454-8866-23567a3ef665"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Violin", new Guid("481da6a2-6255-418a-87f0-568e3410f294") },
                    { new Guid("0384d92b-8231-48d9-99c2-eee00b915908"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Flute", new Guid("21bda159-f948-48d0-b047-f458f0cf311a") },
                    { new Guid("0758d565-7215-4d3c-9b32-59268e854eee"), new Guid("da5547d4-0adf-4c80-a7dc-5b94618d5532"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Cello", new Guid("03045a2a-10b1-477d-a4ef-ef7f190c91f2") },
                    { new Guid("078367cc-01fa-4a1e-a133-b294c5661130"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "The Football Is Good For Training And Recreational Purposes", "Keyboard", new Guid("39e97df3-cf4d-41c5-829d-36d03c5602bc") },
                    { new Guid("0dabe2e3-c79a-4bf5-8a90-8c37e11c49b8"), new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Violin", new Guid("cc6cfaac-85d1-4a22-b896-675530cb9eff") },
                    { new Guid("0f56ffdc-2f56-4763-b669-9e6fb972d0c5"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "DigitalPiano", new Guid("a179b06d-f731-46f0-aa45-ca4808be2ffe") },
                    { new Guid("0ff48e12-53d2-4c50-9820-4b53ae0f473a"), new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Saxophone", new Guid("fb604e01-c7f4-4f21-ab45-356b8a3f0487") },
                    { new Guid("1290c708-de76-4858-b2d2-5560bc7e8807"), new Guid("f39c349b-1119-4a1d-bc63-8c9848068051"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "DrumSet", new Guid("a6ef265f-3895-45bf-ac25-792dc3a1344f") },
                    { new Guid("167c2104-5884-4ff8-9e55-9bb46b3c1022"), new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "ElectricGuitar", new Guid("39e97df3-cf4d-41c5-829d-36d03c5602bc") },
                    { new Guid("1ba16455-2864-4957-86a3-0adfb117a160"), new Guid("f39c349b-1119-4a1d-bc63-8c9848068051"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "DigitalPiano", new Guid("797a621c-cddd-45fc-9c10-8dc0b23f2bf0") },
                    { new Guid("1bb1d373-2f3f-4ad2-8764-22eded39d359"), new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Saxophone", new Guid("054c7fc1-38b4-4304-b974-5218b0510d7c") },
                    { new Guid("1ed11088-1329-4c57-923e-5e9e6c0b38ef"), new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Violin", new Guid("a6ef265f-3895-45bf-ac25-792dc3a1344f") },
                    { new Guid("1f905643-97cb-4172-9196-0cbf8c16e8c6"), new Guid("7d185505-f396-4704-ac5e-2203f86a380a"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Saxophone", new Guid("688cf0b2-bdf9-4cda-822b-d787e054fba1") },
                    { new Guid("23db640b-dcf7-408b-9444-b83164fe6038"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Saxophone", new Guid("bd59f4fb-57aa-43d5-b419-1eb398e1b699") },
                    { new Guid("25f3b37d-3ca2-4df2-baee-b86a092b244c"), new Guid("da5547d4-0adf-4c80-a7dc-5b94618d5532"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Saxophone", new Guid("39e97df3-cf4d-41c5-829d-36d03c5602bc") },
                    { new Guid("274d2d08-d523-47a1-acdc-32ed80d4c184"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "ElectricGuitar", new Guid("603af906-25f9-4209-b20a-b0417119dca1") },
                    { new Guid("28149c1c-e0b5-469e-91ee-7b5d2c80691d"), new Guid("da5547d4-0adf-4c80-a7dc-5b94618d5532"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "DrumSet", new Guid("fb604e01-c7f4-4f21-ab45-356b8a3f0487") },
                    { new Guid("2f4bf3d3-285a-4d9a-83d5-8e5f8a0d81fe"), new Guid("7d185505-f396-4704-ac5e-2203f86a380a"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Keyboard", new Guid("cc6cfaac-85d1-4a22-b896-675530cb9eff") },
                    { new Guid("2ff72c84-7868-4be6-88f7-020ebe13c098"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "DigitalPiano", new Guid("5c47daa5-55a4-4a32-b54f-abcb7b5cd42e") },
                    { new Guid("3648b38b-5bb9-45e8-938f-b96205ca26cb"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "AcousticGuitar", new Guid("dd07e372-5c9d-4502-a0ee-46525e8a5247") },
                    { new Guid("382a2401-708b-4a45-9821-11c6566992f5"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "AcousticGuitar", new Guid("88a8f184-a8e0-462c-bdcf-583ea7acc695") },
                    { new Guid("3de7fdae-0eae-49ba-8cae-254a69476259"), new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Cello", new Guid("3d9eda6a-5893-4fc3-a872-7a0b2c2f8cc9") },
                    { new Guid("3e9a8a7f-e7c5-40d2-b14e-9271c9fd55dc"), new Guid("da5547d4-0adf-4c80-a7dc-5b94618d5532"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Saxophone", new Guid("9b815cd5-192c-49c5-bfee-9d48d6ee95dc") },
                    { new Guid("4092f2fa-b2cb-487b-a7cf-aa1f8bf67fd3"), new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "DrumSet", new Guid("21bda159-f948-48d0-b047-f458f0cf311a") },
                    { new Guid("41f20b0a-f719-4226-9168-5df0775bd010"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Saxophone", new Guid("a179b06d-f731-46f0-aa45-ca4808be2ffe") },
                    { new Guid("4451adbf-322c-4f83-af83-7eb5aee06591"), new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "ElectricGuitar", new Guid("af28e4a8-9a43-44c6-9f97-61df8604fccc") },
                    { new Guid("453c9f48-a816-4ccb-bd1c-be623719a8d7"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "ElectricGuitar", new Guid("c2eb7c2e-1c61-42e4-ac98-20606a897f84") },
                    { new Guid("463dac3d-2380-42d2-bd5f-ddbcb5f8314f"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Saxophone", new Guid("cd8d1372-670d-4c9b-aadc-1365fc5b0c62") },
                    { new Guid("47588780-1a13-4041-a8b1-8279788148df"), new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"), "The Football Is Good For Training And Recreational Purposes", "BassGuitar", new Guid("dd07e372-5c9d-4502-a0ee-46525e8a5247") },
                    { new Guid("48807082-0d04-47e0-910c-dcd26e696595"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "ElectricGuitar", new Guid("66c8b94b-c8fd-4a5c-b15b-5d8748d3a31a") },
                    { new Guid("4ad63e18-7ad9-4534-9459-65f58a63ebc7"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "AcousticGuitar", new Guid("21bda159-f948-48d0-b047-f458f0cf311a") },
                    { new Guid("4d7e3353-1316-41af-9a60-3bd771b20bbf"), new Guid("f39c349b-1119-4a1d-bc63-8c9848068051"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "DigitalPiano", new Guid("88a8f184-a8e0-462c-bdcf-583ea7acc695") },
                    { new Guid("4dbc7c6c-a404-48da-95a0-4aab5f6ebe45"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "The Football Is Good For Training And Recreational Purposes", "Keyboard", new Guid("82612713-45b1-47d9-9d4b-07c61d483006") },
                    { new Guid("4f47eec4-5e5c-4624-900f-c4eaf91c68fc"), new Guid("da5547d4-0adf-4c80-a7dc-5b94618d5532"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "BassGuitar", new Guid("054c7fc1-38b4-4304-b974-5218b0510d7c") },
                    { new Guid("51eb8fdc-158f-4d73-b916-54507735fe5b"), new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Cello", new Guid("d0884778-b211-415a-a7db-c8a2ead8a861") },
                    { new Guid("527449fa-e2f8-403f-b9e7-ea687b554fb3"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "The Football Is Good For Training And Recreational Purposes", "Cello", new Guid("af28e4a8-9a43-44c6-9f97-61df8604fccc") },
                    { new Guid("557566c3-41ad-4c8f-86be-0212242daf5e"), new Guid("da5547d4-0adf-4c80-a7dc-5b94618d5532"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Keyboard", new Guid("03045a2a-10b1-477d-a4ef-ef7f190c91f2") },
                    { new Guid("592b93a7-c6b9-4eb9-ac79-71198659337d"), new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Keyboard", new Guid("1a673745-22a6-4bd7-88c0-3fcf61dfa889") },
                    { new Guid("595ab5d7-57de-4aed-b689-9dd767f963d9"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "ElectricGuitar", new Guid("a6ef265f-3895-45bf-ac25-792dc3a1344f") },
                    { new Guid("5af3bacd-d76b-4f49-9db3-451ef2b4d1a9"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "DigitalPiano", new Guid("2d31ac0c-6505-4309-91f2-2fb09224d571") },
                    { new Guid("5d4df7b0-9863-42cb-bdb3-59282b163489"), new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "BassGuitar", new Guid("c2eb7c2e-1c61-42e4-ac98-20606a897f84") },
                    { new Guid("5db7a796-00d2-4d9e-9354-375ce6d065d2"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "BassGuitar", new Guid("f11542ea-d390-4930-b710-a43379c04c07") },
                    { new Guid("5f3de39b-12c6-49a5-946a-91dd2e84239c"), new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "AcousticGuitar", new Guid("03045a2a-10b1-477d-a4ef-ef7f190c91f2") },
                    { new Guid("608ca1ad-132d-47fe-adfa-847f73f5c552"), new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Saxophone", new Guid("abcc1531-6f47-4397-81f6-876d3e2d3365") },
                    { new Guid("6161223c-4d0d-4979-800f-0ea15369ec80"), new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Flute", new Guid("481da6a2-6255-418a-87f0-568e3410f294") },
                    { new Guid("648215c3-0e26-4a32-a540-94a590a3e027"), new Guid("f39c349b-1119-4a1d-bc63-8c9848068051"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "ElectricGuitar", new Guid("abcc1531-6f47-4397-81f6-876d3e2d3365") },
                    { new Guid("64ccf43b-852c-439c-bc0c-82f57b13a5ed"), new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Cello", new Guid("4d4afe26-d71d-474d-8e37-496fc12807c1") },
                    { new Guid("679bd7e0-0a8c-4a23-a5df-cd98dcae32e3"), new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Violin", new Guid("1a673745-22a6-4bd7-88c0-3fcf61dfa889") },
                    { new Guid("681d58c6-da2f-4aa4-8474-a04c5a06a9ff"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Violin", new Guid("2669a37a-a304-485e-9ca8-d9160bffe06e") },
                    { new Guid("683a9559-de24-48a5-9bf7-3b50fc47090e"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Saxophone", new Guid("21bda159-f948-48d0-b047-f458f0cf311a") },
                    { new Guid("68dbcc4d-10a8-4e13-ba66-c83da3cb0cf7"), new Guid("f39c349b-1119-4a1d-bc63-8c9848068051"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Cello", new Guid("481da6a2-6255-418a-87f0-568e3410f294") },
                    { new Guid("7308e139-e967-44d7-8372-1a64f3c260da"), new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Saxophone", new Guid("a6ef265f-3895-45bf-ac25-792dc3a1344f") },
                    { new Guid("75042045-151a-4538-b881-1046f5d5aa86"), new Guid("da5547d4-0adf-4c80-a7dc-5b94618d5532"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Keyboard", new Guid("4d4afe26-d71d-474d-8e37-496fc12807c1") },
                    { new Guid("7529cf35-37f3-4288-aea0-46deca3380ae"), new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Keyboard", new Guid("f11542ea-d390-4930-b710-a43379c04c07") },
                    { new Guid("78a79f64-03d7-4273-bd97-9a358049748d"), new Guid("da5547d4-0adf-4c80-a7dc-5b94618d5532"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "DrumSet", new Guid("5301b249-14b0-4681-917c-ff4f2703a3e4") },
                    { new Guid("7a27681f-5b60-4758-8f5d-0a67c8857ef4"), new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Flute", new Guid("21bda159-f948-48d0-b047-f458f0cf311a") },
                    { new Guid("7a6faa96-c252-4595-b0f8-23e17698a47d"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "AcousticGuitar", new Guid("b0be6e91-5584-42a1-b71e-6c4fab23703c") },
                    { new Guid("7c11c86b-ad9d-48f6-b0d6-5683d803f18f"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Keyboard", new Guid("82612713-45b1-47d9-9d4b-07c61d483006") },
                    { new Guid("7c5835de-3bf2-4920-90d2-277122b31a59"), new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Saxophone", new Guid("da7736b1-e809-4736-858c-7f25fdf08d29") },
                    { new Guid("7db0a14c-c484-4e5d-8901-10483620baf8"), new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Flute", new Guid("2669a37a-a304-485e-9ca8-d9160bffe06e") },
                    { new Guid("8117ea9b-c556-41a2-9667-a54044224daf"), new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Violin", new Guid("03045a2a-10b1-477d-a4ef-ef7f190c91f2") },
                    { new Guid("8256ddf9-b079-4162-9dbb-eb437078df97"), new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Cello", new Guid("7a45dda1-04e7-405c-afbf-a14580e98517") },
                    { new Guid("82d36fc0-f0c5-46d2-a44f-47604a52c7d8"), new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "AcousticGuitar", new Guid("c2eb7c2e-1c61-42e4-ac98-20606a897f84") },
                    { new Guid("83795629-e88d-446a-99c9-f9a20144dc09"), new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Cello", new Guid("da7736b1-e809-4736-858c-7f25fdf08d29") },
                    { new Guid("855f813c-94c7-4b36-a1b5-a0a8ae969b4b"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "DrumSet", new Guid("7a45dda1-04e7-405c-afbf-a14580e98517") },
                    { new Guid("86de4902-ce1b-4e80-b29e-62e569fbc23a"), new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"), "The Football Is Good For Training And Recreational Purposes", "Violin", new Guid("88645c3d-f762-4f27-8c29-a4ec72fb57a7") },
                    { new Guid("88125c3d-cb41-4fa1-9e60-d126430a95d8"), new Guid("7d185505-f396-4704-ac5e-2203f86a380a"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Violin", new Guid("66c8b94b-c8fd-4a5c-b15b-5d8748d3a31a") },
                    { new Guid("883e3115-5257-409a-9bfa-b12146e79f0f"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "The Football Is Good For Training And Recreational Purposes", "BassGuitar", new Guid("5c47daa5-55a4-4a32-b54f-abcb7b5cd42e") },
                    { new Guid("8840ab9b-c96b-4681-b9af-7096e62a4f1b"), new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "DrumSet", new Guid("8a9425ee-8af9-4e0c-bddc-f9d18dd2c26e") },
                    { new Guid("8b4ca05d-d01a-4931-9fb4-a87e8a3480e6"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Cello", new Guid("39e92326-a02d-42eb-9ebc-b470d296cf3a") },
                    { new Guid("8fba67cf-0756-4a0c-a77e-bd53fc292a71"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Violin", new Guid("88645c3d-f762-4f27-8c29-a4ec72fb57a7") },
                    { new Guid("901a7ff4-6885-40a5-b149-efa0327f1287"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "DrumSet", new Guid("603af906-25f9-4209-b20a-b0417119dca1") },
                    { new Guid("908f53d0-8523-4fcd-af25-2eb51b074873"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "BassGuitar", new Guid("7a45dda1-04e7-405c-afbf-a14580e98517") },
                    { new Guid("90faa667-4dba-4d3f-ae1f-ea7154417bf2"), new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Cello", new Guid("ba5dcec5-ca83-402f-971d-e841b3f0ef40") },
                    { new Guid("922f1719-248b-4a19-ae62-cf0c56c2595f"), new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "BassGuitar", new Guid("af28e4a8-9a43-44c6-9f97-61df8604fccc") },
                    { new Guid("926bba12-baeb-4f73-848f-b953d590c6a0"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Saxophone", new Guid("47f12374-c031-48f7-941b-555c461a174d") },
                    { new Guid("93fb1db0-23cc-4002-a665-7f646566cb45"), new Guid("da5547d4-0adf-4c80-a7dc-5b94618d5532"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "AcousticGuitar", new Guid("481da6a2-6255-418a-87f0-568e3410f294") },
                    { new Guid("943d1227-74cc-40af-8136-21c87fda9211"), new Guid("da5547d4-0adf-4c80-a7dc-5b94618d5532"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Saxophone", new Guid("66c8b94b-c8fd-4a5c-b15b-5d8748d3a31a") },
                    { new Guid("94671ac2-63db-448f-a283-ef5369a17b94"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "DigitalPiano", new Guid("ba5dcec5-ca83-402f-971d-e841b3f0ef40") },
                    { new Guid("9673c4d6-8515-438d-bfeb-d255ddc49f3c"), new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "ElectricGuitar", new Guid("d0884778-b211-415a-a7db-c8a2ead8a861") },
                    { new Guid("9bcc3986-342d-4b0c-bb09-88ab8756ae4b"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "BassGuitar", new Guid("5c47daa5-55a4-4a32-b54f-abcb7b5cd42e") },
                    { new Guid("9db71960-96ab-4036-a161-032cc80168ed"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "BassGuitar", new Guid("88a8f184-a8e0-462c-bdcf-583ea7acc695") },
                    { new Guid("9f5e1fe1-72a7-4210-b160-c33ccce131bb"), new Guid("da5547d4-0adf-4c80-a7dc-5b94618d5532"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Cello", new Guid("983b4282-f914-4543-bccb-2b4eaa316f89") },
                    { new Guid("a2c173cb-2d5a-4170-be18-0963c6333f67"), new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Flute", new Guid("5301b249-14b0-4681-917c-ff4f2703a3e4") },
                    { new Guid("a619c77d-bb94-44da-bd85-2deef006943b"), new Guid("7d185505-f396-4704-ac5e-2203f86a380a"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Violin", new Guid("7a45dda1-04e7-405c-afbf-a14580e98517") },
                    { new Guid("a7577dc2-716f-4fb4-ad74-3f1552c9d924"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Keyboard", new Guid("797a621c-cddd-45fc-9c10-8dc0b23f2bf0") },
                    { new Guid("a8c5a3dd-c65a-4dfc-bcf4-03028ab1f3e8"), new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Cello", new Guid("66c8b94b-c8fd-4a5c-b15b-5d8748d3a31a") },
                    { new Guid("aefce323-7d11-46df-9716-3f0bea399226"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Saxophone", new Guid("ba5dcec5-ca83-402f-971d-e841b3f0ef40") },
                    { new Guid("b03c7c73-68fe-4dcc-9d20-9f53b7dccdf3"), new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "DigitalPiano", new Guid("054c7fc1-38b4-4304-b974-5218b0510d7c") },
                    { new Guid("b1401569-8869-4c73-b3f4-a7a53d53fc45"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "DrumSet", new Guid("1a673745-22a6-4bd7-88c0-3fcf61dfa889") },
                    { new Guid("b2557415-1202-49ab-a18f-b5f8fd001766"), new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Keyboard", new Guid("b1a74265-0a2b-4d04-b2e6-52599520fb6d") },
                    { new Guid("b36fe140-8d10-48e1-bf75-a6fb07335490"), new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Cello", new Guid("b0be6e91-5584-42a1-b71e-6c4fab23703c") },
                    { new Guid("b696743e-e791-4e47-93cb-7b6ad4ec2b04"), new Guid("f39c349b-1119-4a1d-bc63-8c9848068051"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "ElectricGuitar", new Guid("cc6cfaac-85d1-4a22-b896-675530cb9eff") },
                    { new Guid("b77346f7-30cc-4f96-892e-c1260edc66f0"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Keyboard", new Guid("da7736b1-e809-4736-858c-7f25fdf08d29") },
                    { new Guid("b77bd73f-d5a9-45a7-b5a1-51d58160b32b"), new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "AcousticGuitar", new Guid("3d9eda6a-5893-4fc3-a872-7a0b2c2f8cc9") },
                    { new Guid("b8479b55-7b39-4e5b-93af-1e8df6f1f0ac"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Flute", new Guid("cd8d1372-670d-4c9b-aadc-1365fc5b0c62") },
                    { new Guid("b91d3fcf-68e3-4ee0-8d7c-d9d21fffabf6"), new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "ElectricGuitar", new Guid("39e92326-a02d-42eb-9ebc-b470d296cf3a") },
                    { new Guid("b92b155c-2d26-428e-9270-9171dcc40d8c"), new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "AcousticGuitar", new Guid("cc6cfaac-85d1-4a22-b896-675530cb9eff") },
                    { new Guid("ba16cd61-1b69-4b21-9e23-d1dd059668e1"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Cello", new Guid("fb604e01-c7f4-4f21-ab45-356b8a3f0487") },
                    { new Guid("ba244261-e3c4-4815-aa1a-a582fca249e5"), new Guid("7d185505-f396-4704-ac5e-2203f86a380a"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "BassGuitar", new Guid("a179b06d-f731-46f0-aa45-ca4808be2ffe") },
                    { new Guid("ba385a6f-3037-471d-a016-8c79d5eb8fdd"), new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Violin", new Guid("82612713-45b1-47d9-9d4b-07c61d483006") },
                    { new Guid("bc92bd2a-4569-4529-b938-962fd792ed90"), new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "ElectricGuitar", new Guid("39e92326-a02d-42eb-9ebc-b470d296cf3a") },
                    { new Guid("bd1d0e77-00ed-41e8-8fb0-52fb277db56d"), new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "DrumSet", new Guid("fb604e01-c7f4-4f21-ab45-356b8a3f0487") },
                    { new Guid("bda7b6ff-bb40-4631-821b-549319d37f08"), new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "AcousticGuitar", new Guid("797a621c-cddd-45fc-9c10-8dc0b23f2bf0") },
                    { new Guid("bddb44d1-3495-4f10-a904-4bbd1493fb1e"), new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Flute", new Guid("82612713-45b1-47d9-9d4b-07c61d483006") },
                    { new Guid("be609740-4d13-426c-afe1-a038edf3239c"), new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "DigitalPiano", new Guid("47f12374-c031-48f7-941b-555c461a174d") },
                    { new Guid("be7388d4-f3f1-44a0-8922-65f30ef8e874"), new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "BassGuitar", new Guid("5301b249-14b0-4681-917c-ff4f2703a3e4") },
                    { new Guid("c16bd187-9e02-40bb-9af3-2a5046c79e31"), new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "DigitalPiano", new Guid("47f12374-c031-48f7-941b-555c461a174d") },
                    { new Guid("c18c868e-e3a0-484b-8824-379af80b7e9a"), new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "BassGuitar", new Guid("39e92326-a02d-42eb-9ebc-b470d296cf3a") },
                    { new Guid("c383a68d-dbc2-4e0a-a135-ab8a701a2f00"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "ElectricGuitar", new Guid("2669a37a-a304-485e-9ca8-d9160bffe06e") },
                    { new Guid("c4719452-caa9-43ca-a7c0-2348650b412a"), new Guid("f39c349b-1119-4a1d-bc63-8c9848068051"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Cello", new Guid("39e92326-a02d-42eb-9ebc-b470d296cf3a") },
                    { new Guid("c4e74a30-c731-4f8a-bd75-01ddf5379307"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Flute", new Guid("39e92326-a02d-42eb-9ebc-b470d296cf3a") },
                    { new Guid("c562f601-90c0-45d5-b65b-9ed1dcb09de0"), new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "DrumSet", new Guid("797a621c-cddd-45fc-9c10-8dc0b23f2bf0") },
                    { new Guid("c70d64f5-e138-4d8f-ac84-85eb766b0c6c"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "ElectricGuitar", new Guid("01a6bf5a-fae9-4779-a6ed-51cae0221202") },
                    { new Guid("c71c9653-c140-4b29-a528-7af5f5ed52ae"), new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "DrumSet", new Guid("39e97df3-cf4d-41c5-829d-36d03c5602bc") },
                    { new Guid("cc617b2a-7de5-43cf-b140-9ca00a1cf13e"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "BassGuitar", new Guid("9b815cd5-192c-49c5-bfee-9d48d6ee95dc") },
                    { new Guid("cc71efe2-a7d4-435e-af7b-a8a0406c40db"), new Guid("f39c349b-1119-4a1d-bc63-8c9848068051"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Keyboard", new Guid("39e92326-a02d-42eb-9ebc-b470d296cf3a") },
                    { new Guid("cd120cf3-7c1f-488c-80c9-30fe37e8f372"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Keyboard", new Guid("fb604e01-c7f4-4f21-ab45-356b8a3f0487") },
                    { new Guid("cd82aa30-8ece-4a08-84e5-3901f463eab1"), new Guid("7d185505-f396-4704-ac5e-2203f86a380a"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Keyboard", new Guid("797a621c-cddd-45fc-9c10-8dc0b23f2bf0") },
                    { new Guid("ce875541-ac77-4894-b45d-c401b516c2c2"), new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "ElectricGuitar", new Guid("d0884778-b211-415a-a7db-c8a2ead8a861") },
                    { new Guid("d31faf03-92ac-4bf2-8a41-9e88f0f38bc7"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "BassGuitar", new Guid("b6ef5064-91ab-4742-9dfc-d347a9a61122") },
                    { new Guid("d4166a59-fca1-4997-9778-701cb70be736"), new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "ElectricGuitar", new Guid("5301b249-14b0-4681-917c-ff4f2703a3e4") },
                    { new Guid("d4c7bbfc-14cf-4f10-af8b-4c85db6bffb0"), new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "ElectricGuitar", new Guid("82612713-45b1-47d9-9d4b-07c61d483006") },
                    { new Guid("d4f4a61a-dca1-4e0e-b4bb-48e5b9202ffd"), new Guid("da5547d4-0adf-4c80-a7dc-5b94618d5532"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "ElectricGuitar", new Guid("688cf0b2-bdf9-4cda-822b-d787e054fba1") },
                    { new Guid("d7157d6f-b89d-46ba-86ec-8bf8f72baac5"), new Guid("da5547d4-0adf-4c80-a7dc-5b94618d5532"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Keyboard", new Guid("01a6bf5a-fae9-4779-a6ed-51cae0221202") },
                    { new Guid("de3251f4-e18d-4e79-813f-af80679c6fba"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "AcousticGuitar", new Guid("5c47daa5-55a4-4a32-b54f-abcb7b5cd42e") },
                    { new Guid("e08fb8fa-6871-4ccb-a656-efe4913632fb"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "ElectricGuitar", new Guid("47f12374-c031-48f7-941b-555c461a174d") },
                    { new Guid("e16ea172-ebb8-4eb1-8041-4f56d22086bc"), new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "ElectricGuitar", new Guid("a6ef265f-3895-45bf-ac25-792dc3a1344f") },
                    { new Guid("e18ecda4-37e9-4cf7-b690-b6ef8afc7f49"), new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "DrumSet", new Guid("054c7fc1-38b4-4304-b974-5218b0510d7c") },
                    { new Guid("e25ad52c-e2ba-4e89-acef-84b253ae4394"), new Guid("7d185505-f396-4704-ac5e-2203f86a380a"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "AcousticGuitar", new Guid("b1a74265-0a2b-4d04-b2e6-52599520fb6d") },
                    { new Guid("e2fd8007-a6a1-4b14-a266-f707ed1a3d0a"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Saxophone", new Guid("03045a2a-10b1-477d-a4ef-ef7f190c91f2") },
                    { new Guid("e4eb6dd9-5095-46fe-b932-c9ba844b1d27"), new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "AcousticGuitar", new Guid("3d9eda6a-5893-4fc3-a872-7a0b2c2f8cc9") },
                    { new Guid("e660b87f-cffd-46d2-b473-17b5abcb71a0"), new Guid("7d185505-f396-4704-ac5e-2203f86a380a"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Keyboard", new Guid("5f331490-6687-4941-9b79-10b4f80ed4c1") },
                    { new Guid("e686c801-43dc-48c3-a611-cadb4a0e7fd7"), new Guid("f39c349b-1119-4a1d-bc63-8c9848068051"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "ElectricGuitar", new Guid("21bda159-f948-48d0-b047-f458f0cf311a") },
                    { new Guid("ea63b6a3-3142-48fd-ad29-fee2fc74d1c1"), new Guid("7d185505-f396-4704-ac5e-2203f86a380a"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Keyboard", new Guid("39e92326-a02d-42eb-9ebc-b470d296cf3a") },
                    { new Guid("eae3cf11-d06b-455d-8ee4-a68e6ece1376"), new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "BassGuitar", new Guid("82612713-45b1-47d9-9d4b-07c61d483006") },
                    { new Guid("ec27f4e4-9c28-4693-bccb-853d97013312"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "The Football Is Good For Training And Recreational Purposes", "Flute", new Guid("66c8b94b-c8fd-4a5c-b15b-5d8748d3a31a") },
                    { new Guid("ee94cd7d-3508-4b0f-9522-1034d1f1af52"), new Guid("da5547d4-0adf-4c80-a7dc-5b94618d5532"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "DigitalPiano", new Guid("66c8b94b-c8fd-4a5c-b15b-5d8748d3a31a") },
                    { new Guid("f081762f-dfb9-4199-9e3a-1e9532ab3332"), new Guid("f39c349b-1119-4a1d-bc63-8c9848068051"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "DigitalPiano", new Guid("39e97df3-cf4d-41c5-829d-36d03c5602bc") },
                    { new Guid("f13c422f-120e-4525-9c83-d034d9ea19ad"), new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Violin", new Guid("abcc1531-6f47-4397-81f6-876d3e2d3365") },
                    { new Guid("f1d8ec91-4ae5-4e54-9f4b-8b3a9e483abe"), new Guid("7d185505-f396-4704-ac5e-2203f86a380a"), "The Football Is Good For Training And Recreational Purposes", "BassGuitar", new Guid("39e92326-a02d-42eb-9ebc-b470d296cf3a") },
                    { new Guid("f2f00b17-9539-43ca-af97-da5dce03e62a"), new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"), "The Football Is Good For Training And Recreational Purposes", "ElectricGuitar", new Guid("d375201a-048b-4172-acba-2da90145e5b2") },
                    { new Guid("f8d59849-0b47-48bb-88b0-93b67f4e7f89"), new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "DrumSet", new Guid("4d4afe26-d71d-474d-8e37-496fc12807c1") },
                    { new Guid("f9cb88b4-2e8a-40ef-b505-0c3e3b8be5bc"), new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Flute", new Guid("39e97df3-cf4d-41c5-829d-36d03c5602bc") },
                    { new Guid("f9d8ccc2-eee5-4121-b4be-784c9f5c3f73"), new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Keyboard", new Guid("47f12374-c031-48f7-941b-555c461a174d") },
                    { new Guid("fb7d1153-61ad-4b26-87f0-9d8eeb03fefc"), new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "ElectricGuitar", new Guid("82612713-45b1-47d9-9d4b-07c61d483006") }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CountriesId", "CreatedDateTime", "Description", "InstrumentsId", "Price" },
                values: new object[,]
                {
                    { new Guid("0465fd7a-fea2-4295-869c-44dd3ed11ee0"), new Guid("a52ef42c-985e-4ccf-a729-2eee31527a50"), new DateTime(2022, 12, 23, 2, 51, 52, 386, DateTimeKind.Local).AddTicks(5438), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("e4eb6dd9-5095-46fe-b932-c9ba844b1d27"), 662.14m },
                    { new Guid("08ec4530-7ab7-4595-b2f7-3eea41d91aa9"), new Guid("502ecbff-3836-49d3-aa47-4e925967d629"), new DateTime(2022, 9, 11, 21, 1, 40, 580, DateTimeKind.Local).AddTicks(6639), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("eae3cf11-d06b-455d-8ee4-a68e6ece1376"), 931.58m },
                    { new Guid("0ab84ad6-4ba4-4716-82ed-990ee8b8bd52"), new Guid("58b43d19-8ef5-4b41-8bc9-80d47817f3c6"), new DateTime(2022, 6, 28, 7, 28, 28, 427, DateTimeKind.Local).AddTicks(2091), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("cc71efe2-a7d4-435e-af7b-a8a0406c40db"), 891.68m },
                    { new Guid("0bdcc0cc-d6f3-475b-b9fd-27336daed36e"), new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"), new DateTime(2023, 1, 10, 8, 1, 35, 67, DateTimeKind.Local).AddTicks(877), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("ba244261-e3c4-4815-aa1a-a582fca249e5"), 210.18m },
                    { new Guid("0d1676b7-7948-4ce0-b235-eb6ce9080531"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), new DateTime(2023, 3, 14, 1, 21, 55, 851, DateTimeKind.Local).AddTicks(9894), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("82d36fc0-f0c5-46d2-a44f-47604a52c7d8"), 463.31m },
                    { new Guid("0f1045dd-8b2f-4288-a6dd-ebb9aff712b7"), new Guid("476085dd-0fc7-40a4-9448-38d9ddf9efbb"), new DateTime(2023, 2, 8, 23, 30, 3, 418, DateTimeKind.Local).AddTicks(1242), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("1ed11088-1329-4c57-923e-5e9e6c0b38ef"), 785.20m },
                    { new Guid("0f7ad30a-6b89-4ee5-89a8-0e4c55e64e73"), new Guid("94469291-205f-4a03-ae14-a1a69b0f1b49"), new DateTime(2022, 8, 2, 7, 40, 21, 434, DateTimeKind.Local).AddTicks(2872), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("b2557415-1202-49ab-a18f-b5f8fd001766"), 200.11m },
                    { new Guid("11426756-4f26-4145-9afc-44f02ab62138"), new Guid("c32b3369-9e5c-487b-95f9-a521b5970072"), new DateTime(2022, 7, 27, 12, 56, 24, 677, DateTimeKind.Local).AddTicks(700), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("c70d64f5-e138-4d8f-ac84-85eb766b0c6c"), 575.25m },
                    { new Guid("1344b278-8703-4b74-9708-bb48d198cac6"), new Guid("94469291-205f-4a03-ae14-a1a69b0f1b49"), new DateTime(2022, 7, 24, 10, 25, 21, 810, DateTimeKind.Local).AddTicks(6318), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("2ff72c84-7868-4be6-88f7-020ebe13c098"), 934.83m },
                    { new Guid("176255a9-53ed-4767-8b54-6097b3279dd3"), new Guid("476085dd-0fc7-40a4-9448-38d9ddf9efbb"), new DateTime(2022, 10, 14, 5, 26, 41, 112, DateTimeKind.Local).AddTicks(7761), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("8256ddf9-b079-4162-9dbb-eb437078df97"), 499.66m },
                    { new Guid("1a6872fc-d071-47d6-a2c5-4f47a76fef9a"), new Guid("de5ab3d4-bef0-496e-bd40-ba165043f423"), new DateTime(2023, 2, 17, 14, 35, 22, 618, DateTimeKind.Local).AddTicks(5193), "The Football Is Good For Training And Recreational Purposes", new Guid("7c5835de-3bf2-4920-90d2-277122b31a59"), 108.69m },
                    { new Guid("1be5bcac-57a7-4a30-b65f-9ec9d785b276"), new Guid("a52ef42c-985e-4ccf-a729-2eee31527a50"), new DateTime(2022, 9, 23, 16, 27, 19, 397, DateTimeKind.Local).AddTicks(7373), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("d31faf03-92ac-4bf2-8a41-9e88f0f38bc7"), 578.09m },
                    { new Guid("1c1513f0-c003-4d26-8ea5-4832a51c912e"), new Guid("b7da32ed-5444-494f-b2e8-220460bbce1c"), new DateTime(2023, 1, 9, 16, 58, 34, 184, DateTimeKind.Local).AddTicks(9594), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("51eb8fdc-158f-4d73-b916-54507735fe5b"), 516.52m },
                    { new Guid("1cfac13a-9b6e-4b49-9223-3a4bf5a11938"), new Guid("94469291-205f-4a03-ae14-a1a69b0f1b49"), new DateTime(2023, 2, 3, 9, 36, 6, 404, DateTimeKind.Local).AddTicks(6419), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("7a6faa96-c252-4595-b0f8-23e17698a47d"), 353.32m },
                    { new Guid("20c130e6-a8a4-4d06-a7cc-1cec5c6e2544"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), new DateTime(2022, 9, 30, 14, 50, 49, 847, DateTimeKind.Local).AddTicks(6837), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("47588780-1a13-4041-a8b1-8279788148df"), 339.71m },
                    { new Guid("22db2f1f-a3a8-4501-a4fe-b6689eecc31f"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), new DateTime(2022, 8, 28, 12, 11, 6, 693, DateTimeKind.Local).AddTicks(7358), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("f8d59849-0b47-48bb-88b0-93b67f4e7f89"), 746.21m },
                    { new Guid("231be553-2fc1-4c80-9d3a-6c81ef18577f"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), new DateTime(2022, 11, 23, 15, 25, 55, 429, DateTimeKind.Local).AddTicks(9567), "The Football Is Good For Training And Recreational Purposes", new Guid("48807082-0d04-47e0-910c-dcd26e696595"), 144.13m },
                    { new Guid("2769e762-a19a-4133-90b1-d48f918de85c"), new Guid("de5ab3d4-bef0-496e-bd40-ba165043f423"), new DateTime(2023, 1, 26, 4, 14, 51, 280, DateTimeKind.Local).AddTicks(235), "The Football Is Good For Training And Recreational Purposes", new Guid("82d36fc0-f0c5-46d2-a44f-47604a52c7d8"), 113.64m },
                    { new Guid("287ace9f-7870-41e1-9046-5a85bc1a94f0"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), new DateTime(2023, 3, 21, 12, 7, 23, 415, DateTimeKind.Local).AddTicks(7361), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("d4166a59-fca1-4997-9778-701cb70be736"), 741.67m },
                    { new Guid("32ab5730-928e-45d9-abe0-80677c25bbf1"), new Guid("94469291-205f-4a03-ae14-a1a69b0f1b49"), new DateTime(2023, 1, 4, 11, 9, 14, 320, DateTimeKind.Local).AddTicks(4975), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("86de4902-ce1b-4e80-b29e-62e569fbc23a"), 60.75m },
                    { new Guid("3305564b-796f-4f50-8f0d-3332aeb516d4"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), new DateTime(2022, 9, 13, 2, 53, 57, 354, DateTimeKind.Local).AddTicks(780), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("4ad63e18-7ad9-4534-9459-65f58a63ebc7"), 974.84m },
                    { new Guid("3551ccb7-d812-4c8b-9d4b-716478b686d0"), new Guid("94469291-205f-4a03-ae14-a1a69b0f1b49"), new DateTime(2022, 12, 17, 16, 6, 27, 995, DateTimeKind.Local).AddTicks(113), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("4f47eec4-5e5c-4624-900f-c4eaf91c68fc"), 522.48m },
                    { new Guid("361549aa-a68e-4648-8668-5fbf9e846a08"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), new DateTime(2022, 12, 1, 3, 30, 17, 549, DateTimeKind.Local).AddTicks(2490), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("c4e74a30-c731-4f8a-bd75-01ddf5379307"), 116.05m },
                    { new Guid("3c1c31f7-120c-46ea-b04d-c6a78cc3575a"), new Guid("502ecbff-3836-49d3-aa47-4e925967d629"), new DateTime(2022, 9, 23, 15, 45, 14, 193, DateTimeKind.Local).AddTicks(7411), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("48807082-0d04-47e0-910c-dcd26e696595"), 562.51m },
                    { new Guid("42bf2d0f-77bf-492c-adfa-94797adcb668"), new Guid("de5ab3d4-bef0-496e-bd40-ba165043f423"), new DateTime(2023, 4, 29, 0, 42, 13, 892, DateTimeKind.Local).AddTicks(7240), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("d7157d6f-b89d-46ba-86ec-8bf8f72baac5"), 697.27m },
                    { new Guid("45c62d8d-f8dc-4f1d-b49d-ca762c88ba9b"), new Guid("c32b3369-9e5c-487b-95f9-a521b5970072"), new DateTime(2022, 12, 19, 9, 9, 2, 746, DateTimeKind.Local).AddTicks(851), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("b36fe140-8d10-48e1-bf75-a6fb07335490"), 948.66m },
                    { new Guid("49739181-14c6-4dbd-83fe-d818ef8e6a00"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), new DateTime(2023, 2, 25, 20, 50, 20, 929, DateTimeKind.Local).AddTicks(3213), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("f13c422f-120e-4525-9c83-d034d9ea19ad"), 256.99m },
                    { new Guid("4ceb0103-9d9b-4a9b-9b64-4c58e1de32b8"), new Guid("b7da32ed-5444-494f-b2e8-220460bbce1c"), new DateTime(2023, 3, 5, 23, 19, 38, 321, DateTimeKind.Local).AddTicks(99), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("0758d565-7215-4d3c-9b32-59268e854eee"), 642.66m },
                    { new Guid("536887af-f9f6-4f97-8ea3-c3989f563c51"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), new DateTime(2022, 10, 1, 6, 15, 44, 834, DateTimeKind.Local).AddTicks(1601), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("68dbcc4d-10a8-4e13-ba66-c83da3cb0cf7"), 180.61m },
                    { new Guid("53bc01fa-23c3-4a17-8b5a-e36013d68a41"), new Guid("a52ef42c-985e-4ccf-a729-2eee31527a50"), new DateTime(2022, 8, 26, 15, 23, 21, 810, DateTimeKind.Local).AddTicks(8240), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("cc71efe2-a7d4-435e-af7b-a8a0406c40db"), 914.81m },
                    { new Guid("543e9d06-57bc-4a19-9cf9-e148b0fe2736"), new Guid("a52ef42c-985e-4ccf-a729-2eee31527a50"), new DateTime(2023, 5, 7, 21, 40, 52, 920, DateTimeKind.Local).AddTicks(3802), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("4451adbf-322c-4f83-af83-7eb5aee06591"), 440.76m },
                    { new Guid("544d3ecb-3cd2-4d68-9fd2-a4e5f852fd84"), new Guid("a52ef42c-985e-4ccf-a729-2eee31527a50"), new DateTime(2022, 11, 23, 9, 48, 57, 130, DateTimeKind.Local).AddTicks(2443), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("94671ac2-63db-448f-a283-ef5369a17b94"), 117.28m },
                    { new Guid("56985cf2-32fd-412f-8958-5fd27534f378"), new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"), new DateTime(2022, 7, 5, 18, 53, 25, 813, DateTimeKind.Local).AddTicks(3111), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("ea63b6a3-3142-48fd-ad29-fee2fc74d1c1"), 136.30m },
                    { new Guid("589464b9-8ba0-4b3a-81cf-e25efcf5a850"), new Guid("502ecbff-3836-49d3-aa47-4e925967d629"), new DateTime(2023, 4, 11, 21, 32, 40, 47, DateTimeKind.Local).AddTicks(9422), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("b77346f7-30cc-4f96-892e-c1260edc66f0"), 928.42m },
                    { new Guid("5ace0542-8d92-492d-a0e1-4ff0fe5140d0"), new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"), new DateTime(2022, 11, 7, 8, 9, 47, 738, DateTimeKind.Local).AddTicks(5963), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("c16bd187-9e02-40bb-9af3-2a5046c79e31"), 107.30m },
                    { new Guid("5e881dc4-a51c-47d5-8219-982db484934d"), new Guid("1228d3ef-a3c6-4ff9-a405-343cc130cfa1"), new DateTime(2023, 1, 5, 18, 50, 38, 132, DateTimeKind.Local).AddTicks(6928), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("bddb44d1-3495-4f10-a904-4bbd1493fb1e"), 896.42m },
                    { new Guid("5f32497f-27b1-47c7-9a5a-ccca214b02d7"), new Guid("3e556bdc-a3b2-42f2-b127-d39697b301c5"), new DateTime(2022, 12, 17, 7, 29, 23, 628, DateTimeKind.Local).AddTicks(4022), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("167c2104-5884-4ff8-9e55-9bb46b3c1022"), 223.06m },
                    { new Guid("64198121-61fb-4c75-a698-d48445edfc21"), new Guid("b7da32ed-5444-494f-b2e8-220460bbce1c"), new DateTime(2023, 4, 19, 18, 54, 46, 414, DateTimeKind.Local).AddTicks(46), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("94671ac2-63db-448f-a283-ef5369a17b94"), 391.85m },
                    { new Guid("64b4c0b0-8a0a-4eff-898a-a99eda198eec"), new Guid("c32b3369-9e5c-487b-95f9-a521b5970072"), new DateTime(2022, 12, 7, 18, 52, 52, 347, DateTimeKind.Local).AddTicks(5161), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("922f1719-248b-4a19-ae62-cf0c56c2595f"), 193.80m },
                    { new Guid("6670476b-5a0c-427b-9b08-966cc6def3ca"), new Guid("b7da32ed-5444-494f-b2e8-220460bbce1c"), new DateTime(2023, 1, 25, 17, 18, 49, 990, DateTimeKind.Local).AddTicks(8184), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("7a6faa96-c252-4595-b0f8-23e17698a47d"), 418.30m },
                    { new Guid("677c0abd-5ca6-44e6-8f37-3a7df428be52"), new Guid("502ecbff-3836-49d3-aa47-4e925967d629"), new DateTime(2022, 10, 22, 13, 11, 50, 666, DateTimeKind.Local).AddTicks(4674), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("86de4902-ce1b-4e80-b29e-62e569fbc23a"), 475.74m },
                    { new Guid("6a76956d-56bf-47ae-90d0-37e0c9db8e72"), new Guid("94469291-205f-4a03-ae14-a1a69b0f1b49"), new DateTime(2023, 1, 4, 13, 59, 49, 237, DateTimeKind.Local).AddTicks(6772), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("a7577dc2-716f-4fb4-ad74-3f1552c9d924"), 688.29m },
                    { new Guid("74f63bf6-a792-4646-867e-0c6566950110"), new Guid("b14acd1e-8f37-4f2f-b07b-32e9d51fb888"), new DateTime(2023, 5, 25, 13, 53, 48, 587, DateTimeKind.Local).AddTicks(4699), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("e18ecda4-37e9-4cf7-b690-b6ef8afc7f49"), 139.58m },
                    { new Guid("7a2a2b15-f51f-4be2-af7f-3f494a439a1b"), new Guid("94469291-205f-4a03-ae14-a1a69b0f1b49"), new DateTime(2023, 1, 19, 8, 28, 18, 69, DateTimeKind.Local).AddTicks(5094), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("3648b38b-5bb9-45e8-938f-b96205ca26cb"), 365.38m },
                    { new Guid("7a712c23-07f1-4e7e-89e5-d1bcce62acfe"), new Guid("c32b3369-9e5c-487b-95f9-a521b5970072"), new DateTime(2023, 6, 2, 11, 14, 40, 800, DateTimeKind.Local).AddTicks(642), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("7529cf35-37f3-4288-aea0-46deca3380ae"), 693.12m },
                    { new Guid("7c68870c-7582-4a76-b378-0d7ece2aeb5b"), new Guid("476085dd-0fc7-40a4-9448-38d9ddf9efbb"), new DateTime(2022, 7, 10, 20, 1, 26, 90, DateTimeKind.Local).AddTicks(2091), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("7529cf35-37f3-4288-aea0-46deca3380ae"), 250.37m },
                    { new Guid("80a2e3e1-53bb-4a41-bfe9-3a067725db3f"), new Guid("b14acd1e-8f37-4f2f-b07b-32e9d51fb888"), new DateTime(2022, 11, 10, 15, 54, 3, 19, DateTimeKind.Local).AddTicks(7673), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("b77346f7-30cc-4f96-892e-c1260edc66f0"), 327.32m },
                    { new Guid("8475aacf-1c84-487e-a6bd-7220349740d0"), new Guid("476085dd-0fc7-40a4-9448-38d9ddf9efbb"), new DateTime(2022, 9, 4, 5, 26, 8, 390, DateTimeKind.Local).AddTicks(6121), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("4451adbf-322c-4f83-af83-7eb5aee06591"), 755.96m },
                    { new Guid("849125dc-6892-4404-a4df-8afc13259d5f"), new Guid("d36c2368-edf4-42c9-839d-2f650be9f814"), new DateTime(2023, 2, 22, 5, 2, 47, 362, DateTimeKind.Local).AddTicks(2915), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("557566c3-41ad-4c8f-86be-0212242daf5e"), 516.41m },
                    { new Guid("860bba69-541e-4423-85ab-30fe09eaa82b"), new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"), new DateTime(2022, 9, 27, 10, 42, 57, 111, DateTimeKind.Local).AddTicks(4247), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("75042045-151a-4538-b881-1046f5d5aa86"), 100.37m },
                    { new Guid("86a52b8d-22a1-4171-98a5-2f7c9d3f7edf"), new Guid("3e556bdc-a3b2-42f2-b127-d39697b301c5"), new DateTime(2023, 1, 3, 4, 15, 34, 560, DateTimeKind.Local).AddTicks(2934), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("1ed11088-1329-4c57-923e-5e9e6c0b38ef"), 170.75m },
                    { new Guid("88808efb-2c27-4a69-a13e-9fd48a44ee35"), new Guid("1228d3ef-a3c6-4ff9-a405-343cc130cfa1"), new DateTime(2023, 5, 23, 11, 22, 42, 246, DateTimeKind.Local).AddTicks(8489), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("a619c77d-bb94-44da-bd85-2deef006943b"), 82.34m },
                    { new Guid("88df9f16-0b2d-451a-b076-d3191ddf8431"), new Guid("b14acd1e-8f37-4f2f-b07b-32e9d51fb888"), new DateTime(2022, 8, 14, 18, 48, 45, 89, DateTimeKind.Local).AddTicks(1569), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("908f53d0-8523-4fcd-af25-2eb51b074873"), 276.49m },
                    { new Guid("89fde711-9f5a-4a18-b4bf-809be9e7d15c"), new Guid("1228d3ef-a3c6-4ff9-a405-343cc130cfa1"), new DateTime(2022, 12, 12, 19, 22, 25, 496, DateTimeKind.Local).AddTicks(9124), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("c4e74a30-c731-4f8a-bd75-01ddf5379307"), 540.52m },
                    { new Guid("8f93cd17-e01d-409d-bb38-beb32afe4240"), new Guid("502ecbff-3836-49d3-aa47-4e925967d629"), new DateTime(2022, 11, 11, 9, 22, 11, 125, DateTimeKind.Local).AddTicks(1331), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("a619c77d-bb94-44da-bd85-2deef006943b"), 541.47m },
                    { new Guid("8fe46750-1128-4113-aaa3-af2c8b5351c6"), new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"), new DateTime(2022, 7, 11, 23, 37, 28, 667, DateTimeKind.Local).AddTicks(1203), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("0dabe2e3-c79a-4bf5-8a90-8c37e11c49b8"), 562.74m },
                    { new Guid("90f73843-f55c-4835-b757-1156d683c27b"), new Guid("58b43d19-8ef5-4b41-8bc9-80d47817f3c6"), new DateTime(2022, 8, 5, 18, 46, 40, 934, DateTimeKind.Local).AddTicks(2127), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("83795629-e88d-446a-99c9-f9a20144dc09"), 698.87m },
                    { new Guid("914e2db9-5ed2-4fb7-9e87-42ffefec43a7"), new Guid("660ab565-5a88-414f-849c-6b734d34f7a5"), new DateTime(2023, 1, 18, 20, 7, 48, 979, DateTimeKind.Local).AddTicks(4057), "The Football Is Good For Training And Recreational Purposes", new Guid("8b4ca05d-d01a-4931-9fb4-a87e8a3480e6"), 510.16m },
                    { new Guid("941262d5-7f02-432a-bb99-2b89aede7f70"), new Guid("502ecbff-3836-49d3-aa47-4e925967d629"), new DateTime(2023, 1, 23, 10, 45, 22, 981, DateTimeKind.Local).AddTicks(6789), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("ec27f4e4-9c28-4693-bccb-853d97013312"), 154.11m },
                    { new Guid("946f55cc-3541-44b7-85de-450b5d1c7cdf"), new Guid("b7da32ed-5444-494f-b2e8-220460bbce1c"), new DateTime(2023, 1, 18, 16, 36, 3, 119, DateTimeKind.Local).AddTicks(5044), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("f1d8ec91-4ae5-4e54-9f4b-8b3a9e483abe"), 589.72m },
                    { new Guid("94f74311-be03-4819-af14-8ffa9bc2f281"), new Guid("de5ab3d4-bef0-496e-bd40-ba165043f423"), new DateTime(2022, 10, 11, 16, 43, 44, 929, DateTimeKind.Local).AddTicks(9329), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("f081762f-dfb9-4199-9e3a-1e9532ab3332"), 777.35m },
                    { new Guid("a0068d03-ca2a-4ea9-a6e8-094dfbc9abda"), new Guid("a52ef42c-985e-4ccf-a729-2eee31527a50"), new DateTime(2023, 1, 15, 17, 6, 43, 969, DateTimeKind.Local).AddTicks(8395), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("23db640b-dcf7-408b-9444-b83164fe6038"), 627.14m },
                    { new Guid("a026460d-99ac-48ec-96f4-7e5c47b63f60"), new Guid("de5ab3d4-bef0-496e-bd40-ba165043f423"), new DateTime(2022, 8, 11, 21, 23, 35, 258, DateTimeKind.Local).AddTicks(3789), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("a8c5a3dd-c65a-4dfc-bcf4-03028ab1f3e8"), 821.99m },
                    { new Guid("a0c767da-d6ce-4c5c-b839-55c3d5742735"), new Guid("3e556bdc-a3b2-42f2-b127-d39697b301c5"), new DateTime(2022, 12, 24, 6, 8, 3, 859, DateTimeKind.Local).AddTicks(6232), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("1f905643-97cb-4172-9196-0cbf8c16e8c6"), 484.09m },
                    { new Guid("a1a01485-6c5b-43c1-af5d-6cfbaf169885"), new Guid("3e556bdc-a3b2-42f2-b127-d39697b301c5"), new DateTime(2022, 9, 27, 21, 49, 12, 571, DateTimeKind.Local).AddTicks(6043), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("3648b38b-5bb9-45e8-938f-b96205ca26cb"), 919.02m },
                    { new Guid("a473314e-bbda-4a9e-9168-b08eef040bb0"), new Guid("94469291-205f-4a03-ae14-a1a69b0f1b49"), new DateTime(2023, 3, 7, 3, 41, 8, 236, DateTimeKind.Local).AddTicks(4084), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("7308e139-e967-44d7-8372-1a64f3c260da"), 405.89m },
                    { new Guid("a85f8fd2-b719-44f9-a1dd-9fc6455435c9"), new Guid("a52ef42c-985e-4ccf-a729-2eee31527a50"), new DateTime(2022, 7, 20, 22, 37, 45, 890, DateTimeKind.Local).AddTicks(5012), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("a8c5a3dd-c65a-4dfc-bcf4-03028ab1f3e8"), 32.35m },
                    { new Guid("ac266f35-4ce0-4417-a204-cbe2b8f5f22d"), new Guid("660ab565-5a88-414f-849c-6b734d34f7a5"), new DateTime(2023, 4, 14, 17, 17, 15, 214, DateTimeKind.Local).AddTicks(5473), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("c4719452-caa9-43ca-a7c0-2348650b412a"), 478.13m },
                    { new Guid("aeb17e1a-3abb-40a9-826a-95de4f84472c"), new Guid("c32b3369-9e5c-487b-95f9-a521b5970072"), new DateTime(2023, 3, 17, 10, 3, 50, 977, DateTimeKind.Local).AddTicks(8930), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("ba385a6f-3037-471d-a016-8c79d5eb8fdd"), 788.76m },
                    { new Guid("b1431896-a9f8-4cc8-9d66-9a480e486dd0"), new Guid("502ecbff-3836-49d3-aa47-4e925967d629"), new DateTime(2023, 5, 29, 9, 50, 28, 896, DateTimeKind.Local).AddTicks(7367), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("8256ddf9-b079-4162-9dbb-eb437078df97"), 423.37m },
                    { new Guid("b1d2a921-e9cb-4899-ab11-c7a07ee90d57"), new Guid("502ecbff-3836-49d3-aa47-4e925967d629"), new DateTime(2022, 9, 26, 7, 39, 39, 631, DateTimeKind.Local).AddTicks(3292), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("c383a68d-dbc2-4e0a-a135-ab8a701a2f00"), 165.30m },
                    { new Guid("b80d5657-4acd-4c43-bedf-f07ad8f1c831"), new Guid("b7da32ed-5444-494f-b2e8-220460bbce1c"), new DateTime(2022, 6, 13, 13, 22, 32, 426, DateTimeKind.Local).AddTicks(9232), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("e686c801-43dc-48c3-a611-cadb4a0e7fd7"), 724.05m },
                    { new Guid("b94b00f8-c3f5-4e4c-b0a3-44ae5a6a7f91"), new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"), new DateTime(2022, 10, 17, 21, 2, 13, 997, DateTimeKind.Local).AddTicks(8556), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("8b4ca05d-d01a-4931-9fb4-a87e8a3480e6"), 186.85m },
                    { new Guid("ba3b3e5f-a006-442f-8a7a-621ce3c91778"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), new DateTime(2022, 7, 5, 5, 16, 6, 285, DateTimeKind.Local).AddTicks(4690), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("ea63b6a3-3142-48fd-ad29-fee2fc74d1c1"), 224.33m },
                    { new Guid("bbebcda6-5f5d-4aa3-810f-c56ede728121"), new Guid("3e556bdc-a3b2-42f2-b127-d39697b301c5"), new DateTime(2022, 12, 29, 13, 40, 3, 733, DateTimeKind.Local).AddTicks(1620), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("ba244261-e3c4-4815-aa1a-a582fca249e5"), 25.87m },
                    { new Guid("bffd1d8d-76a6-4add-8263-17714303522b"), new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"), new DateTime(2022, 12, 21, 3, 2, 49, 720, DateTimeKind.Local).AddTicks(1469), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("01c2ac5a-5cfe-42d2-8a55-f27e505f5024"), 747.99m },
                    { new Guid("c70e2edd-45e5-4c94-b2c4-f50054c343f9"), new Guid("660ab565-5a88-414f-849c-6b734d34f7a5"), new DateTime(2023, 3, 8, 22, 36, 52, 213, DateTimeKind.Local).AddTicks(3926), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("8256ddf9-b079-4162-9dbb-eb437078df97"), 444.15m },
                    { new Guid("c9c637a1-b60c-496b-a675-f54e3bea3186"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), new DateTime(2022, 9, 16, 5, 45, 54, 384, DateTimeKind.Local).AddTicks(5930), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("01c2ac5a-5cfe-42d2-8a55-f27e505f5024"), 799.29m },
                    { new Guid("ca2a1e80-67dd-4539-ac1a-2e7e00c9ac50"), new Guid("502ecbff-3836-49d3-aa47-4e925967d629"), new DateTime(2023, 2, 20, 18, 56, 28, 992, DateTimeKind.Local).AddTicks(7217), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("8fba67cf-0756-4a0c-a77e-bd53fc292a71"), 58.92m },
                    { new Guid("ca495d39-f13b-4937-b145-90530cb6c5b7"), new Guid("58b43d19-8ef5-4b41-8bc9-80d47817f3c6"), new DateTime(2023, 2, 12, 13, 23, 3, 760, DateTimeKind.Local).AddTicks(4805), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("b696743e-e791-4e47-93cb-7b6ad4ec2b04"), 191.10m },
                    { new Guid("ca939ca0-b504-4d13-ae3d-15e6af1c7834"), new Guid("c32b3369-9e5c-487b-95f9-a521b5970072"), new DateTime(2022, 11, 29, 14, 11, 36, 500, DateTimeKind.Local).AddTicks(5667), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("d7157d6f-b89d-46ba-86ec-8bf8f72baac5"), 483.09m },
                    { new Guid("cadd208a-a235-464d-b311-da933237d668"), new Guid("58b43d19-8ef5-4b41-8bc9-80d47817f3c6"), new DateTime(2023, 5, 18, 6, 38, 0, 670, DateTimeKind.Local).AddTicks(5252), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("ee94cd7d-3508-4b0f-9522-1034d1f1af52"), 988.68m },
                    { new Guid("cadfbc01-bfd1-4832-8103-f9e14e61f180"), new Guid("94469291-205f-4a03-ae14-a1a69b0f1b49"), new DateTime(2023, 1, 26, 11, 55, 33, 752, DateTimeKind.Local).AddTicks(7473), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("de3251f4-e18d-4e79-813f-af80679c6fba"), 707.93m },
                    { new Guid("d75aeeb0-c0c8-422c-95d0-56ba82b6e18d"), new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"), new DateTime(2023, 2, 6, 19, 7, 59, 95, DateTimeKind.Local).AddTicks(6112), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("8256ddf9-b079-4162-9dbb-eb437078df97"), 671.90m },
                    { new Guid("da67f542-5a4f-42ff-88cd-634d82229a4e"), new Guid("b7da32ed-5444-494f-b2e8-220460bbce1c"), new DateTime(2022, 8, 26, 20, 45, 2, 969, DateTimeKind.Local).AddTicks(927), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("bc92bd2a-4569-4529-b938-962fd792ed90"), 265.54m },
                    { new Guid("dc611e4a-9565-45f9-a9d1-ab9727ec52e5"), new Guid("660ab565-5a88-414f-849c-6b734d34f7a5"), new DateTime(2022, 10, 14, 7, 14, 18, 926, DateTimeKind.Local).AddTicks(8777), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("e686c801-43dc-48c3-a611-cadb4a0e7fd7"), 926.46m },
                    { new Guid("dca4f826-567c-4336-aeb3-7a71a7ee1f14"), new Guid("b7da32ed-5444-494f-b2e8-220460bbce1c"), new DateTime(2022, 11, 27, 6, 6, 22, 872, DateTimeKind.Local).AddTicks(9600), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("d4166a59-fca1-4997-9778-701cb70be736"), 258.44m },
                    { new Guid("ddb76c85-838d-46a1-b3ed-6f501c13a372"), new Guid("d36c2368-edf4-42c9-839d-2f650be9f814"), new DateTime(2022, 8, 7, 6, 52, 55, 58, DateTimeKind.Local).AddTicks(4750), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("68dbcc4d-10a8-4e13-ba66-c83da3cb0cf7"), 259.36m },
                    { new Guid("e4ea1e37-bc4d-411f-a925-d854898416b0"), new Guid("b14acd1e-8f37-4f2f-b07b-32e9d51fb888"), new DateTime(2022, 11, 20, 7, 31, 47, 249, DateTimeKind.Local).AddTicks(5194), "The Football Is Good For Training And Recreational Purposes", new Guid("bddb44d1-3495-4f10-a904-4bbd1493fb1e"), 584.22m },
                    { new Guid("eab58b2d-04b5-4caf-a7da-6f6a9cf5532b"), new Guid("94469291-205f-4a03-ae14-a1a69b0f1b49"), new DateTime(2022, 9, 29, 1, 19, 51, 682, DateTimeKind.Local).AddTicks(8083), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("4d7e3353-1316-41af-9a60-3bd771b20bbf"), 895.36m },
                    { new Guid("f14fe918-be86-46e0-8baa-0e4fc4112a2b"), new Guid("c32b3369-9e5c-487b-95f9-a521b5970072"), new DateTime(2022, 9, 24, 5, 19, 29, 225, DateTimeKind.Local).AddTicks(9525), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("5d4df7b0-9863-42cb-bdb3-59282b163489"), 326.27m },
                    { new Guid("f2507dfd-c0be-4d60-82b9-655b34fee872"), new Guid("b7da32ed-5444-494f-b2e8-220460bbce1c"), new DateTime(2023, 4, 13, 12, 55, 54, 153, DateTimeKind.Local).AddTicks(2443), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("01c2ac5a-5cfe-42d2-8a55-f27e505f5024"), 233.61m },
                    { new Guid("f2ed1ab5-4077-4a51-abea-93688e184330"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), new DateTime(2022, 10, 22, 8, 28, 52, 823, DateTimeKind.Local).AddTicks(524), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("b36fe140-8d10-48e1-bf75-a6fb07335490"), 901.85m },
                    { new Guid("f32da321-c5e3-4cab-ae9d-f89fe00f22ac"), new Guid("b7da32ed-5444-494f-b2e8-220460bbce1c"), new DateTime(2023, 6, 1, 3, 49, 15, 237, DateTimeKind.Local).AddTicks(9713), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("1ba16455-2864-4957-86a3-0adfb117a160"), 689.36m },
                    { new Guid("f38e6333-f9c6-49dc-b0f9-09a9f02c25ac"), new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"), new DateTime(2023, 6, 5, 8, 9, 28, 233, DateTimeKind.Local).AddTicks(3820), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("7c11c86b-ad9d-48f6-b0d6-5683d803f18f"), 527.33m },
                    { new Guid("f41690f7-fa86-4ad5-8bd3-1dd9e744a0d6"), new Guid("660ab565-5a88-414f-849c-6b734d34f7a5"), new DateTime(2022, 8, 31, 18, 18, 54, 337, DateTimeKind.Local).AddTicks(6257), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("64ccf43b-852c-439c-bc0c-82f57b13a5ed"), 490.81m },
                    { new Guid("f8cf504d-cd61-4bd7-8777-f3d7e99ddf44"), new Guid("3e556bdc-a3b2-42f2-b127-d39697b301c5"), new DateTime(2022, 6, 17, 11, 36, 1, 504, DateTimeKind.Local).AddTicks(2672), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("4d7e3353-1316-41af-9a60-3bd771b20bbf"), 821.99m },
                    { new Guid("fb675e2c-b327-4d7b-bf6f-dd4359573210"), new Guid("502ecbff-3836-49d3-aa47-4e925967d629"), new DateTime(2023, 2, 19, 4, 7, 40, 289, DateTimeKind.Local).AddTicks(6072), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("d4166a59-fca1-4997-9778-701cb70be736"), 194.92m },
                    { new Guid("fbf81ea1-6007-4831-8ff8-34b4c7a0d3b0"), new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"), new DateTime(2023, 5, 4, 19, 3, 33, 983, DateTimeKind.Local).AddTicks(3719), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("9f5e1fe1-72a7-4210-b160-c33ccce131bb"), 318.70m },
                    { new Guid("fd4d9309-3ce8-4570-95ca-90569c995028"), new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"), new DateTime(2022, 9, 9, 10, 24, 30, 271, DateTimeKind.Local).AddTicks(6567), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("a2c173cb-2d5a-4170-be18-0963c6333f67"), 146.49m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("000a5eaa-c997-4217-9707-3fdafd74fded"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("00ad7d26-1e70-4a52-b6a1-544070d48b88"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("0123dbe7-f259-4d00-8528-1be597161fe6"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("0296b6aa-748d-4454-8866-23567a3ef665"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("0384d92b-8231-48d9-99c2-eee00b915908"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("078367cc-01fa-4a1e-a133-b294c5661130"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("0f56ffdc-2f56-4763-b669-9e6fb972d0c5"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("0ff48e12-53d2-4c50-9820-4b53ae0f473a"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("1290c708-de76-4858-b2d2-5560bc7e8807"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("1bb1d373-2f3f-4ad2-8764-22eded39d359"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("25f3b37d-3ca2-4df2-baee-b86a092b244c"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("274d2d08-d523-47a1-acdc-32ed80d4c184"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("28149c1c-e0b5-469e-91ee-7b5d2c80691d"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("2f4bf3d3-285a-4d9a-83d5-8e5f8a0d81fe"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("382a2401-708b-4a45-9821-11c6566992f5"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("3de7fdae-0eae-49ba-8cae-254a69476259"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("3e9a8a7f-e7c5-40d2-b14e-9271c9fd55dc"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("4092f2fa-b2cb-487b-a7cf-aa1f8bf67fd3"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("41f20b0a-f719-4226-9168-5df0775bd010"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("453c9f48-a816-4ccb-bd1c-be623719a8d7"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("463dac3d-2380-42d2-bd5f-ddbcb5f8314f"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("4dbc7c6c-a404-48da-95a0-4aab5f6ebe45"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("527449fa-e2f8-403f-b9e7-ea687b554fb3"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("592b93a7-c6b9-4eb9-ac79-71198659337d"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("595ab5d7-57de-4aed-b689-9dd767f963d9"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("5af3bacd-d76b-4f49-9db3-451ef2b4d1a9"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("5db7a796-00d2-4d9e-9354-375ce6d065d2"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("5f3de39b-12c6-49a5-946a-91dd2e84239c"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("608ca1ad-132d-47fe-adfa-847f73f5c552"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("6161223c-4d0d-4979-800f-0ea15369ec80"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("648215c3-0e26-4a32-a540-94a590a3e027"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("679bd7e0-0a8c-4a23-a5df-cd98dcae32e3"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("681d58c6-da2f-4aa4-8474-a04c5a06a9ff"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("683a9559-de24-48a5-9bf7-3b50fc47090e"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("78a79f64-03d7-4273-bd97-9a358049748d"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("7a27681f-5b60-4758-8f5d-0a67c8857ef4"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("7db0a14c-c484-4e5d-8901-10483620baf8"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("8117ea9b-c556-41a2-9667-a54044224daf"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("855f813c-94c7-4b36-a1b5-a0a8ae969b4b"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("88125c3d-cb41-4fa1-9e60-d126430a95d8"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("883e3115-5257-409a-9bfa-b12146e79f0f"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("8840ab9b-c96b-4681-b9af-7096e62a4f1b"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("901a7ff4-6885-40a5-b149-efa0327f1287"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("90faa667-4dba-4d3f-ae1f-ea7154417bf2"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("926bba12-baeb-4f73-848f-b953d590c6a0"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("93fb1db0-23cc-4002-a665-7f646566cb45"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("943d1227-74cc-40af-8136-21c87fda9211"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("9673c4d6-8515-438d-bfeb-d255ddc49f3c"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("9bcc3986-342d-4b0c-bb09-88ab8756ae4b"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("9db71960-96ab-4036-a161-032cc80168ed"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("aefce323-7d11-46df-9716-3f0bea399226"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("b03c7c73-68fe-4dcc-9d20-9f53b7dccdf3"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("b1401569-8869-4c73-b3f4-a7a53d53fc45"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("b77bd73f-d5a9-45a7-b5a1-51d58160b32b"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("b8479b55-7b39-4e5b-93af-1e8df6f1f0ac"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("b91d3fcf-68e3-4ee0-8d7c-d9d21fffabf6"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("b92b155c-2d26-428e-9270-9171dcc40d8c"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("ba16cd61-1b69-4b21-9e23-d1dd059668e1"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("bd1d0e77-00ed-41e8-8fb0-52fb277db56d"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("bda7b6ff-bb40-4631-821b-549319d37f08"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("be609740-4d13-426c-afe1-a038edf3239c"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("be7388d4-f3f1-44a0-8922-65f30ef8e874"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c18c868e-e3a0-484b-8824-379af80b7e9a"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c562f601-90c0-45d5-b65b-9ed1dcb09de0"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c71c9653-c140-4b29-a528-7af5f5ed52ae"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("cc617b2a-7de5-43cf-b140-9ca00a1cf13e"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("cd120cf3-7c1f-488c-80c9-30fe37e8f372"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("cd82aa30-8ece-4a08-84e5-3901f463eab1"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("ce875541-ac77-4894-b45d-c401b516c2c2"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("d4c7bbfc-14cf-4f10-af8b-4c85db6bffb0"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("d4f4a61a-dca1-4e0e-b4bb-48e5b9202ffd"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("e08fb8fa-6871-4ccb-a656-efe4913632fb"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("e16ea172-ebb8-4eb1-8041-4f56d22086bc"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("e25ad52c-e2ba-4e89-acef-84b253ae4394"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("e2fd8007-a6a1-4b14-a266-f707ed1a3d0a"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("e660b87f-cffd-46d2-b473-17b5abcb71a0"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("f2f00b17-9539-43ca-af97-da5dce03e62a"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("f9cb88b4-2e8a-40ef-b505-0c3e3b8be5bc"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("f9d8ccc2-eee5-4121-b4be-784c9f5c3f73"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("fb7d1153-61ad-4b26-87f0-9d8eeb03fefc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0465fd7a-fea2-4295-869c-44dd3ed11ee0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("08ec4530-7ab7-4595-b2f7-3eea41d91aa9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0ab84ad6-4ba4-4716-82ed-990ee8b8bd52"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0bdcc0cc-d6f3-475b-b9fd-27336daed36e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0d1676b7-7948-4ce0-b235-eb6ce9080531"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0f1045dd-8b2f-4288-a6dd-ebb9aff712b7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0f7ad30a-6b89-4ee5-89a8-0e4c55e64e73"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("11426756-4f26-4145-9afc-44f02ab62138"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1344b278-8703-4b74-9708-bb48d198cac6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("176255a9-53ed-4767-8b54-6097b3279dd3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1a6872fc-d071-47d6-a2c5-4f47a76fef9a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1be5bcac-57a7-4a30-b65f-9ec9d785b276"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1c1513f0-c003-4d26-8ea5-4832a51c912e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1cfac13a-9b6e-4b49-9223-3a4bf5a11938"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("20c130e6-a8a4-4d06-a7cc-1cec5c6e2544"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("22db2f1f-a3a8-4501-a4fe-b6689eecc31f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("231be553-2fc1-4c80-9d3a-6c81ef18577f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2769e762-a19a-4133-90b1-d48f918de85c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("287ace9f-7870-41e1-9046-5a85bc1a94f0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("32ab5730-928e-45d9-abe0-80677c25bbf1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3305564b-796f-4f50-8f0d-3332aeb516d4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3551ccb7-d812-4c8b-9d4b-716478b686d0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("361549aa-a68e-4648-8668-5fbf9e846a08"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3c1c31f7-120c-46ea-b04d-c6a78cc3575a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("42bf2d0f-77bf-492c-adfa-94797adcb668"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("45c62d8d-f8dc-4f1d-b49d-ca762c88ba9b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("49739181-14c6-4dbd-83fe-d818ef8e6a00"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4ceb0103-9d9b-4a9b-9b64-4c58e1de32b8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("536887af-f9f6-4f97-8ea3-c3989f563c51"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("53bc01fa-23c3-4a17-8b5a-e36013d68a41"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("543e9d06-57bc-4a19-9cf9-e148b0fe2736"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("544d3ecb-3cd2-4d68-9fd2-a4e5f852fd84"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("56985cf2-32fd-412f-8958-5fd27534f378"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("589464b9-8ba0-4b3a-81cf-e25efcf5a850"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5ace0542-8d92-492d-a0e1-4ff0fe5140d0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5e881dc4-a51c-47d5-8219-982db484934d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5f32497f-27b1-47c7-9a5a-ccca214b02d7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("64198121-61fb-4c75-a698-d48445edfc21"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("64b4c0b0-8a0a-4eff-898a-a99eda198eec"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6670476b-5a0c-427b-9b08-966cc6def3ca"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("677c0abd-5ca6-44e6-8f37-3a7df428be52"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6a76956d-56bf-47ae-90d0-37e0c9db8e72"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("74f63bf6-a792-4646-867e-0c6566950110"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7a2a2b15-f51f-4be2-af7f-3f494a439a1b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7a712c23-07f1-4e7e-89e5-d1bcce62acfe"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7c68870c-7582-4a76-b378-0d7ece2aeb5b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("80a2e3e1-53bb-4a41-bfe9-3a067725db3f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8475aacf-1c84-487e-a6bd-7220349740d0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("849125dc-6892-4404-a4df-8afc13259d5f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("860bba69-541e-4423-85ab-30fe09eaa82b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("86a52b8d-22a1-4171-98a5-2f7c9d3f7edf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("88808efb-2c27-4a69-a13e-9fd48a44ee35"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("88df9f16-0b2d-451a-b076-d3191ddf8431"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("89fde711-9f5a-4a18-b4bf-809be9e7d15c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8f93cd17-e01d-409d-bb38-beb32afe4240"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8fe46750-1128-4113-aaa3-af2c8b5351c6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("90f73843-f55c-4835-b757-1156d683c27b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("914e2db9-5ed2-4fb7-9e87-42ffefec43a7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("941262d5-7f02-432a-bb99-2b89aede7f70"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("946f55cc-3541-44b7-85de-450b5d1c7cdf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("94f74311-be03-4819-af14-8ffa9bc2f281"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a0068d03-ca2a-4ea9-a6e8-094dfbc9abda"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a026460d-99ac-48ec-96f4-7e5c47b63f60"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a0c767da-d6ce-4c5c-b839-55c3d5742735"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a1a01485-6c5b-43c1-af5d-6cfbaf169885"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a473314e-bbda-4a9e-9168-b08eef040bb0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a85f8fd2-b719-44f9-a1dd-9fc6455435c9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ac266f35-4ce0-4417-a204-cbe2b8f5f22d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("aeb17e1a-3abb-40a9-826a-95de4f84472c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b1431896-a9f8-4cc8-9d66-9a480e486dd0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b1d2a921-e9cb-4899-ab11-c7a07ee90d57"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b80d5657-4acd-4c43-bedf-f07ad8f1c831"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b94b00f8-c3f5-4e4c-b0a3-44ae5a6a7f91"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ba3b3e5f-a006-442f-8a7a-621ce3c91778"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bbebcda6-5f5d-4aa3-810f-c56ede728121"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bffd1d8d-76a6-4add-8263-17714303522b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c70e2edd-45e5-4c94-b2c4-f50054c343f9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c9c637a1-b60c-496b-a675-f54e3bea3186"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ca2a1e80-67dd-4539-ac1a-2e7e00c9ac50"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ca495d39-f13b-4937-b145-90530cb6c5b7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ca939ca0-b504-4d13-ae3d-15e6af1c7834"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cadd208a-a235-464d-b311-da933237d668"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cadfbc01-bfd1-4832-8103-f9e14e61f180"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d75aeeb0-c0c8-422c-95d0-56ba82b6e18d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("da67f542-5a4f-42ff-88cd-634d82229a4e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("dc611e4a-9565-45f9-a9d1-ab9727ec52e5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("dca4f826-567c-4336-aeb3-7a71a7ee1f14"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ddb76c85-838d-46a1-b3ed-6f501c13a372"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e4ea1e37-bc4d-411f-a925-d854898416b0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("eab58b2d-04b5-4caf-a7da-6f6a9cf5532b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f14fe918-be86-46e0-8baa-0e4fc4112a2b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f2507dfd-c0be-4d60-82b9-655b34fee872"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f2ed1ab5-4077-4a51-abea-93688e184330"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f32da321-c5e3-4cab-ae9d-f89fe00f22ac"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f38e6333-f9c6-49dc-b0f9-09a9f02c25ac"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f41690f7-fa86-4ad5-8bd3-1dd9e744a0d6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f8cf504d-cd61-4bd7-8777-f3d7e99ddf44"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fb675e2c-b327-4d7b-bf6f-dd4359573210"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fbf81ea1-6007-4831-8ff8-34b4c7a0d3b0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fd4d9309-3ce8-4570-95ca-90569c995028"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("254a85a8-d2be-4bcd-a9c8-c8c8599bfc4c"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("4e8070d9-edbe-4681-870f-e9f45bc11a1f"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("7bd1eb0c-386b-472e-bfc8-c84052f4a135"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("7ebf7dc0-0b6e-4e37-a253-052e6b1c6849"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("890f74cc-152d-43fe-83b8-f83f37558303"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b7da32ed-5444-494f-b2e8-220460bbce1c"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("01c2ac5a-5cfe-42d2-8a55-f27e505f5024"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("0758d565-7215-4d3c-9b32-59268e854eee"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("0dabe2e3-c79a-4bf5-8a90-8c37e11c49b8"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("167c2104-5884-4ff8-9e55-9bb46b3c1022"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("1ba16455-2864-4957-86a3-0adfb117a160"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("1ed11088-1329-4c57-923e-5e9e6c0b38ef"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("1f905643-97cb-4172-9196-0cbf8c16e8c6"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("23db640b-dcf7-408b-9444-b83164fe6038"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("2ff72c84-7868-4be6-88f7-020ebe13c098"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("3648b38b-5bb9-45e8-938f-b96205ca26cb"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("4451adbf-322c-4f83-af83-7eb5aee06591"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("47588780-1a13-4041-a8b1-8279788148df"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("48807082-0d04-47e0-910c-dcd26e696595"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("4ad63e18-7ad9-4534-9459-65f58a63ebc7"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("4d7e3353-1316-41af-9a60-3bd771b20bbf"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("4f47eec4-5e5c-4624-900f-c4eaf91c68fc"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("51eb8fdc-158f-4d73-b916-54507735fe5b"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("557566c3-41ad-4c8f-86be-0212242daf5e"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("5d4df7b0-9863-42cb-bdb3-59282b163489"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("64ccf43b-852c-439c-bc0c-82f57b13a5ed"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("68dbcc4d-10a8-4e13-ba66-c83da3cb0cf7"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("7308e139-e967-44d7-8372-1a64f3c260da"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("75042045-151a-4538-b881-1046f5d5aa86"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("7529cf35-37f3-4288-aea0-46deca3380ae"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("7a6faa96-c252-4595-b0f8-23e17698a47d"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("7c11c86b-ad9d-48f6-b0d6-5683d803f18f"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("7c5835de-3bf2-4920-90d2-277122b31a59"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("8256ddf9-b079-4162-9dbb-eb437078df97"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("82d36fc0-f0c5-46d2-a44f-47604a52c7d8"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("83795629-e88d-446a-99c9-f9a20144dc09"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("86de4902-ce1b-4e80-b29e-62e569fbc23a"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("8b4ca05d-d01a-4931-9fb4-a87e8a3480e6"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("8fba67cf-0756-4a0c-a77e-bd53fc292a71"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("908f53d0-8523-4fcd-af25-2eb51b074873"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("922f1719-248b-4a19-ae62-cf0c56c2595f"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("94671ac2-63db-448f-a283-ef5369a17b94"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("9f5e1fe1-72a7-4210-b160-c33ccce131bb"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("a2c173cb-2d5a-4170-be18-0963c6333f67"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("a619c77d-bb94-44da-bd85-2deef006943b"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("a7577dc2-716f-4fb4-ad74-3f1552c9d924"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("a8c5a3dd-c65a-4dfc-bcf4-03028ab1f3e8"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("b2557415-1202-49ab-a18f-b5f8fd001766"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("b36fe140-8d10-48e1-bf75-a6fb07335490"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("b696743e-e791-4e47-93cb-7b6ad4ec2b04"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("b77346f7-30cc-4f96-892e-c1260edc66f0"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("ba244261-e3c4-4815-aa1a-a582fca249e5"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("ba385a6f-3037-471d-a016-8c79d5eb8fdd"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("bc92bd2a-4569-4529-b938-962fd792ed90"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("bddb44d1-3495-4f10-a904-4bbd1493fb1e"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c16bd187-9e02-40bb-9af3-2a5046c79e31"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c383a68d-dbc2-4e0a-a135-ab8a701a2f00"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c4719452-caa9-43ca-a7c0-2348650b412a"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c4e74a30-c731-4f8a-bd75-01ddf5379307"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c70d64f5-e138-4d8f-ac84-85eb766b0c6c"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("cc71efe2-a7d4-435e-af7b-a8a0406c40db"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("d31faf03-92ac-4bf2-8a41-9e88f0f38bc7"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("d4166a59-fca1-4997-9778-701cb70be736"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("d7157d6f-b89d-46ba-86ec-8bf8f72baac5"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("de3251f4-e18d-4e79-813f-af80679c6fba"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("e18ecda4-37e9-4cf7-b690-b6ef8afc7f49"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("e4eb6dd9-5095-46fe-b932-c9ba844b1d27"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("e686c801-43dc-48c3-a611-cadb4a0e7fd7"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("ea63b6a3-3142-48fd-ad29-fee2fc74d1c1"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("eae3cf11-d06b-455d-8ee4-a68e6ece1376"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("ec27f4e4-9c28-4693-bccb-853d97013312"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("ee94cd7d-3508-4b0f-9522-1034d1f1af52"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("f081762f-dfb9-4199-9e3a-1e9532ab3332"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("f13c422f-120e-4525-9c83-d034d9ea19ad"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("f1d8ec91-4ae5-4e54-9f4b-8b3a9e483abe"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("f8d59849-0b47-48bb-88b0-93b67f4e7f89"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("1a673745-22a6-4bd7-88c0-3fcf61dfa889"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("2d31ac0c-6505-4309-91f2-2fb09224d571"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("5f331490-6687-4941-9b79-10b4f80ed4c1"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("603af906-25f9-4209-b20a-b0417119dca1"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("8a9425ee-8af9-4e0c-bddc-f9d18dd2c26e"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("9b815cd5-192c-49c5-bfee-9d48d6ee95dc"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("cd8d1372-670d-4c9b-aadc-1365fc5b0c62"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("d375201a-048b-4172-acba-2da90145e5b2"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("fb604e01-c7f4-4f21-ab45-356b8a3f0487"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ea6e042-6c00-4e44-9021-edd139f80fa5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d185505-f396-4704-ac5e-2203f86a380a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("905b75a0-4a7c-4dd4-9717-9087aca57882"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ba29bd5f-7dde-47b3-a9ca-b48c7a927fb1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0bac23d-aaff-4a04-a99a-07a1e0d27153"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d705c4c2-44ec-4e5c-90a6-68cf727584d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da5547d4-0adf-4c80-a7dc-5b94618d5532"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e185a8fa-8d3b-437b-b74a-71f3a32eadb4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e2dec651-a1d3-4a1c-9ee3-4d64ac59924c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f39c349b-1119-4a1d-bc63-8c9848068051"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d36c2368-edf4-42c9-839d-2f650be9f814"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("01a6bf5a-fae9-4779-a6ed-51cae0221202"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("03045a2a-10b1-477d-a4ef-ef7f190c91f2"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("054c7fc1-38b4-4304-b974-5218b0510d7c"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("21bda159-f948-48d0-b047-f458f0cf311a"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("2669a37a-a304-485e-9ca8-d9160bffe06e"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("39e92326-a02d-42eb-9ebc-b470d296cf3a"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("39e97df3-cf4d-41c5-829d-36d03c5602bc"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("3d9eda6a-5893-4fc3-a872-7a0b2c2f8cc9"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("47f12374-c031-48f7-941b-555c461a174d"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("481da6a2-6255-418a-87f0-568e3410f294"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("4d4afe26-d71d-474d-8e37-496fc12807c1"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("5301b249-14b0-4681-917c-ff4f2703a3e4"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("5c47daa5-55a4-4a32-b54f-abcb7b5cd42e"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("66c8b94b-c8fd-4a5c-b15b-5d8748d3a31a"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("688cf0b2-bdf9-4cda-822b-d787e054fba1"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("797a621c-cddd-45fc-9c10-8dc0b23f2bf0"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("7a45dda1-04e7-405c-afbf-a14580e98517"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("82612713-45b1-47d9-9d4b-07c61d483006"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("88645c3d-f762-4f27-8c29-a4ec72fb57a7"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("88a8f184-a8e0-462c-bdcf-583ea7acc695"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("983b4282-f914-4543-bccb-2b4eaa316f89"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("a179b06d-f731-46f0-aa45-ca4808be2ffe"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("a6ef265f-3895-45bf-ac25-792dc3a1344f"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("abcc1531-6f47-4397-81f6-876d3e2d3365"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("af28e4a8-9a43-44c6-9f97-61df8604fccc"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("b0be6e91-5584-42a1-b71e-6c4fab23703c"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("b1a74265-0a2b-4d04-b2e6-52599520fb6d"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("b6ef5064-91ab-4742-9dfc-d347a9a61122"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("ba5dcec5-ca83-402f-971d-e841b3f0ef40"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("bd59f4fb-57aa-43d5-b419-1eb398e1b699"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c2eb7c2e-1c61-42e4-ac98-20606a897f84"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("cc6cfaac-85d1-4a22-b896-675530cb9eff"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("d0884778-b211-415a-a7db-c8a2ead8a861"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("da7736b1-e809-4736-858c-7f25fdf08d29"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("dd07e372-5c9d-4502-a0ee-46525e8a5247"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("f11542ea-d390-4930-b710-a43379c04c07"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1228d3ef-a3c6-4ff9-a405-343cc130cfa1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e556bdc-a3b2-42f2-b127-d39697b301c5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("476085dd-0fc7-40a4-9448-38d9ddf9efbb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("502ecbff-3836-49d3-aa47-4e925967d629"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58b43d19-8ef5-4b41-8bc9-80d47817f3c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("660ab565-5a88-414f-849c-6b734d34f7a5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72394884-428d-4f2e-8efa-b86a5fb33ddd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8449d92e-ce0d-45a9-a924-1d12532a792f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("94469291-205f-4a03-ae14-a1a69b0f1b49"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a52ef42c-985e-4ccf-a729-2eee31527a50"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b14acd1e-8f37-4f2f-b07b-32e9d51fb888"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c32b3369-9e5c-487b-95f9-a521b5970072"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("de5ab3d4-bef0-496e-bd40-ba165043f423"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountriesTitle" },
                values: new object[,]
                {
                    { new Guid("275bc5ba-d018-42b9-94d9-51223885133f"), "South Georgia and the South Sandwich Islands" },
                    { new Guid("30c1fdcd-119b-48ff-bff0-8431a487bd4c"), "Argentina" },
                    { new Guid("3648f415-b813-4858-aa44-d0ae0526ee86"), "Israel" },
                    { new Guid("39c90a69-0453-4512-962c-eeb511678557"), "Denmark" },
                    { new Guid("697dae8f-d1f3-45c2-8e6c-df50d3a905ad"), "Western Sahara" },
                    { new Guid("7dba1741-6469-4d9c-b40a-333941f9e253"), "Jamaica" },
                    { new Guid("9fb06550-24a3-4190-839d-698343fdcd82"), "Isle of Man" },
                    { new Guid("a12b7259-70b5-416b-a05d-e7ebddd9a334"), "Suriname" },
                    { new Guid("aa1df7e3-fa8f-4a1d-9e0b-4e623e72a40e"), "Nauru" },
                    { new Guid("b6b17bcd-f250-4b6b-bf1b-91e6f12cb166"), "Eritrea" },
                    { new Guid("bafbb5f1-7532-4298-b605-2e9937fdd234"), "Namibia" },
                    { new Guid("c21b3a08-629f-4e43-aa24-3b7b010a9521"), "Brazil" },
                    { new Guid("cb95fb58-d5cb-420b-bb8f-e3b02182084d"), "Gibraltar" },
                    { new Guid("ea57e523-1b57-470d-98c7-cf42709d49e8"), "Cuba" },
                    { new Guid("fefbc21f-1363-4d5c-8a9c-a07a80e2b553"), "Netherlands" }
                });
        }
    }
}

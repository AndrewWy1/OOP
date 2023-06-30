using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Musical_Equipment_Shop_API.Migrations
{
    /// <inheritdoc />
    public partial class NewChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instruments_Categories_CategoriesId",
                table: "Instruments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instruments_Manufacturers_ManufacturerId",
                table: "Instruments");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Countries_CountriesId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Instruments_InstrumentsId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Manufacturers_Countries_CountriesId",
                table: "Manufacturers");

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
                table: "Categories",
                columns: new[] { "Id", "CategoryTitle" },
                values: new object[,]
                {
                    { new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "Drums" },
                    { new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"), "Winds" },
                    { new Guid("23acbc24-cdc3-449a-bd1a-2f07eb81d923"), "Amplifiers" },
                    { new Guid("71a270e9-d461-42ea-9730-3ee5418de561"), "Strings" },
                    { new Guid("a17fc111-d4cc-48a5-b1bf-a3f3dd75561a"), "Guitars" },
                    { new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "Percussion" },
                    { new Guid("d75d6f3f-2126-42c1-ba07-084374877b62"), "Keyboards" },
                    { new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "Accessories" },
                    { new Guid("eecf6066-45b0-4547-b01d-a445f0809982"), "DJEquipment" },
                    { new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"), "RecordingEquipment" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountriesTitle" },
                values: new object[,]
                {
                    { new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), "Israel" },
                    { new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), "Portugal" },
                    { new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), "Venezuela" },
                    { new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), "Ecuador" },
                    { new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), "Bahrain" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "CountriesId", "Title" },
                values: new object[,]
                {
                    { new Guid("00700c40-264b-4e2d-b610-c7653cf53c5f"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), "Schoen and Sons" },
                    { new Guid("04a0cea3-5fb6-4dea-8c58-504df04d431c"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), "Gislason, Morar and Kerluke" },
                    { new Guid("06aeda9f-a326-4954-8df5-0d4e36279659"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), "Senger, Purdy and Aufderhar" },
                    { new Guid("14ef1995-624e-4f7b-8f4e-55d8c0110ab1"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), "Hermann, Wyman and Turner" },
                    { new Guid("177dabbb-0c88-4fe8-8ace-8f06204b5a4f"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), "Greenfelder - Hartmann" },
                    { new Guid("1839ad01-b966-4593-ae12-6f7a47c6ed97"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), "Padberg - Mosciski" },
                    { new Guid("1cb3ac43-0d28-430e-acb1-4ce7038c4fde"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), "Wolff - Funk" },
                    { new Guid("21895625-432c-475a-b352-9eb6c93feff1"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), "Fadel - Hammes" },
                    { new Guid("2303c837-fe15-4862-9eda-200a187050ae"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), "MacGyver - Marquardt" },
                    { new Guid("24411dd7-c7e7-40e1-93c8-800f05aa9e6e"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), "Ullrich, Connelly and Treutel" },
                    { new Guid("3f61ebeb-ab2e-4c9b-8769-665396953634"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), "Nicolas - Grady" },
                    { new Guid("426865ce-2690-4a4a-92c1-d9e8145d0dec"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), "Kuphal - Orn" },
                    { new Guid("42f6d1d3-74be-4bf4-b84b-586f36bd802c"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), "VonRueden, MacGyver and Hettinger" },
                    { new Guid("433acc74-026e-4349-9005-f3ae1665f3ea"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), "Larson - Windler" },
                    { new Guid("473a0ff7-c8ff-4bf9-8f7b-8658aead94f1"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), "Dare - Beahan" },
                    { new Guid("47a063cb-9873-4edb-9c36-6794a8520bc4"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), "Metz - Sipes" },
                    { new Guid("4dd51e90-0b73-45ba-a81a-4cd6129e3353"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), "O'Conner Group" },
                    { new Guid("53e7911a-a109-449d-970d-0676f1780c2b"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), "Schmitt - Kertzmann" },
                    { new Guid("59803158-6615-427d-b27d-aea0f4293600"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), "Runte LLC" },
                    { new Guid("6106dc71-6a3b-4bae-ad61-46ec8b3004b1"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), "Beier, King and Friesen" },
                    { new Guid("63951f30-a1e5-4930-a69a-27ac9b9dbc59"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), "Cartwright - Nitzsche" },
                    { new Guid("63d82a66-0a82-443a-bc69-182c8479e738"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), "Ratke, Kuhlman and Fisher" },
                    { new Guid("69079607-3e4c-4e26-a492-8f0bae86cc29"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), "Lehner Group" },
                    { new Guid("6b8ec65b-66fe-4697-8d15-4b4d41d05414"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), "Frami Inc" },
                    { new Guid("7586b981-181d-4526-9055-544b419d0d50"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), "Ritchie - Cronin" },
                    { new Guid("75b32c50-48d5-491f-88cf-8fa7aa45adff"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), "Will and Sons" },
                    { new Guid("7a4fbbbe-1f23-4629-8226-ed53a63dd676"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), "Botsford and Sons" },
                    { new Guid("89032284-34c2-41ca-890e-f3b3138aead0"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), "Greenfelder Inc" },
                    { new Guid("91f0ca7c-4b15-419e-8254-861bfc973cf3"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), "Becker, Rogahn and Kutch" },
                    { new Guid("94578e04-9014-43f9-992b-1ddde3f3d043"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), "Ferry - Sauer" },
                    { new Guid("9a940fe8-424d-49f7-b64c-cd42ee40e849"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), "O'Connell - Okuneva" },
                    { new Guid("9ece79eb-3448-4e60-9ff8-c972d2c57635"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), "Oberbrunner - O'Keefe" },
                    { new Guid("a187271f-b349-48b1-af7e-aa03b2f3ef8d"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), "Ward, Wisozk and Quigley" },
                    { new Guid("a3db51ea-b378-41c5-8536-1cb6db2eca8b"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), "Rempel, McClure and Yundt" },
                    { new Guid("a45f7ad5-a3c0-4192-a82a-544f1a184e65"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), "Bogan - Witting" },
                    { new Guid("a6b22823-ea2b-47e1-9c6b-5088e5154630"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), "Shanahan and Sons" },
                    { new Guid("b3b5309d-b846-455e-be87-d637a9001e66"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), "Swift - Wisoky" },
                    { new Guid("bd3859d6-b0aa-4fdd-a4a6-32986b82ef37"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), "Kassulke - Jakubowski" },
                    { new Guid("c684fc23-871b-42c4-8c9e-a53138f7048e"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), "Olson - Hettinger" },
                    { new Guid("d0f16f8e-623d-46ff-8654-d48e304ba909"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), "Casper - Gottlieb" },
                    { new Guid("d5bf1f9c-031d-42f9-88cb-9b37f4086883"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), "Hyatt, Kulas and Fay" },
                    { new Guid("d6e4fd92-d29a-4a2f-8944-084e0a1d4a7f"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), "Beier - Kautzer" },
                    { new Guid("d76cd596-1955-4c20-82ff-51da3342ca4b"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), "Hudson LLC" },
                    { new Guid("d8700d7b-4b95-41af-ab37-ec70003be65b"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), "Abshire, Bayer and Hahn" },
                    { new Guid("d8de48e7-27c3-406a-893a-e49d1623efaf"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), "Strosin - Corwin" },
                    { new Guid("dcab3221-a70c-4896-a6e7-43c91f39d887"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), "Flatley and Sons" },
                    { new Guid("ddf0c59e-df32-4ef2-8161-6c8b3ab74c48"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), "Schoen - Swift" },
                    { new Guid("e5d80b04-71b9-4037-bdc5-81adb492dff6"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), "Baumbach - Anderson" },
                    { new Guid("f0f6caf3-6588-4d34-87c7-2f5984aeeeb5"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), "Schimmel, Heller and Emmerich" },
                    { new Guid("fb3fcda6-8954-4dab-b7bc-6a804bc2fed7"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), "Friesen and Sons" }
                });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "Id", "CategoriesId", "Description", "InstrumentTitle", "ManufacturerId" },
                values: new object[,]
                {
                    { new Guid("00ffd7fd-1ff7-4579-8f61-873dfae36569"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Saxophone", new Guid("63d82a66-0a82-443a-bc69-182c8479e738") },
                    { new Guid("011e1d9a-aed3-46a3-990e-10a1c31f9bfc"), new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Keyboard", new Guid("91f0ca7c-4b15-419e-8254-861bfc973cf3") },
                    { new Guid("01323892-3037-452e-81f4-a811418a044b"), new Guid("eecf6066-45b0-4547-b01d-a445f0809982"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Cello", new Guid("1839ad01-b966-4593-ae12-6f7a47c6ed97") },
                    { new Guid("033a475f-2128-4a44-ad41-91657f9deaea"), new Guid("a17fc111-d4cc-48a5-b1bf-a3f3dd75561a"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "AcousticGuitar", new Guid("d8700d7b-4b95-41af-ab37-ec70003be65b") },
                    { new Guid("0385fdcd-b3eb-4e1f-8a8e-7302de21d9f1"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "The Football Is Good For Training And Recreational Purposes", "Cello", new Guid("59803158-6615-427d-b27d-aea0f4293600") },
                    { new Guid("0777c651-84d8-45f9-aa92-507f4fa5ca01"), new Guid("71a270e9-d461-42ea-9730-3ee5418de561"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Cello", new Guid("433acc74-026e-4349-9005-f3ae1665f3ea") },
                    { new Guid("0b83e3d3-65a2-46d0-b333-5fb4e1cd55ee"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "AcousticGuitar", new Guid("f0f6caf3-6588-4d34-87c7-2f5984aeeeb5") },
                    { new Guid("0e135ba5-ed35-4b61-a965-8a42a68ee460"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Flute", new Guid("4dd51e90-0b73-45ba-a81a-4cd6129e3353") },
                    { new Guid("1026ad24-7527-45e7-b2b2-dea705679b23"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "ElectricGuitar", new Guid("d6e4fd92-d29a-4a2f-8944-084e0a1d4a7f") },
                    { new Guid("123ba1e0-58bd-4382-aabe-1331ba4afd2c"), new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Keyboard", new Guid("89032284-34c2-41ca-890e-f3b3138aead0") },
                    { new Guid("13fb8fdb-021f-483f-8f63-2e0821f39c9d"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "DrumSet", new Guid("6b8ec65b-66fe-4697-8d15-4b4d41d05414") },
                    { new Guid("152c838f-1798-4a78-929c-7da60100c22b"), new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Violin", new Guid("1cb3ac43-0d28-430e-acb1-4ce7038c4fde") },
                    { new Guid("16bee055-2583-4a0f-9045-4a5d42635c36"), new Guid("71a270e9-d461-42ea-9730-3ee5418de561"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "BassGuitar", new Guid("1839ad01-b966-4593-ae12-6f7a47c6ed97") },
                    { new Guid("19425b5c-deb0-48e0-997b-a616f39ad01b"), new Guid("a17fc111-d4cc-48a5-b1bf-a3f3dd75561a"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Cello", new Guid("d5bf1f9c-031d-42f9-88cb-9b37f4086883") },
                    { new Guid("1bb85237-fcac-4a0a-a9bb-04ffb08ad6db"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "DigitalPiano", new Guid("473a0ff7-c8ff-4bf9-8f7b-8658aead94f1") },
                    { new Guid("1f5e5582-ba4c-4ada-a2bb-dfbdfa0d3170"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "DigitalPiano", new Guid("a3db51ea-b378-41c5-8536-1cb6db2eca8b") },
                    { new Guid("1fdfb34f-4628-4906-9991-390b35587343"), new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "BassGuitar", new Guid("d6e4fd92-d29a-4a2f-8944-084e0a1d4a7f") },
                    { new Guid("2102bdf2-3f88-4d3a-9450-48fc130ebe9f"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "DrumSet", new Guid("24411dd7-c7e7-40e1-93c8-800f05aa9e6e") },
                    { new Guid("2271e3df-8e88-4ce7-82cb-8f446cec16c1"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Violin", new Guid("1839ad01-b966-4593-ae12-6f7a47c6ed97") },
                    { new Guid("23ca1159-1e48-4245-bb7f-010d36f70e9f"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "ElectricGuitar", new Guid("d8700d7b-4b95-41af-ab37-ec70003be65b") },
                    { new Guid("2500b256-82a3-4d5e-af31-57b0e7d9cc43"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Violin", new Guid("f0f6caf3-6588-4d34-87c7-2f5984aeeeb5") },
                    { new Guid("2700aa14-3900-4224-bea8-99a1c75afb75"), new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Cello", new Guid("6b8ec65b-66fe-4697-8d15-4b4d41d05414") },
                    { new Guid("2754d4e0-d668-4d62-926e-2ca220cdecda"), new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "ElectricGuitar", new Guid("75b32c50-48d5-491f-88cf-8fa7aa45adff") },
                    { new Guid("28ed713d-3d42-44d6-8462-8591eef8e85a"), new Guid("eecf6066-45b0-4547-b01d-a445f0809982"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Keyboard", new Guid("42f6d1d3-74be-4bf4-b84b-586f36bd802c") },
                    { new Guid("2907e46c-7bc4-4848-9343-1082e576dd24"), new Guid("a17fc111-d4cc-48a5-b1bf-a3f3dd75561a"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "DigitalPiano", new Guid("a6b22823-ea2b-47e1-9c6b-5088e5154630") },
                    { new Guid("2cd12b0d-1937-4503-85ad-37d4c2e30a6f"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Flute", new Guid("fb3fcda6-8954-4dab-b7bc-6a804bc2fed7") },
                    { new Guid("3000483e-58da-4e7a-8c84-09c8b6e64919"), new Guid("a17fc111-d4cc-48a5-b1bf-a3f3dd75561a"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Keyboard", new Guid("f0f6caf3-6588-4d34-87c7-2f5984aeeeb5") },
                    { new Guid("308f4297-ca1d-407b-9d49-36d51a32cca6"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Keyboard", new Guid("1839ad01-b966-4593-ae12-6f7a47c6ed97") },
                    { new Guid("30e24cd2-1729-4346-b555-060e7b2e7f78"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Cello", new Guid("f0f6caf3-6588-4d34-87c7-2f5984aeeeb5") },
                    { new Guid("333af9bb-1b2b-43fd-9311-9e697db0e8f4"), new Guid("eecf6066-45b0-4547-b01d-a445f0809982"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Keyboard", new Guid("6106dc71-6a3b-4bae-ad61-46ec8b3004b1") },
                    { new Guid("34967f69-5cda-452b-b94b-1bb242c5db96"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "DigitalPiano", new Guid("47a063cb-9873-4edb-9c36-6794a8520bc4") },
                    { new Guid("34e99da4-c0c9-4be7-b40e-1ab855bc6ca6"), new Guid("71a270e9-d461-42ea-9730-3ee5418de561"), "The Football Is Good For Training And Recreational Purposes", "Keyboard", new Guid("a6b22823-ea2b-47e1-9c6b-5088e5154630") },
                    { new Guid("368a0f0a-403a-44b1-92fe-5d05584a010d"), new Guid("23acbc24-cdc3-449a-bd1a-2f07eb81d923"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Saxophone", new Guid("06aeda9f-a326-4954-8df5-0d4e36279659") },
                    { new Guid("39248b6c-ff44-4681-8a03-88522a5b8d58"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "AcousticGuitar", new Guid("24411dd7-c7e7-40e1-93c8-800f05aa9e6e") },
                    { new Guid("395dbcf0-fd77-4031-a5ec-75c2b9037313"), new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "DigitalPiano", new Guid("a6b22823-ea2b-47e1-9c6b-5088e5154630") },
                    { new Guid("3a2547be-0dc4-4428-a764-511feaa17d79"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "DigitalPiano", new Guid("59803158-6615-427d-b27d-aea0f4293600") },
                    { new Guid("3c1ac560-3db6-43e8-994a-8149a8c9d126"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "DigitalPiano", new Guid("d0f16f8e-623d-46ff-8654-d48e304ba909") },
                    { new Guid("3e515cda-89f0-40bf-9cd6-bb9c7e30dfdc"), new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "DigitalPiano", new Guid("47a063cb-9873-4edb-9c36-6794a8520bc4") },
                    { new Guid("44575e3d-9df7-4c52-b90d-2472bd8b1e28"), new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "BassGuitar", new Guid("e5d80b04-71b9-4037-bdc5-81adb492dff6") },
                    { new Guid("45dae0af-7278-4449-996f-026d8104b729"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Cello", new Guid("a3db51ea-b378-41c5-8536-1cb6db2eca8b") },
                    { new Guid("4623c4cb-f776-457b-b308-8c1fe44c7325"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "DigitalPiano", new Guid("6106dc71-6a3b-4bae-ad61-46ec8b3004b1") },
                    { new Guid("4671131d-4115-4195-9d4e-b117ed837d54"), new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "DigitalPiano", new Guid("a3db51ea-b378-41c5-8536-1cb6db2eca8b") },
                    { new Guid("4731380f-0bb5-4843-82d7-f81fd0523536"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Saxophone", new Guid("9ece79eb-3448-4e60-9ff8-c972d2c57635") },
                    { new Guid("47f017aa-56f1-41b5-b20c-6ebaf438a54d"), new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "DrumSet", new Guid("a187271f-b349-48b1-af7e-aa03b2f3ef8d") },
                    { new Guid("4ab440cb-c390-44aa-860d-fe1187734cfc"), new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Flute", new Guid("a6b22823-ea2b-47e1-9c6b-5088e5154630") },
                    { new Guid("53d00ad3-456c-4d1d-82b3-c784d3d8c450"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "AcousticGuitar", new Guid("89032284-34c2-41ca-890e-f3b3138aead0") },
                    { new Guid("54e23ec1-9513-4088-8b63-11bfbd6ef093"), new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Keyboard", new Guid("3f61ebeb-ab2e-4c9b-8769-665396953634") },
                    { new Guid("561f1d4a-b501-4d27-8bc3-427291237353"), new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Flute", new Guid("a187271f-b349-48b1-af7e-aa03b2f3ef8d") },
                    { new Guid("5a3e368e-b501-499e-a7e2-df83653f4932"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "AcousticGuitar", new Guid("bd3859d6-b0aa-4fdd-a4a6-32986b82ef37") },
                    { new Guid("5c7eb12a-64cc-4c88-9141-da3634db6c55"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Cello", new Guid("d8700d7b-4b95-41af-ab37-ec70003be65b") },
                    { new Guid("5d1ffe6e-df85-46a4-8b0b-1a499fa8d2b4"), new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Flute", new Guid("75b32c50-48d5-491f-88cf-8fa7aa45adff") },
                    { new Guid("61b9958d-d831-498f-961e-43921d41f609"), new Guid("eecf6066-45b0-4547-b01d-a445f0809982"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "ElectricGuitar", new Guid("69079607-3e4c-4e26-a492-8f0bae86cc29") },
                    { new Guid("631f8172-53bf-4885-b6cb-35581cad1acb"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "DrumSet", new Guid("75b32c50-48d5-491f-88cf-8fa7aa45adff") },
                    { new Guid("66eb445a-6eb4-4d2a-a889-005804b26eb0"), new Guid("23acbc24-cdc3-449a-bd1a-2f07eb81d923"), "The Football Is Good For Training And Recreational Purposes", "Flute", new Guid("433acc74-026e-4349-9005-f3ae1665f3ea") },
                    { new Guid("67414a3a-5533-4f6c-a825-f6bbc74cf8eb"), new Guid("23acbc24-cdc3-449a-bd1a-2f07eb81d923"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Cello", new Guid("fb3fcda6-8954-4dab-b7bc-6a804bc2fed7") },
                    { new Guid("67c45eca-7bef-44d0-bd04-2bd6ae194cc5"), new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Cello", new Guid("a45f7ad5-a3c0-4192-a82a-544f1a184e65") },
                    { new Guid("68a5b64d-b3b1-4ca6-8a2c-cd13f2cdecb0"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "DigitalPiano", new Guid("dcab3221-a70c-4896-a6e7-43c91f39d887") },
                    { new Guid("68e78ce9-3bfe-4853-a3f4-4c8d9d828c7c"), new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Flute", new Guid("dcab3221-a70c-4896-a6e7-43c91f39d887") },
                    { new Guid("69836f53-a67a-40c0-a98f-d340870a36c0"), new Guid("eecf6066-45b0-4547-b01d-a445f0809982"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Keyboard", new Guid("42f6d1d3-74be-4bf4-b84b-586f36bd802c") },
                    { new Guid("69cb1d08-b28d-4a83-b23b-ab5ce9a57217"), new Guid("23acbc24-cdc3-449a-bd1a-2f07eb81d923"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Cello", new Guid("6106dc71-6a3b-4bae-ad61-46ec8b3004b1") },
                    { new Guid("6a0618bc-a607-4ea9-9d30-17ae213e8449"), new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "ElectricGuitar", new Guid("63951f30-a1e5-4930-a69a-27ac9b9dbc59") },
                    { new Guid("6a5fda17-2d96-43b4-afc1-6d1f3985bd70"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "AcousticGuitar", new Guid("ddf0c59e-df32-4ef2-8161-6c8b3ab74c48") },
                    { new Guid("6bd0b8fb-702d-4085-ada2-cc6ea7fa6276"), new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "DrumSet", new Guid("a3db51ea-b378-41c5-8536-1cb6db2eca8b") },
                    { new Guid("6ce28a26-f0c2-4cb9-9fae-5a8703dc3a53"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Violin", new Guid("7a4fbbbe-1f23-4629-8226-ed53a63dd676") },
                    { new Guid("6eb7cf6d-ced9-48d1-b147-dff925eb3ad4"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "The Football Is Good For Training And Recreational Purposes", "Violin", new Guid("d76cd596-1955-4c20-82ff-51da3342ca4b") },
                    { new Guid("707bb084-7d05-46c8-ab0e-25f3b4b7be81"), new Guid("eecf6066-45b0-4547-b01d-a445f0809982"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Violin", new Guid("21895625-432c-475a-b352-9eb6c93feff1") },
                    { new Guid("71033aae-382f-47c7-94f3-85e3baf02202"), new Guid("a17fc111-d4cc-48a5-b1bf-a3f3dd75561a"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Flute", new Guid("6b8ec65b-66fe-4697-8d15-4b4d41d05414") },
                    { new Guid("74922837-4c69-4fad-ad3a-4d9d65cc74ac"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "AcousticGuitar", new Guid("94578e04-9014-43f9-992b-1ddde3f3d043") },
                    { new Guid("74e7cf4a-d976-45ad-85b7-d980b828d735"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "DigitalPiano", new Guid("e5d80b04-71b9-4037-bdc5-81adb492dff6") },
                    { new Guid("778f6469-0467-4508-a100-db59b161abd3"), new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "ElectricGuitar", new Guid("d8de48e7-27c3-406a-893a-e49d1623efaf") },
                    { new Guid("7821568c-4a51-47d1-aa58-fc72fff78279"), new Guid("d75d6f3f-2126-42c1-ba07-084374877b62"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "DrumSet", new Guid("9ece79eb-3448-4e60-9ff8-c972d2c57635") },
                    { new Guid("787d4c94-7a58-4411-a6c9-bfdb371bdd0a"), new Guid("eecf6066-45b0-4547-b01d-a445f0809982"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Cello", new Guid("7586b981-181d-4526-9055-544b419d0d50") },
                    { new Guid("7a13ed6c-7c7a-4c42-aed9-610f7e7b2603"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Keyboard", new Guid("42f6d1d3-74be-4bf4-b84b-586f36bd802c") },
                    { new Guid("7cdf5869-107c-4f42-a087-7253f2276fe3"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "BassGuitar", new Guid("d76cd596-1955-4c20-82ff-51da3342ca4b") },
                    { new Guid("7d2bbd7b-ccfe-44b2-9693-66f209ffe885"), new Guid("71a270e9-d461-42ea-9730-3ee5418de561"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Flute", new Guid("e5d80b04-71b9-4037-bdc5-81adb492dff6") },
                    { new Guid("7e1d43f5-0061-432b-afc0-61c5386dc82e"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Saxophone", new Guid("473a0ff7-c8ff-4bf9-8f7b-8658aead94f1") },
                    { new Guid("7e628891-3c7e-498d-91f3-4e9ef7fea5f0"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Flute", new Guid("d0f16f8e-623d-46ff-8654-d48e304ba909") },
                    { new Guid("820e72e2-9228-4558-8474-aaa77773df20"), new Guid("eecf6066-45b0-4547-b01d-a445f0809982"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "BassGuitar", new Guid("7a4fbbbe-1f23-4629-8226-ed53a63dd676") },
                    { new Guid("82b5a80a-bf3c-4c3c-a6a8-b1220942d0db"), new Guid("23acbc24-cdc3-449a-bd1a-2f07eb81d923"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "BassGuitar", new Guid("59803158-6615-427d-b27d-aea0f4293600") },
                    { new Guid("88fc9fed-100c-4d64-bf5e-f66f82530772"), new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "ElectricGuitar", new Guid("7a4fbbbe-1f23-4629-8226-ed53a63dd676") },
                    { new Guid("8cc28ea7-16d3-4d33-a9e0-4ddd3807a552"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Saxophone", new Guid("75b32c50-48d5-491f-88cf-8fa7aa45adff") },
                    { new Guid("900b7a25-b119-4cb3-b431-50310ed0fa8c"), new Guid("d75d6f3f-2126-42c1-ba07-084374877b62"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "DigitalPiano", new Guid("d76cd596-1955-4c20-82ff-51da3342ca4b") },
                    { new Guid("905f18a1-25e9-484b-94f0-e17136e66f99"), new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Keyboard", new Guid("1839ad01-b966-4593-ae12-6f7a47c6ed97") },
                    { new Guid("90aacbff-b0b6-400f-b4d1-6682892ed945"), new Guid("eecf6066-45b0-4547-b01d-a445f0809982"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "BassGuitar", new Guid("9ece79eb-3448-4e60-9ff8-c972d2c57635") },
                    { new Guid("91fa8895-c85f-4566-aa7e-bbb4576515ed"), new Guid("a17fc111-d4cc-48a5-b1bf-a3f3dd75561a"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Violin", new Guid("2303c837-fe15-4862-9eda-200a187050ae") },
                    { new Guid("93273d23-8695-4587-a2f9-f21a12d53164"), new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "DigitalPiano", new Guid("91f0ca7c-4b15-419e-8254-861bfc973cf3") },
                    { new Guid("942014f9-8087-4b3e-9a5f-d46543dbc137"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "DrumSet", new Guid("fb3fcda6-8954-4dab-b7bc-6a804bc2fed7") },
                    { new Guid("9471d29d-9941-4d1d-8b27-6682e4ef7da6"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Violin", new Guid("53e7911a-a109-449d-970d-0676f1780c2b") },
                    { new Guid("948e4af8-1301-4377-916d-04c8e246fc90"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Saxophone", new Guid("2303c837-fe15-4862-9eda-200a187050ae") },
                    { new Guid("998ee478-3453-46ee-91eb-9ef4baa462b9"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Keyboard", new Guid("6106dc71-6a3b-4bae-ad61-46ec8b3004b1") },
                    { new Guid("99d1b145-9b21-49f8-a0ab-5d9c29f076e0"), new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "DrumSet", new Guid("473a0ff7-c8ff-4bf9-8f7b-8658aead94f1") },
                    { new Guid("9a9e1e09-50b5-4643-a9f5-c85251ad2dd2"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "AcousticGuitar", new Guid("a187271f-b349-48b1-af7e-aa03b2f3ef8d") },
                    { new Guid("9acd025a-010f-4416-948d-0c7aa2d67f8a"), new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Violin", new Guid("d8700d7b-4b95-41af-ab37-ec70003be65b") },
                    { new Guid("9bb3f84c-4cf3-4fda-a055-ef5eec128d77"), new Guid("a17fc111-d4cc-48a5-b1bf-a3f3dd75561a"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Cello", new Guid("177dabbb-0c88-4fe8-8ace-8f06204b5a4f") },
                    { new Guid("9d98a360-e1c9-415b-b2f8-cd4af18799e8"), new Guid("a17fc111-d4cc-48a5-b1bf-a3f3dd75561a"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "DrumSet", new Guid("63d82a66-0a82-443a-bc69-182c8479e738") },
                    { new Guid("9dd67011-c124-408f-a4c6-8432dc7c8280"), new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "DigitalPiano", new Guid("47a063cb-9873-4edb-9c36-6794a8520bc4") },
                    { new Guid("9f591232-bb0f-412f-89c8-f08fae55124e"), new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "AcousticGuitar", new Guid("6b8ec65b-66fe-4697-8d15-4b4d41d05414") },
                    { new Guid("9f8d012d-3d5c-47eb-b148-b3de82d2cc9a"), new Guid("d75d6f3f-2126-42c1-ba07-084374877b62"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "DigitalPiano", new Guid("6b8ec65b-66fe-4697-8d15-4b4d41d05414") },
                    { new Guid("a0525d53-1e92-49bd-8d93-3bed9c7f069a"), new Guid("d75d6f3f-2126-42c1-ba07-084374877b62"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Cello", new Guid("42f6d1d3-74be-4bf4-b84b-586f36bd802c") },
                    { new Guid("a0f06e22-f84c-4062-9683-e5cf272354d9"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "DigitalPiano", new Guid("47a063cb-9873-4edb-9c36-6794a8520bc4") },
                    { new Guid("a2c66f46-8242-4523-aa94-50e1cfa7ddf6"), new Guid("23acbc24-cdc3-449a-bd1a-2f07eb81d923"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "AcousticGuitar", new Guid("d8de48e7-27c3-406a-893a-e49d1623efaf") },
                    { new Guid("a5289462-3c77-4b30-83be-d46f4753638d"), new Guid("a17fc111-d4cc-48a5-b1bf-a3f3dd75561a"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Keyboard", new Guid("4dd51e90-0b73-45ba-a81a-4cd6129e3353") },
                    { new Guid("a6c114fb-4d11-4fc1-ae0f-d4b441f9d9c1"), new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Flute", new Guid("ddf0c59e-df32-4ef2-8161-6c8b3ab74c48") },
                    { new Guid("a8d70efc-7c0a-45c0-a045-1c4e65c79f46"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Saxophone", new Guid("fb3fcda6-8954-4dab-b7bc-6a804bc2fed7") },
                    { new Guid("ab92c4ff-d506-41af-a59e-7d6dbe494f3c"), new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "AcousticGuitar", new Guid("a45f7ad5-a3c0-4192-a82a-544f1a184e65") },
                    { new Guid("aec8a61a-05e5-4438-a221-0200d8ce7872"), new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "ElectricGuitar", new Guid("59803158-6615-427d-b27d-aea0f4293600") },
                    { new Guid("afd19d7a-3145-4275-9c9f-9fc299775fa6"), new Guid("d75d6f3f-2126-42c1-ba07-084374877b62"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "DigitalPiano", new Guid("ddf0c59e-df32-4ef2-8161-6c8b3ab74c48") },
                    { new Guid("afef0f14-ae09-489e-83f0-7de620846d27"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Keyboard", new Guid("a6b22823-ea2b-47e1-9c6b-5088e5154630") },
                    { new Guid("b2adfc42-224b-443f-8dca-878b61ec4e32"), new Guid("71a270e9-d461-42ea-9730-3ee5418de561"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "ElectricGuitar", new Guid("a45f7ad5-a3c0-4192-a82a-544f1a184e65") },
                    { new Guid("b3fac59a-aac4-4b7c-bd3c-9c9ee7a78059"), new Guid("a17fc111-d4cc-48a5-b1bf-a3f3dd75561a"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "DrumSet", new Guid("47a063cb-9873-4edb-9c36-6794a8520bc4") },
                    { new Guid("b67b6b47-ef46-48ef-8fc0-0eca25c80fed"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Cello", new Guid("4dd51e90-0b73-45ba-a81a-4cd6129e3353") },
                    { new Guid("bd367d82-cb8c-444b-b52e-87ee6432a3a2"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "BassGuitar", new Guid("b3b5309d-b846-455e-be87-d637a9001e66") },
                    { new Guid("c068910d-3b63-4bbd-a21a-8208cb7e904c"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "BassGuitar", new Guid("63951f30-a1e5-4930-a69a-27ac9b9dbc59") },
                    { new Guid("c09430bd-e709-40db-be9a-80d61f65e539"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Saxophone", new Guid("a6b22823-ea2b-47e1-9c6b-5088e5154630") },
                    { new Guid("c12dd565-96d4-4b1e-8e70-9a9d2dc21ddc"), new Guid("a17fc111-d4cc-48a5-b1bf-a3f3dd75561a"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Cello", new Guid("14ef1995-624e-4f7b-8f4e-55d8c0110ab1") },
                    { new Guid("c1bc9893-ccf8-417c-833b-d13671b67a19"), new Guid("d75d6f3f-2126-42c1-ba07-084374877b62"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Violin", new Guid("d76cd596-1955-4c20-82ff-51da3342ca4b") },
                    { new Guid("c2a68d0a-d364-4389-a9f9-ddac4764e829"), new Guid("d75d6f3f-2126-42c1-ba07-084374877b62"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Violin", new Guid("1839ad01-b966-4593-ae12-6f7a47c6ed97") },
                    { new Guid("c2ca4172-c1bb-4c00-83cf-0487c6534cb6"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Violin", new Guid("1cb3ac43-0d28-430e-acb1-4ce7038c4fde") },
                    { new Guid("c5c13fab-08d6-4709-b1ed-71c83e0283d5"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "The Football Is Good For Training And Recreational Purposes", "Saxophone", new Guid("53e7911a-a109-449d-970d-0676f1780c2b") },
                    { new Guid("c6178ad7-20b6-434e-aa0a-b2abdad501d4"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "DrumSet", new Guid("9a940fe8-424d-49f7-b64c-cd42ee40e849") },
                    { new Guid("c785195d-70e4-45df-8ef2-4ca34b1b9efb"), new Guid("d75d6f3f-2126-42c1-ba07-084374877b62"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "DigitalPiano", new Guid("47a063cb-9873-4edb-9c36-6794a8520bc4") },
                    { new Guid("ca413443-50ff-4cc1-90fb-31531364eb98"), new Guid("71a270e9-d461-42ea-9730-3ee5418de561"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Flute", new Guid("f0f6caf3-6588-4d34-87c7-2f5984aeeeb5") },
                    { new Guid("cac6d9b2-43a3-424c-8da1-ad87b8d282fe"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "DigitalPiano", new Guid("47a063cb-9873-4edb-9c36-6794a8520bc4") },
                    { new Guid("cfd88dd4-15e8-4b4a-8a14-d2a60053152a"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Saxophone", new Guid("d8700d7b-4b95-41af-ab37-ec70003be65b") },
                    { new Guid("d028a684-a97b-4ad3-be52-232a771c975a"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "DigitalPiano", new Guid("6b8ec65b-66fe-4697-8d15-4b4d41d05414") },
                    { new Guid("d08fdb86-ba5e-49be-b980-497394d4d7ac"), new Guid("71a270e9-d461-42ea-9730-3ee5418de561"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "ElectricGuitar", new Guid("9ece79eb-3448-4e60-9ff8-c972d2c57635") },
                    { new Guid("d784b281-317c-408f-bfea-4bb27f3c7fd9"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Saxophone", new Guid("ddf0c59e-df32-4ef2-8161-6c8b3ab74c48") },
                    { new Guid("d8c03ee4-9aa0-40a6-af34-b937281cee90"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Flute", new Guid("14ef1995-624e-4f7b-8f4e-55d8c0110ab1") },
                    { new Guid("d96d0d08-f949-4739-bb6a-294e1fb30ef1"), new Guid("71a270e9-d461-42ea-9730-3ee5418de561"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Keyboard", new Guid("a187271f-b349-48b1-af7e-aa03b2f3ef8d") },
                    { new Guid("d9c22c93-6623-4fad-9818-5c62b94b214d"), new Guid("d75d6f3f-2126-42c1-ba07-084374877b62"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "DigitalPiano", new Guid("4dd51e90-0b73-45ba-a81a-4cd6129e3353") },
                    { new Guid("dc260e98-b15a-4261-945e-eb784c3e98ee"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Keyboard", new Guid("6b8ec65b-66fe-4697-8d15-4b4d41d05414") },
                    { new Guid("dc2e678f-a071-41ff-a3d3-5fd24ef64eab"), new Guid("23acbc24-cdc3-449a-bd1a-2f07eb81d923"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "ElectricGuitar", new Guid("7586b981-181d-4526-9055-544b419d0d50") },
                    { new Guid("ddc3feb7-34cd-426e-adb3-5f76e56ee520"), new Guid("71a270e9-d461-42ea-9730-3ee5418de561"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Cello", new Guid("3f61ebeb-ab2e-4c9b-8769-665396953634") },
                    { new Guid("e2d91186-f5f2-45d5-a8a7-b5a8ad0b024d"), new Guid("23acbc24-cdc3-449a-bd1a-2f07eb81d923"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "DrumSet", new Guid("d8de48e7-27c3-406a-893a-e49d1623efaf") },
                    { new Guid("e3809d00-a3e8-4113-9eeb-29bf2a675ffd"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Violin", new Guid("ddf0c59e-df32-4ef2-8161-6c8b3ab74c48") },
                    { new Guid("e47632a4-13a8-4395-8b5f-1928dd85638b"), new Guid("23acbc24-cdc3-449a-bd1a-2f07eb81d923"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "DigitalPiano", new Guid("9ece79eb-3448-4e60-9ff8-c972d2c57635") },
                    { new Guid("e4ea6a65-1239-4fa0-9637-a38d0cc1ee6f"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Violin", new Guid("fb3fcda6-8954-4dab-b7bc-6a804bc2fed7") },
                    { new Guid("e52e5cf1-46cb-4b99-b237-4f6953e98913"), new Guid("71a270e9-d461-42ea-9730-3ee5418de561"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Flute", new Guid("a45f7ad5-a3c0-4192-a82a-544f1a184e65") },
                    { new Guid("e59549a5-df22-45cb-92a7-f136fb06256d"), new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "DigitalPiano", new Guid("9a940fe8-424d-49f7-b64c-cd42ee40e849") },
                    { new Guid("e98e38f6-c5f6-48c8-b0be-7da358156e5e"), new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Keyboard", new Guid("a3db51ea-b378-41c5-8536-1cb6db2eca8b") },
                    { new Guid("eaf3457f-19df-4ac2-acd4-701f97bd97e4"), new Guid("71a270e9-d461-42ea-9730-3ee5418de561"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Violin", new Guid("89032284-34c2-41ca-890e-f3b3138aead0") },
                    { new Guid("ed1a18a7-1911-4cf4-ae50-a424bcff25b2"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "AcousticGuitar", new Guid("7586b981-181d-4526-9055-544b419d0d50") },
                    { new Guid("ee20ba2c-15cc-4ec1-816e-65c98d2f019c"), new Guid("a17fc111-d4cc-48a5-b1bf-a3f3dd75561a"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Keyboard", new Guid("69079607-3e4c-4e26-a492-8f0bae86cc29") },
                    { new Guid("ee51f9e6-b07c-4803-aaf9-023ac48ccdcc"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "BassGuitar", new Guid("06aeda9f-a326-4954-8df5-0d4e36279659") },
                    { new Guid("f1623990-8aab-4f1b-994c-9bc64e13bdfe"), new Guid("a17fc111-d4cc-48a5-b1bf-a3f3dd75561a"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "BassGuitar", new Guid("04a0cea3-5fb6-4dea-8c58-504df04d431c") },
                    { new Guid("f55ee622-bcda-4045-95c2-fb4f23e92d08"), new Guid("71a270e9-d461-42ea-9730-3ee5418de561"), "The Football Is Good For Training And Recreational Purposes", "DrumSet", new Guid("1839ad01-b966-4593-ae12-6f7a47c6ed97") },
                    { new Guid("f65a1976-c008-4ddd-9a36-db193d1ce41e"), new Guid("71a270e9-d461-42ea-9730-3ee5418de561"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "DrumSet", new Guid("7a4fbbbe-1f23-4629-8226-ed53a63dd676") },
                    { new Guid("f79ee19a-9221-4941-8b04-7d2507b674df"), new Guid("71a270e9-d461-42ea-9730-3ee5418de561"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "ElectricGuitar", new Guid("1839ad01-b966-4593-ae12-6f7a47c6ed97") },
                    { new Guid("f821c297-72fe-4521-96d3-8e5f6b7f1bbb"), new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Keyboard", new Guid("a3db51ea-b378-41c5-8536-1cb6db2eca8b") },
                    { new Guid("fe482c77-fe9c-487c-995b-63d717dd3730"), new Guid("71a270e9-d461-42ea-9730-3ee5418de561"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "DrumSet", new Guid("bd3859d6-b0aa-4fdd-a4a6-32986b82ef37") }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CountriesId", "CreatedDateTime", "Description", "InstrumentsId", "Price" },
                values: new object[,]
                {
                    { new Guid("02a8ccc7-e3e2-49ad-8dae-12242ea18192"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2022, 8, 20, 20, 21, 4, 332, DateTimeKind.Local).AddTicks(6333), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("6bd0b8fb-702d-4085-ada2-cc6ea7fa6276"), 223.56m },
                    { new Guid("07e9776e-4d9e-4143-bf60-6302e9808cef"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2022, 9, 7, 1, 29, 5, 839, DateTimeKind.Local).AddTicks(1016), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("19425b5c-deb0-48e0-997b-a616f39ad01b"), 397.49m },
                    { new Guid("09211da4-4732-43ef-940f-8579445ae8cb"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2023, 2, 28, 0, 57, 12, 311, DateTimeKind.Local).AddTicks(8289), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("afef0f14-ae09-489e-83f0-7de620846d27"), 444.03m },
                    { new Guid("094b9ca2-c326-48e6-a47b-40b20b96a551"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2022, 9, 7, 17, 45, 36, 856, DateTimeKind.Local).AddTicks(4169), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("99d1b145-9b21-49f8-a0ab-5d9c29f076e0"), 408.82m },
                    { new Guid("0a27e334-c80f-4c76-9dc1-4541495b403d"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), new DateTime(2023, 5, 28, 9, 4, 52, 773, DateTimeKind.Local).AddTicks(2259), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("2907e46c-7bc4-4848-9343-1082e576dd24"), 559.98m },
                    { new Guid("0c086d27-9846-46ae-8d76-6a012b10e3a3"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2022, 7, 10, 22, 0, 8, 137, DateTimeKind.Local).AddTicks(7991), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("fe482c77-fe9c-487c-995b-63d717dd3730"), 935.33m },
                    { new Guid("1053f973-08a3-457d-8361-8f1e9e5ee77b"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2023, 6, 1, 22, 31, 52, 894, DateTimeKind.Local).AddTicks(4051), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("afef0f14-ae09-489e-83f0-7de620846d27"), 696.06m },
                    { new Guid("13f5cb34-b8be-4d19-86f3-8b66914a2aaf"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), new DateTime(2023, 1, 19, 9, 38, 24, 933, DateTimeKind.Local).AddTicks(5888), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("afd19d7a-3145-4275-9c9f-9fc299775fa6"), 993.61m },
                    { new Guid("17eee723-49ce-449f-9bdd-52afe2be23a2"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2022, 11, 19, 15, 50, 11, 154, DateTimeKind.Local).AddTicks(2), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("74922837-4c69-4fad-ad3a-4d9d65cc74ac"), 664.04m },
                    { new Guid("19ac9206-1f66-4cf2-bc6a-a7ca2dd2b092"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2023, 1, 17, 6, 34, 47, 198, DateTimeKind.Local).AddTicks(1978), "The Football Is Good For Training And Recreational Purposes", new Guid("45dae0af-7278-4449-996f-026d8104b729"), 395.11m },
                    { new Guid("1a74e7d8-c4e6-45aa-b40c-5a6ec12e2e21"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), new DateTime(2022, 12, 9, 6, 17, 59, 463, DateTimeKind.Local).AddTicks(5455), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("7e628891-3c7e-498d-91f3-4e9ef7fea5f0"), 380.26m },
                    { new Guid("1ebce518-01c1-4904-8d41-3f24dc2afa32"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2022, 6, 23, 19, 19, 53, 273, DateTimeKind.Local).AddTicks(9990), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("f55ee622-bcda-4045-95c2-fb4f23e92d08"), 603.13m },
                    { new Guid("23429e61-6257-4cc7-ae6a-0e767df2b7c9"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2022, 9, 16, 19, 19, 46, 598, DateTimeKind.Local).AddTicks(2816), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("a6c114fb-4d11-4fc1-ae0f-d4b441f9d9c1"), 418.63m },
                    { new Guid("2a296422-d7b4-4396-81ef-ad06d91d541e"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2022, 6, 16, 18, 54, 6, 848, DateTimeKind.Local).AddTicks(766), "The Football Is Good For Training And Recreational Purposes", new Guid("a0525d53-1e92-49bd-8d93-3bed9c7f069a"), 780.64m },
                    { new Guid("2c80c1d8-ece2-42ec-a9ca-7a1910450255"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2023, 1, 14, 18, 4, 3, 220, DateTimeKind.Local).AddTicks(107), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("942014f9-8087-4b3e-9a5f-d46543dbc137"), 864.76m },
                    { new Guid("2cb898d0-f7b8-4ada-988f-64f8fde29fe3"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2023, 3, 20, 23, 48, 40, 347, DateTimeKind.Local).AddTicks(7520), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("68e78ce9-3bfe-4853-a3f4-4c8d9d828c7c"), 379.15m },
                    { new Guid("2fa3401d-a98c-47fc-b4f2-976e3d93f903"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2022, 11, 15, 12, 55, 19, 548, DateTimeKind.Local).AddTicks(5268), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("28ed713d-3d42-44d6-8462-8591eef8e85a"), 376.01m },
                    { new Guid("33e889ea-4022-420d-9555-437a66fa05c2"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2022, 11, 2, 1, 14, 42, 154, DateTimeKind.Local).AddTicks(3955), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("d028a684-a97b-4ad3-be52-232a771c975a"), 488.65m },
                    { new Guid("35451c3b-e871-4b71-bb48-04544b739849"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2022, 6, 30, 7, 4, 3, 739, DateTimeKind.Local).AddTicks(7772), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("4731380f-0bb5-4843-82d7-f81fd0523536"), 617.82m },
                    { new Guid("355c9ee2-56d8-4786-9256-07ceb9ad30d8"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), new DateTime(2022, 12, 18, 6, 25, 41, 437, DateTimeKind.Local).AddTicks(1369), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("c6178ad7-20b6-434e-aa0a-b2abdad501d4"), 853.23m },
                    { new Guid("37627d47-85b3-4117-b7bf-9b51d27bb091"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2023, 1, 1, 3, 5, 23, 651, DateTimeKind.Local).AddTicks(9119), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("74e7cf4a-d976-45ad-85b7-d980b828d735"), 540.45m },
                    { new Guid("412d6f50-fcc0-4ade-aa6e-b6f954ce6b28"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2022, 9, 1, 5, 11, 41, 881, DateTimeKind.Local).AddTicks(6329), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("631f8172-53bf-4885-b6cb-35581cad1acb"), 369.27m },
                    { new Guid("43d8ff7e-75a1-4ab1-92de-dd56a006b8ee"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2023, 5, 25, 22, 22, 36, 824, DateTimeKind.Local).AddTicks(5182), "The Football Is Good For Training And Recreational Purposes", new Guid("c1bc9893-ccf8-417c-833b-d13671b67a19"), 758.33m },
                    { new Guid("440f50db-4f02-4a55-bd4d-040ab0a37af8"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2023, 3, 13, 23, 4, 35, 826, DateTimeKind.Local).AddTicks(4502), "The Football Is Good For Training And Recreational Purposes", new Guid("4731380f-0bb5-4843-82d7-f81fd0523536"), 348.65m },
                    { new Guid("450ed41f-444d-4977-a0a4-86b2c4bb0ae0"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2022, 11, 9, 10, 36, 4, 78, DateTimeKind.Local).AddTicks(3241), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("3c1ac560-3db6-43e8-994a-8149a8c9d126"), 771.82m },
                    { new Guid("47ce4f63-c5fa-4c4f-89ea-3ef8187807f2"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2022, 8, 16, 14, 14, 24, 116, DateTimeKind.Local).AddTicks(6724), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("7cdf5869-107c-4f42-a087-7253f2276fe3"), 413.17m },
                    { new Guid("4957a0d7-9e92-4315-bb17-84f54c5f7f8d"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2022, 12, 14, 13, 28, 17, 135, DateTimeKind.Local).AddTicks(3771), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("28ed713d-3d42-44d6-8462-8591eef8e85a"), 752.53m },
                    { new Guid("4a128b3d-f19d-44e2-b823-d650ae8bcdf3"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2022, 10, 9, 13, 1, 31, 866, DateTimeKind.Local).AddTicks(1232), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("c785195d-70e4-45df-8ef2-4ca34b1b9efb"), 287.23m },
                    { new Guid("528094a9-54ac-4eff-86d4-222d951c48e5"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), new DateTime(2022, 8, 16, 4, 37, 4, 189, DateTimeKind.Local).AddTicks(1903), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("a8d70efc-7c0a-45c0-a045-1c4e65c79f46"), 629.35m },
                    { new Guid("52ac4a3e-4634-478d-9e0b-522f52bac64b"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), new DateTime(2022, 6, 8, 19, 23, 38, 594, DateTimeKind.Local).AddTicks(6438), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("333af9bb-1b2b-43fd-9311-9e697db0e8f4"), 391.76m },
                    { new Guid("55f3779e-996c-4395-9d9d-e3f0b282de03"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), new DateTime(2023, 1, 29, 17, 47, 11, 142, DateTimeKind.Local).AddTicks(7691), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("2271e3df-8e88-4ce7-82cb-8f446cec16c1"), 271.53m },
                    { new Guid("5852d46d-ffd7-4a86-83f5-34e5fda70056"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2022, 12, 8, 16, 5, 8, 897, DateTimeKind.Local).AddTicks(1553), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("b3fac59a-aac4-4b7c-bd3c-9c9ee7a78059"), 925.25m },
                    { new Guid("58fdf9b5-4a2d-4295-ae99-dfebceb6063b"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2022, 9, 23, 10, 50, 17, 453, DateTimeKind.Local).AddTicks(2102), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("e3809d00-a3e8-4113-9eeb-29bf2a675ffd"), 263.71m },
                    { new Guid("59ece337-f795-4137-9ee8-4fd6fc88b09e"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2023, 1, 12, 3, 23, 15, 513, DateTimeKind.Local).AddTicks(3348), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("787d4c94-7a58-4411-a6c9-bfdb371bdd0a"), 403.27m },
                    { new Guid("5f31df8c-e624-4e81-be84-ad667bc37583"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2022, 7, 13, 9, 33, 1, 361, DateTimeKind.Local).AddTicks(757), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("4731380f-0bb5-4843-82d7-f81fd0523536"), 93.93m },
                    { new Guid("60a87199-521a-4933-bef5-eac32981cf63"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), new DateTime(2023, 1, 9, 10, 6, 46, 203, DateTimeKind.Local).AddTicks(8259), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("71033aae-382f-47c7-94f3-85e3baf02202"), 668.92m },
                    { new Guid("624c41ef-3639-4ce7-a54a-fba00bc97aa7"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2023, 2, 8, 18, 55, 35, 895, DateTimeKind.Local).AddTicks(3733), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("71033aae-382f-47c7-94f3-85e3baf02202"), 564.59m },
                    { new Guid("66710dff-b04f-4fb3-ad9b-07e6cb0ac6bf"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2023, 3, 8, 23, 33, 16, 113, DateTimeKind.Local).AddTicks(8220), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("905f18a1-25e9-484b-94f0-e17136e66f99"), 488.38m },
                    { new Guid("67c96cc6-fbfc-46cc-9010-e7d50f995428"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2022, 8, 1, 12, 4, 29, 255, DateTimeKind.Local).AddTicks(4667), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("1fdfb34f-4628-4906-9991-390b35587343"), 289.29m },
                    { new Guid("688ee88b-c862-41f2-b4f0-d21dda6cd79b"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2023, 2, 13, 18, 19, 10, 654, DateTimeKind.Local).AddTicks(4867), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("7821568c-4a51-47d1-aa58-fc72fff78279"), 403.25m },
                    { new Guid("6d08b585-1821-4763-9e9e-401925830022"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2023, 1, 22, 0, 0, 49, 121, DateTimeKind.Local).AddTicks(2997), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("99d1b145-9b21-49f8-a0ab-5d9c29f076e0"), 604.27m },
                    { new Guid("6dc4e4ef-79b0-491d-87a2-169be772f7fe"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2023, 3, 30, 2, 38, 52, 285, DateTimeKind.Local).AddTicks(5075), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("91fa8895-c85f-4566-aa7e-bbb4576515ed"), 558.21m },
                    { new Guid("6ff0ae6c-54b4-4175-82ba-caeb2a9f6600"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2023, 4, 6, 8, 33, 3, 191, DateTimeKind.Local).AddTicks(5900), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("d784b281-317c-408f-bfea-4bb27f3c7fd9"), 332.63m },
                    { new Guid("7557400f-52d2-4418-9be5-7aa1aef4621c"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2022, 7, 27, 11, 15, 38, 906, DateTimeKind.Local).AddTicks(15), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("561f1d4a-b501-4d27-8bc3-427291237353"), 624.13m },
                    { new Guid("76308c99-34f5-4fa7-b8c1-fc622fadaf2e"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2022, 6, 16, 15, 54, 32, 105, DateTimeKind.Local).AddTicks(4543), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("6ce28a26-f0c2-4cb9-9fae-5a8703dc3a53"), 88.51m },
                    { new Guid("7651b5f2-5124-44f7-9474-acc562b3d5e6"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2022, 9, 21, 17, 11, 6, 71, DateTimeKind.Local).AddTicks(719), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("a2c66f46-8242-4523-aa94-50e1cfa7ddf6"), 24.77m },
                    { new Guid("7b385271-79f6-4ffb-ac24-ce6a662d292e"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2023, 5, 19, 18, 50, 20, 604, DateTimeKind.Local).AddTicks(1796), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("6eb7cf6d-ced9-48d1-b147-dff925eb3ad4"), 382.08m },
                    { new Guid("7b93f3aa-1148-4cd1-a62a-5342e2d6becf"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2023, 5, 14, 15, 0, 28, 267, DateTimeKind.Local).AddTicks(416), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("c09430bd-e709-40db-be9a-80d61f65e539"), 711.98m },
                    { new Guid("7bc29369-431b-4758-8649-b537f3ec936f"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2022, 7, 6, 1, 26, 29, 765, DateTimeKind.Local).AddTicks(107), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("6a0618bc-a607-4ea9-9d30-17ae213e8449"), 450.39m },
                    { new Guid("7c28210b-b8b2-4dbd-bae3-1d1061f51bab"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2023, 1, 4, 21, 16, 25, 226, DateTimeKind.Local).AddTicks(9235), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("123ba1e0-58bd-4382-aabe-1331ba4afd2c"), 212.12m },
                    { new Guid("7d01ae82-7c3b-4c0a-b14d-d1898f0542aa"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2022, 12, 29, 16, 3, 37, 374, DateTimeKind.Local).AddTicks(1479), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("16bee055-2583-4a0f-9045-4a5d42635c36"), 645.68m },
                    { new Guid("7d7edca3-5996-4736-a1c9-478f6316f1a8"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2023, 3, 22, 15, 11, 43, 964, DateTimeKind.Local).AddTicks(4561), "The Football Is Good For Training And Recreational Purposes", new Guid("93273d23-8695-4587-a2f9-f21a12d53164"), 684.12m },
                    { new Guid("7e70ce46-7a9c-4792-b068-70e8ba5549b4"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), new DateTime(2022, 7, 3, 10, 55, 48, 441, DateTimeKind.Local).AddTicks(5082), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("19425b5c-deb0-48e0-997b-a616f39ad01b"), 463.43m },
                    { new Guid("7e7e67da-d22c-4ae7-a1cb-45145ba2a56b"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2023, 3, 20, 4, 44, 13, 262, DateTimeKind.Local).AddTicks(2681), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("c2ca4172-c1bb-4c00-83cf-0487c6534cb6"), 879.27m },
                    { new Guid("7f549bab-4991-4684-8a91-7f76e70b61d3"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2023, 5, 29, 18, 2, 27, 933, DateTimeKind.Local).AddTicks(5292), "The Football Is Good For Training And Recreational Purposes", new Guid("afd19d7a-3145-4275-9c9f-9fc299775fa6"), 320.20m },
                    { new Guid("7fc1c539-c7c4-44c1-9864-74c936db0ea7"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), new DateTime(2022, 12, 1, 4, 10, 5, 273, DateTimeKind.Local).AddTicks(7071), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("0e135ba5-ed35-4b61-a965-8a42a68ee460"), 343.06m },
                    { new Guid("840ddab1-9393-4cdd-889d-5a228c143a02"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2022, 9, 8, 19, 9, 23, 888, DateTimeKind.Local).AddTicks(6059), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("f79ee19a-9221-4941-8b04-7d2507b674df"), 679.52m },
                    { new Guid("84588d92-f943-4c60-8949-860093d5c8ef"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2022, 12, 30, 11, 31, 32, 121, DateTimeKind.Local).AddTicks(6222), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("19425b5c-deb0-48e0-997b-a616f39ad01b"), 167.76m },
                    { new Guid("8a5e5070-d719-455d-8a08-25609cf08b0c"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2022, 9, 1, 11, 29, 37, 262, DateTimeKind.Local).AddTicks(1335), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("54e23ec1-9513-4088-8b63-11bfbd6ef093"), 543.86m },
                    { new Guid("8a74e687-0a3c-4baf-9059-b082aaca71d1"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2022, 9, 12, 12, 53, 53, 226, DateTimeKind.Local).AddTicks(7881), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("ca413443-50ff-4cc1-90fb-31531364eb98"), 492.89m },
                    { new Guid("8b14270a-a832-4846-b837-a1eca0954ddf"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2022, 8, 25, 23, 43, 16, 866, DateTimeKind.Local).AddTicks(1080), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("91fa8895-c85f-4566-aa7e-bbb4576515ed"), 404.28m },
                    { new Guid("8ec3d195-7662-434b-9538-605118bf4018"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2023, 5, 25, 19, 1, 11, 790, DateTimeKind.Local).AddTicks(7206), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("ddc3feb7-34cd-426e-adb3-5f76e56ee520"), 329.68m },
                    { new Guid("90f22647-24cb-4628-9618-6417a960cd01"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), new DateTime(2022, 12, 27, 21, 39, 20, 845, DateTimeKind.Local).AddTicks(972), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("e4ea6a65-1239-4fa0-9637-a38d0cc1ee6f"), 466.49m },
                    { new Guid("9418b431-82bc-435e-b67f-d2d0d6ac1e45"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2022, 12, 11, 7, 48, 23, 346, DateTimeKind.Local).AddTicks(7268), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("942014f9-8087-4b3e-9a5f-d46543dbc137"), 581.83m },
                    { new Guid("95f34bc2-58e6-4591-8b82-7b92c0c5e4fa"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2022, 11, 23, 21, 30, 1, 715, DateTimeKind.Local).AddTicks(1675), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("ddc3feb7-34cd-426e-adb3-5f76e56ee520"), 647.78m },
                    { new Guid("992d3975-80c8-4626-bf23-598fd645350c"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), new DateTime(2023, 2, 9, 15, 2, 18, 728, DateTimeKind.Local).AddTicks(5800), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("74922837-4c69-4fad-ad3a-4d9d65cc74ac"), 723.63m },
                    { new Guid("9c276a98-47ae-4fa9-abef-0c193c6bde44"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2023, 5, 19, 23, 32, 28, 606, DateTimeKind.Local).AddTicks(7675), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("ed1a18a7-1911-4cf4-ae50-a424bcff25b2"), 889.48m },
                    { new Guid("9df350a7-6f88-47e2-a6e3-26acd95a08b0"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), new DateTime(2022, 10, 4, 15, 11, 1, 968, DateTimeKind.Local).AddTicks(5492), "The Football Is Good For Training And Recreational Purposes", new Guid("e2d91186-f5f2-45d5-a8a7-b5a8ad0b024d"), 174.03m },
                    { new Guid("9e591189-3fce-4cc7-ab16-b147bfa78724"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2023, 3, 20, 6, 38, 24, 398, DateTimeKind.Local).AddTicks(9910), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("308f4297-ca1d-407b-9d49-36d51a32cca6"), 866.55m },
                    { new Guid("9f4a736b-450d-4b07-ab7a-014e3f3943e2"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2023, 1, 31, 17, 50, 35, 906, DateTimeKind.Local).AddTicks(6741), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("88fc9fed-100c-4d64-bf5e-f66f82530772"), 43.35m },
                    { new Guid("a2dc1ad2-4e02-461a-8f32-a377e7c2edce"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2022, 11, 30, 5, 40, 19, 955, DateTimeKind.Local).AddTicks(1261), "The Football Is Good For Training And Recreational Purposes", new Guid("f1623990-8aab-4f1b-994c-9bc64e13bdfe"), 987.92m },
                    { new Guid("a3be94cf-b339-4a3f-b9ad-23d6766b9348"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2022, 12, 5, 3, 59, 34, 83, DateTimeKind.Local).AddTicks(6170), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("74922837-4c69-4fad-ad3a-4d9d65cc74ac"), 424.17m },
                    { new Guid("a606084a-7a3d-4f05-b409-2f9a5fd8ccde"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2023, 1, 14, 4, 58, 38, 543, DateTimeKind.Local).AddTicks(7554), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("9acd025a-010f-4416-948d-0c7aa2d67f8a"), 799.85m },
                    { new Guid("aa891d67-2bb7-4319-af4f-d223c2aca9eb"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2023, 2, 12, 11, 59, 53, 876, DateTimeKind.Local).AddTicks(399), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("99d1b145-9b21-49f8-a0ab-5d9c29f076e0"), 328.16m },
                    { new Guid("aaad28a3-57d5-482d-ba26-6df03d6453a4"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2023, 3, 23, 17, 54, 13, 205, DateTimeKind.Local).AddTicks(9810), "The Football Is Good For Training And Recreational Purposes", new Guid("ee20ba2c-15cc-4ec1-816e-65c98d2f019c"), 205.13m },
                    { new Guid("b10092a8-98b8-46fe-8780-8d4a050ecb20"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2022, 12, 29, 13, 23, 44, 111, DateTimeKind.Local).AddTicks(6828), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("47f017aa-56f1-41b5-b20c-6ebaf438a54d"), 700.97m },
                    { new Guid("b3119dc9-50ad-4057-96e3-9c9813cbea82"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2022, 8, 6, 8, 13, 39, 20, DateTimeKind.Local).AddTicks(787), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("c2a68d0a-d364-4389-a9f9-ddac4764e829"), 818.18m },
                    { new Guid("b4cc7c6a-458c-4a11-913c-88733cd38295"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2022, 12, 27, 10, 29, 10, 190, DateTimeKind.Local).AddTicks(3592), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("2cd12b0d-1937-4503-85ad-37d4c2e30a6f"), 711.17m },
                    { new Guid("b51f4cc2-9b20-40e6-8f94-afabf21d4398"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2022, 7, 13, 15, 59, 50, 55, DateTimeKind.Local).AddTicks(8722), "The Football Is Good For Training And Recreational Purposes", new Guid("90aacbff-b0b6-400f-b4d1-6682892ed945"), 33.64m },
                    { new Guid("b71d7e62-2030-4594-a359-474848d940fa"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2022, 9, 10, 14, 54, 44, 715, DateTimeKind.Local).AddTicks(977), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("cfd88dd4-15e8-4b4a-8a14-d2a60053152a"), 348.30m },
                    { new Guid("b7abb4d3-2c6d-4896-b4c2-1ad7ec0adfd2"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2022, 8, 4, 1, 41, 7, 777, DateTimeKind.Local).AddTicks(290), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("eaf3457f-19df-4ac2-acd4-701f97bd97e4"), 53.80m },
                    { new Guid("bb82fd2c-4cf6-47d9-958f-9c1493f2089a"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2023, 4, 7, 7, 30, 13, 540, DateTimeKind.Local).AddTicks(4951), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("f1623990-8aab-4f1b-994c-9bc64e13bdfe"), 824.69m },
                    { new Guid("bfe05dac-4383-4a36-ae27-262e37df91c3"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2023, 3, 24, 7, 51, 16, 446, DateTimeKind.Local).AddTicks(5630), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("b3fac59a-aac4-4b7c-bd3c-9c9ee7a78059"), 790.67m },
                    { new Guid("c23c4718-44a9-4750-9e75-48f733a7eafd"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2022, 7, 29, 9, 25, 34, 150, DateTimeKind.Local).AddTicks(3091), "The Football Is Good For Training And Recreational Purposes", new Guid("91fa8895-c85f-4566-aa7e-bbb4576515ed"), 709.76m },
                    { new Guid("c65d2313-23fa-41e8-a8d7-085a14eea2ae"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2023, 3, 7, 2, 26, 24, 196, DateTimeKind.Local).AddTicks(2315), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("cac6d9b2-43a3-424c-8da1-ad87b8d282fe"), 518.31m },
                    { new Guid("c676a17a-1c7f-4beb-b7c4-c5e224293e38"), new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"), new DateTime(2022, 7, 8, 23, 45, 41, 81, DateTimeKind.Local).AddTicks(3943), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("68e78ce9-3bfe-4853-a3f4-4c8d9d828c7c"), 826.20m },
                    { new Guid("c7b93b21-8d9f-462e-8966-dcbc3202abb3"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), new DateTime(2023, 4, 16, 4, 36, 16, 700, DateTimeKind.Local).AddTicks(5031), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("631f8172-53bf-4885-b6cb-35581cad1acb"), 872.55m },
                    { new Guid("c9c1d3eb-b79d-442e-aab1-1796f9e5c9ee"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2022, 7, 13, 5, 48, 0, 306, DateTimeKind.Local).AddTicks(9201), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("e3809d00-a3e8-4113-9eeb-29bf2a675ffd"), 94.09m },
                    { new Guid("cda5e4ed-d560-4a03-a48f-1d4d7205624a"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2022, 11, 1, 5, 53, 29, 141, DateTimeKind.Local).AddTicks(9612), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("1fdfb34f-4628-4906-9991-390b35587343"), 426.21m },
                    { new Guid("d2d1c0fc-50ce-4f27-a201-cb61145aae5a"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2022, 8, 19, 16, 36, 8, 873, DateTimeKind.Local).AddTicks(331), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("e52e5cf1-46cb-4b99-b237-4f6953e98913"), 585.29m },
                    { new Guid("d4ab6626-a1ff-40a2-9794-706890399c83"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2023, 4, 26, 18, 40, 21, 778, DateTimeKind.Local).AddTicks(7885), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("4731380f-0bb5-4843-82d7-f81fd0523536"), 553.10m },
                    { new Guid("d8eacd61-2fc1-41e3-9433-e57ac2b26cfe"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2023, 5, 3, 17, 31, 45, 574, DateTimeKind.Local).AddTicks(4945), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("631f8172-53bf-4885-b6cb-35581cad1acb"), 204.60m },
                    { new Guid("d8f63b46-b55f-40ac-a5dc-49db6fd0e697"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2023, 5, 7, 16, 12, 55, 584, DateTimeKind.Local).AddTicks(7420), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("69cb1d08-b28d-4a83-b23b-ab5ce9a57217"), 592.23m },
                    { new Guid("dde1f71c-94b6-4a2b-8e3c-d1e951d52b4a"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2022, 6, 5, 19, 13, 40, 916, DateTimeKind.Local).AddTicks(5464), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("e52e5cf1-46cb-4b99-b237-4f6953e98913"), 793.17m },
                    { new Guid("df367fd8-6fe1-4064-8390-22cb6ecb73f4"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2023, 1, 21, 19, 34, 25, 526, DateTimeKind.Local).AddTicks(3927), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("0e135ba5-ed35-4b61-a965-8a42a68ee460"), 227.40m },
                    { new Guid("e273d01d-90ec-43ef-aaf8-ba18b9f3d2ab"), new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"), new DateTime(2023, 2, 10, 2, 38, 8, 6, DateTimeKind.Local).AddTicks(6227), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("c2ca4172-c1bb-4c00-83cf-0487c6534cb6"), 173.94m },
                    { new Guid("e28e2ff1-dc04-4f45-bffe-31687ee8a13c"), new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"), new DateTime(2022, 8, 28, 13, 0, 5, 972, DateTimeKind.Local).AddTicks(2747), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("011e1d9a-aed3-46a3-990e-10a1c31f9bfc"), 243.53m },
                    { new Guid("e89f0096-cfb7-4f9a-aa4b-6869cb2a35f9"), new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"), new DateTime(2022, 10, 25, 22, 9, 41, 644, DateTimeKind.Local).AddTicks(5435), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("67414a3a-5533-4f6c-a825-f6bbc74cf8eb"), 285.78m },
                    { new Guid("ecdfe2b6-8719-4e53-87d0-da9f073f6887"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2022, 6, 9, 4, 23, 31, 133, DateTimeKind.Local).AddTicks(2625), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("3e515cda-89f0-40bf-9cd6-bb9c7e30dfdc"), 772.20m },
                    { new Guid("f0be174c-6ac6-4afe-8f98-2d547a97a88b"), new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"), new DateTime(2022, 12, 12, 12, 7, 20, 843, DateTimeKind.Local).AddTicks(1436), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("afd19d7a-3145-4275-9c9f-9fc299775fa6"), 351.16m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Instruments_Categories_CategoriesId",
                table: "Instruments",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instruments_Manufacturers_ManufacturerId",
                table: "Instruments",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Countries_CountriesId",
                table: "Items",
                column: "CountriesId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Instruments_InstrumentsId",
                table: "Items",
                column: "InstrumentsId",
                principalTable: "Instruments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Manufacturers_Countries_CountriesId",
                table: "Manufacturers",
                column: "CountriesId",
                principalTable: "Countries",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instruments_Categories_CategoriesId",
                table: "Instruments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instruments_Manufacturers_ManufacturerId",
                table: "Instruments");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Countries_CountriesId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Instruments_InstrumentsId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Manufacturers_Countries_CountriesId",
                table: "Manufacturers");

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("00ffd7fd-1ff7-4579-8f61-873dfae36569"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("01323892-3037-452e-81f4-a811418a044b"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("033a475f-2128-4a44-ad41-91657f9deaea"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("0385fdcd-b3eb-4e1f-8a8e-7302de21d9f1"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("0777c651-84d8-45f9-aa92-507f4fa5ca01"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("0b83e3d3-65a2-46d0-b333-5fb4e1cd55ee"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("1026ad24-7527-45e7-b2b2-dea705679b23"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("13fb8fdb-021f-483f-8f63-2e0821f39c9d"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("152c838f-1798-4a78-929c-7da60100c22b"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("1bb85237-fcac-4a0a-a9bb-04ffb08ad6db"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("1f5e5582-ba4c-4ada-a2bb-dfbdfa0d3170"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("2102bdf2-3f88-4d3a-9450-48fc130ebe9f"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("23ca1159-1e48-4245-bb7f-010d36f70e9f"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("2500b256-82a3-4d5e-af31-57b0e7d9cc43"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("2700aa14-3900-4224-bea8-99a1c75afb75"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("2754d4e0-d668-4d62-926e-2ca220cdecda"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("3000483e-58da-4e7a-8c84-09c8b6e64919"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("30e24cd2-1729-4346-b555-060e7b2e7f78"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("34967f69-5cda-452b-b94b-1bb242c5db96"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("34e99da4-c0c9-4be7-b40e-1ab855bc6ca6"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("368a0f0a-403a-44b1-92fe-5d05584a010d"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("39248b6c-ff44-4681-8a03-88522a5b8d58"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("395dbcf0-fd77-4031-a5ec-75c2b9037313"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("3a2547be-0dc4-4428-a764-511feaa17d79"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("44575e3d-9df7-4c52-b90d-2472bd8b1e28"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("4623c4cb-f776-457b-b308-8c1fe44c7325"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("4671131d-4115-4195-9d4e-b117ed837d54"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("4ab440cb-c390-44aa-860d-fe1187734cfc"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("53d00ad3-456c-4d1d-82b3-c784d3d8c450"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("5a3e368e-b501-499e-a7e2-df83653f4932"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("5c7eb12a-64cc-4c88-9141-da3634db6c55"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("5d1ffe6e-df85-46a4-8b0b-1a499fa8d2b4"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("61b9958d-d831-498f-961e-43921d41f609"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("66eb445a-6eb4-4d2a-a889-005804b26eb0"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("67c45eca-7bef-44d0-bd04-2bd6ae194cc5"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("68a5b64d-b3b1-4ca6-8a2c-cd13f2cdecb0"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("69836f53-a67a-40c0-a98f-d340870a36c0"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("6a5fda17-2d96-43b4-afc1-6d1f3985bd70"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("707bb084-7d05-46c8-ab0e-25f3b4b7be81"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("778f6469-0467-4508-a100-db59b161abd3"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("7a13ed6c-7c7a-4c42-aed9-610f7e7b2603"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("7d2bbd7b-ccfe-44b2-9693-66f209ffe885"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("7e1d43f5-0061-432b-afc0-61c5386dc82e"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("820e72e2-9228-4558-8474-aaa77773df20"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("82b5a80a-bf3c-4c3c-a6a8-b1220942d0db"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("8cc28ea7-16d3-4d33-a9e0-4ddd3807a552"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("900b7a25-b119-4cb3-b431-50310ed0fa8c"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("9471d29d-9941-4d1d-8b27-6682e4ef7da6"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("948e4af8-1301-4377-916d-04c8e246fc90"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("998ee478-3453-46ee-91eb-9ef4baa462b9"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("9a9e1e09-50b5-4643-a9f5-c85251ad2dd2"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("9bb3f84c-4cf3-4fda-a055-ef5eec128d77"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("9d98a360-e1c9-415b-b2f8-cd4af18799e8"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("9dd67011-c124-408f-a4c6-8432dc7c8280"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("9f591232-bb0f-412f-89c8-f08fae55124e"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("9f8d012d-3d5c-47eb-b148-b3de82d2cc9a"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("a0f06e22-f84c-4062-9683-e5cf272354d9"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("a5289462-3c77-4b30-83be-d46f4753638d"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("ab92c4ff-d506-41af-a59e-7d6dbe494f3c"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("aec8a61a-05e5-4438-a221-0200d8ce7872"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("b2adfc42-224b-443f-8dca-878b61ec4e32"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("b67b6b47-ef46-48ef-8fc0-0eca25c80fed"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("bd367d82-cb8c-444b-b52e-87ee6432a3a2"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c068910d-3b63-4bbd-a21a-8208cb7e904c"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c12dd565-96d4-4b1e-8e70-9a9d2dc21ddc"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c5c13fab-08d6-4709-b1ed-71c83e0283d5"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("d08fdb86-ba5e-49be-b980-497394d4d7ac"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("d8c03ee4-9aa0-40a6-af34-b937281cee90"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("d96d0d08-f949-4739-bb6a-294e1fb30ef1"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("d9c22c93-6623-4fad-9818-5c62b94b214d"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("dc260e98-b15a-4261-945e-eb784c3e98ee"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("dc2e678f-a071-41ff-a3d3-5fd24ef64eab"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("e47632a4-13a8-4395-8b5f-1928dd85638b"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("e59549a5-df22-45cb-92a7-f136fb06256d"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("e98e38f6-c5f6-48c8-b0be-7da358156e5e"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("ee51f9e6-b07c-4803-aaf9-023ac48ccdcc"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("f65a1976-c008-4ddd-9a36-db193d1ce41e"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("f821c297-72fe-4521-96d3-8e5f6b7f1bbb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("02a8ccc7-e3e2-49ad-8dae-12242ea18192"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("07e9776e-4d9e-4143-bf60-6302e9808cef"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("09211da4-4732-43ef-940f-8579445ae8cb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("094b9ca2-c326-48e6-a47b-40b20b96a551"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0a27e334-c80f-4c76-9dc1-4541495b403d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0c086d27-9846-46ae-8d76-6a012b10e3a3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1053f973-08a3-457d-8361-8f1e9e5ee77b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("13f5cb34-b8be-4d19-86f3-8b66914a2aaf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("17eee723-49ce-449f-9bdd-52afe2be23a2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19ac9206-1f66-4cf2-bc6a-a7ca2dd2b092"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1a74e7d8-c4e6-45aa-b40c-5a6ec12e2e21"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1ebce518-01c1-4904-8d41-3f24dc2afa32"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("23429e61-6257-4cc7-ae6a-0e767df2b7c9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2a296422-d7b4-4396-81ef-ad06d91d541e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2c80c1d8-ece2-42ec-a9ca-7a1910450255"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2cb898d0-f7b8-4ada-988f-64f8fde29fe3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2fa3401d-a98c-47fc-b4f2-976e3d93f903"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("33e889ea-4022-420d-9555-437a66fa05c2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("35451c3b-e871-4b71-bb48-04544b739849"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("355c9ee2-56d8-4786-9256-07ceb9ad30d8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("37627d47-85b3-4117-b7bf-9b51d27bb091"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("412d6f50-fcc0-4ade-aa6e-b6f954ce6b28"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("43d8ff7e-75a1-4ab1-92de-dd56a006b8ee"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("440f50db-4f02-4a55-bd4d-040ab0a37af8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("450ed41f-444d-4977-a0a4-86b2c4bb0ae0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("47ce4f63-c5fa-4c4f-89ea-3ef8187807f2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4957a0d7-9e92-4315-bb17-84f54c5f7f8d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4a128b3d-f19d-44e2-b823-d650ae8bcdf3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("528094a9-54ac-4eff-86d4-222d951c48e5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("52ac4a3e-4634-478d-9e0b-522f52bac64b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("55f3779e-996c-4395-9d9d-e3f0b282de03"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5852d46d-ffd7-4a86-83f5-34e5fda70056"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("58fdf9b5-4a2d-4295-ae99-dfebceb6063b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("59ece337-f795-4137-9ee8-4fd6fc88b09e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5f31df8c-e624-4e81-be84-ad667bc37583"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("60a87199-521a-4933-bef5-eac32981cf63"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("624c41ef-3639-4ce7-a54a-fba00bc97aa7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("66710dff-b04f-4fb3-ad9b-07e6cb0ac6bf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("67c96cc6-fbfc-46cc-9010-e7d50f995428"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("688ee88b-c862-41f2-b4f0-d21dda6cd79b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6d08b585-1821-4763-9e9e-401925830022"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6dc4e4ef-79b0-491d-87a2-169be772f7fe"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6ff0ae6c-54b4-4175-82ba-caeb2a9f6600"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7557400f-52d2-4418-9be5-7aa1aef4621c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("76308c99-34f5-4fa7-b8c1-fc622fadaf2e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7651b5f2-5124-44f7-9474-acc562b3d5e6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7b385271-79f6-4ffb-ac24-ce6a662d292e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7b93f3aa-1148-4cd1-a62a-5342e2d6becf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7bc29369-431b-4758-8649-b537f3ec936f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7c28210b-b8b2-4dbd-bae3-1d1061f51bab"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7d01ae82-7c3b-4c0a-b14d-d1898f0542aa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7d7edca3-5996-4736-a1c9-478f6316f1a8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7e70ce46-7a9c-4792-b068-70e8ba5549b4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7e7e67da-d22c-4ae7-a1cb-45145ba2a56b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7f549bab-4991-4684-8a91-7f76e70b61d3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7fc1c539-c7c4-44c1-9864-74c936db0ea7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("840ddab1-9393-4cdd-889d-5a228c143a02"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("84588d92-f943-4c60-8949-860093d5c8ef"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8a5e5070-d719-455d-8a08-25609cf08b0c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8a74e687-0a3c-4baf-9059-b082aaca71d1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8b14270a-a832-4846-b837-a1eca0954ddf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8ec3d195-7662-434b-9538-605118bf4018"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("90f22647-24cb-4628-9618-6417a960cd01"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9418b431-82bc-435e-b67f-d2d0d6ac1e45"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("95f34bc2-58e6-4591-8b82-7b92c0c5e4fa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("992d3975-80c8-4626-bf23-598fd645350c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9c276a98-47ae-4fa9-abef-0c193c6bde44"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9df350a7-6f88-47e2-a6e3-26acd95a08b0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9e591189-3fce-4cc7-ab16-b147bfa78724"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9f4a736b-450d-4b07-ab7a-014e3f3943e2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a2dc1ad2-4e02-461a-8f32-a377e7c2edce"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a3be94cf-b339-4a3f-b9ad-23d6766b9348"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a606084a-7a3d-4f05-b409-2f9a5fd8ccde"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("aa891d67-2bb7-4319-af4f-d223c2aca9eb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("aaad28a3-57d5-482d-ba26-6df03d6453a4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b10092a8-98b8-46fe-8780-8d4a050ecb20"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b3119dc9-50ad-4057-96e3-9c9813cbea82"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b4cc7c6a-458c-4a11-913c-88733cd38295"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b51f4cc2-9b20-40e6-8f94-afabf21d4398"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b71d7e62-2030-4594-a359-474848d940fa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b7abb4d3-2c6d-4896-b4c2-1ad7ec0adfd2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bb82fd2c-4cf6-47d9-958f-9c1493f2089a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bfe05dac-4383-4a36-ae27-262e37df91c3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c23c4718-44a9-4750-9e75-48f733a7eafd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c65d2313-23fa-41e8-a8d7-085a14eea2ae"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c676a17a-1c7f-4beb-b7c4-c5e224293e38"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c7b93b21-8d9f-462e-8966-dcbc3202abb3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c9c1d3eb-b79d-442e-aab1-1796f9e5c9ee"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cda5e4ed-d560-4a03-a48f-1d4d7205624a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d2d1c0fc-50ce-4f27-a201-cb61145aae5a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d4ab6626-a1ff-40a2-9794-706890399c83"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d8eacd61-2fc1-41e3-9433-e57ac2b26cfe"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d8f63b46-b55f-40ac-a5dc-49db6fd0e697"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("dde1f71c-94b6-4a2b-8e3c-d1e951d52b4a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("df367fd8-6fe1-4064-8390-22cb6ecb73f4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e273d01d-90ec-43ef-aaf8-ba18b9f3d2ab"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e28e2ff1-dc04-4f45-bffe-31687ee8a13c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e89f0096-cfb7-4f9a-aa4b-6869cb2a35f9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ecdfe2b6-8719-4e53-87d0-da9f073f6887"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f0be174c-6ac6-4afe-8f98-2d547a97a88b"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("00700c40-264b-4e2d-b610-c7653cf53c5f"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("426865ce-2690-4a4a-92c1-d9e8145d0dec"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c684fc23-871b-42c4-8c9e-a53138f7048e"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("011e1d9a-aed3-46a3-990e-10a1c31f9bfc"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("0e135ba5-ed35-4b61-a965-8a42a68ee460"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("123ba1e0-58bd-4382-aabe-1331ba4afd2c"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("16bee055-2583-4a0f-9045-4a5d42635c36"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("19425b5c-deb0-48e0-997b-a616f39ad01b"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("1fdfb34f-4628-4906-9991-390b35587343"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("2271e3df-8e88-4ce7-82cb-8f446cec16c1"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("28ed713d-3d42-44d6-8462-8591eef8e85a"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("2907e46c-7bc4-4848-9343-1082e576dd24"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("2cd12b0d-1937-4503-85ad-37d4c2e30a6f"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("308f4297-ca1d-407b-9d49-36d51a32cca6"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("333af9bb-1b2b-43fd-9311-9e697db0e8f4"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("3c1ac560-3db6-43e8-994a-8149a8c9d126"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("3e515cda-89f0-40bf-9cd6-bb9c7e30dfdc"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("45dae0af-7278-4449-996f-026d8104b729"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("4731380f-0bb5-4843-82d7-f81fd0523536"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("47f017aa-56f1-41b5-b20c-6ebaf438a54d"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("54e23ec1-9513-4088-8b63-11bfbd6ef093"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("561f1d4a-b501-4d27-8bc3-427291237353"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("631f8172-53bf-4885-b6cb-35581cad1acb"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("67414a3a-5533-4f6c-a825-f6bbc74cf8eb"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("68e78ce9-3bfe-4853-a3f4-4c8d9d828c7c"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("69cb1d08-b28d-4a83-b23b-ab5ce9a57217"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("6a0618bc-a607-4ea9-9d30-17ae213e8449"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("6bd0b8fb-702d-4085-ada2-cc6ea7fa6276"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("6ce28a26-f0c2-4cb9-9fae-5a8703dc3a53"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("6eb7cf6d-ced9-48d1-b147-dff925eb3ad4"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("71033aae-382f-47c7-94f3-85e3baf02202"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("74922837-4c69-4fad-ad3a-4d9d65cc74ac"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("74e7cf4a-d976-45ad-85b7-d980b828d735"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("7821568c-4a51-47d1-aa58-fc72fff78279"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("787d4c94-7a58-4411-a6c9-bfdb371bdd0a"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("7cdf5869-107c-4f42-a087-7253f2276fe3"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("7e628891-3c7e-498d-91f3-4e9ef7fea5f0"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("88fc9fed-100c-4d64-bf5e-f66f82530772"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("905f18a1-25e9-484b-94f0-e17136e66f99"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("90aacbff-b0b6-400f-b4d1-6682892ed945"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("91fa8895-c85f-4566-aa7e-bbb4576515ed"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("93273d23-8695-4587-a2f9-f21a12d53164"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("942014f9-8087-4b3e-9a5f-d46543dbc137"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("99d1b145-9b21-49f8-a0ab-5d9c29f076e0"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("9acd025a-010f-4416-948d-0c7aa2d67f8a"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("a0525d53-1e92-49bd-8d93-3bed9c7f069a"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("a2c66f46-8242-4523-aa94-50e1cfa7ddf6"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("a6c114fb-4d11-4fc1-ae0f-d4b441f9d9c1"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("a8d70efc-7c0a-45c0-a045-1c4e65c79f46"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("afd19d7a-3145-4275-9c9f-9fc299775fa6"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("afef0f14-ae09-489e-83f0-7de620846d27"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("b3fac59a-aac4-4b7c-bd3c-9c9ee7a78059"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c09430bd-e709-40db-be9a-80d61f65e539"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c1bc9893-ccf8-417c-833b-d13671b67a19"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c2a68d0a-d364-4389-a9f9-ddac4764e829"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c2ca4172-c1bb-4c00-83cf-0487c6534cb6"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c6178ad7-20b6-434e-aa0a-b2abdad501d4"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("c785195d-70e4-45df-8ef2-4ca34b1b9efb"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("ca413443-50ff-4cc1-90fb-31531364eb98"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("cac6d9b2-43a3-424c-8da1-ad87b8d282fe"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("cfd88dd4-15e8-4b4a-8a14-d2a60053152a"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("d028a684-a97b-4ad3-be52-232a771c975a"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("d784b281-317c-408f-bfea-4bb27f3c7fd9"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("ddc3feb7-34cd-426e-adb3-5f76e56ee520"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("e2d91186-f5f2-45d5-a8a7-b5a8ad0b024d"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("e3809d00-a3e8-4113-9eeb-29bf2a675ffd"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("e4ea6a65-1239-4fa0-9637-a38d0cc1ee6f"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("e52e5cf1-46cb-4b99-b237-4f6953e98913"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("eaf3457f-19df-4ac2-acd4-701f97bd97e4"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("ed1a18a7-1911-4cf4-ae50-a424bcff25b2"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("ee20ba2c-15cc-4ec1-816e-65c98d2f019c"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("f1623990-8aab-4f1b-994c-9bc64e13bdfe"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("f55ee622-bcda-4045-95c2-fb4f23e92d08"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("f79ee19a-9221-4941-8b04-7d2507b674df"));

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: new Guid("fe482c77-fe9c-487c-995b-63d717dd3730"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("06aeda9f-a326-4954-8df5-0d4e36279659"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("14ef1995-624e-4f7b-8f4e-55d8c0110ab1"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("177dabbb-0c88-4fe8-8ace-8f06204b5a4f"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("21895625-432c-475a-b352-9eb6c93feff1"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("24411dd7-c7e7-40e1-93c8-800f05aa9e6e"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("433acc74-026e-4349-9005-f3ae1665f3ea"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("53e7911a-a109-449d-970d-0676f1780c2b"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("59803158-6615-427d-b27d-aea0f4293600"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("63d82a66-0a82-443a-bc69-182c8479e738"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("b3b5309d-b846-455e-be87-d637a9001e66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d5869b4-57d0-4b31-85c4-6a2e35e1c890"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2151d74c-cb04-4317-9d7e-bf63e622dd78"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("23acbc24-cdc3-449a-bd1a-2f07eb81d923"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71a270e9-d461-42ea-9730-3ee5418de561"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a17fc111-d4cc-48a5-b1bf-a3f3dd75561a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c456a9fa-32fb-45e9-8fd9-a2a5655714ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d75d6f3f-2126-42c1-ba07-084374877b62"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df4b1298-3308-4832-ba04-2ec274bf233b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eecf6066-45b0-4547-b01d-a445f0809982"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fbc0de3f-b70b-4a28-a009-c42e95ffc75f"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("04a0cea3-5fb6-4dea-8c58-504df04d431c"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("1839ad01-b966-4593-ae12-6f7a47c6ed97"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("1cb3ac43-0d28-430e-acb1-4ce7038c4fde"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("2303c837-fe15-4862-9eda-200a187050ae"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("3f61ebeb-ab2e-4c9b-8769-665396953634"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("42f6d1d3-74be-4bf4-b84b-586f36bd802c"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("473a0ff7-c8ff-4bf9-8f7b-8658aead94f1"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("47a063cb-9873-4edb-9c36-6794a8520bc4"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("4dd51e90-0b73-45ba-a81a-4cd6129e3353"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("6106dc71-6a3b-4bae-ad61-46ec8b3004b1"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("63951f30-a1e5-4930-a69a-27ac9b9dbc59"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("69079607-3e4c-4e26-a492-8f0bae86cc29"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("6b8ec65b-66fe-4697-8d15-4b4d41d05414"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("7586b981-181d-4526-9055-544b419d0d50"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("75b32c50-48d5-491f-88cf-8fa7aa45adff"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("7a4fbbbe-1f23-4629-8226-ed53a63dd676"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("89032284-34c2-41ca-890e-f3b3138aead0"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("91f0ca7c-4b15-419e-8254-861bfc973cf3"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("94578e04-9014-43f9-992b-1ddde3f3d043"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("9a940fe8-424d-49f7-b64c-cd42ee40e849"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("9ece79eb-3448-4e60-9ff8-c972d2c57635"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("a187271f-b349-48b1-af7e-aa03b2f3ef8d"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("a3db51ea-b378-41c5-8536-1cb6db2eca8b"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("a45f7ad5-a3c0-4192-a82a-544f1a184e65"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("a6b22823-ea2b-47e1-9c6b-5088e5154630"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("bd3859d6-b0aa-4fdd-a4a6-32986b82ef37"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("d0f16f8e-623d-46ff-8654-d48e304ba909"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("d5bf1f9c-031d-42f9-88cb-9b37f4086883"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("d6e4fd92-d29a-4a2f-8944-084e0a1d4a7f"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("d76cd596-1955-4c20-82ff-51da3342ca4b"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("d8700d7b-4b95-41af-ab37-ec70003be65b"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("d8de48e7-27c3-406a-893a-e49d1623efaf"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("dcab3221-a70c-4896-a6e7-43c91f39d887"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("ddf0c59e-df32-4ef2-8161-6c8b3ab74c48"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("e5d80b04-71b9-4037-bdc5-81adb492dff6"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("f0f6caf3-6588-4d34-87c7-2f5984aeeeb5"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("fb3fcda6-8954-4dab-b7bc-6a804bc2fed7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("196ce9ed-6269-49f9-bd02-ff6f50a9e3d4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("593c4b8b-e124-4abe-b8f3-c2ef853762c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ba043cd-eaf9-466f-8919-5a940c144c01"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b8296fb-17eb-4b87-8fbf-b7fc0e03457b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca6e53c2-2ddb-498e-a643-6de954551b21"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Instruments_Categories_CategoriesId",
                table: "Instruments",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instruments_Manufacturers_ManufacturerId",
                table: "Instruments",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Countries_CountriesId",
                table: "Items",
                column: "CountriesId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Instruments_InstrumentsId",
                table: "Items",
                column: "InstrumentsId",
                principalTable: "Instruments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Manufacturers_Countries_CountriesId",
                table: "Manufacturers",
                column: "CountriesId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

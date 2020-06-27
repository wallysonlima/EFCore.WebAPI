
namespace EFCore.WebAPI.Migrations
{
    public partial class initial : Migrations
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batalhas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable:false)
                        .Annotation("SqlServer.ValueGenerationStrateg")
                        Nome = table.Column<string>(nullable: true),
                        Descricao = table.Column<string>(nullable: true),
                        DtInicio = table.Column<string>(nullable: true),
                        DtFim = table.Column<string>(nullable: true),

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batalhas, x => x.Id");
                });

                migrationBuilder.CreateTable()
                    name: "Herois",
                    columns> table => new
                    {
                        id = table.Column<int>(nullable:false).Annotation("SqlServer.ValueGenerationStrategy", SqlServer)
                        Nome = table.Column<string>(nullable: true),
                        Batalha = table.Column<string>(nullable: false),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Herois", x => x.Id);
                        table.ForeigKey(
                            name: "FK_Herois_Batalhas_BatalhaId",
                            column: x => x.BatalhaId,
                            principalTable: "Batalhas",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade);
                        
                    });

                    migrationBuilder.CreateIndex(
                        nameof: "IX_Armas_HeroiID",
                        table: "Armas",
                        column: "HeroiId");

                    migrationBuilder.CreateIndex(
                        nameof: "IX_Armas_BatalhaId",
                        table: "Herois",
                        column: "BatalhaId");
                    )
            )

            protected override void Down(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.DropTable(
                    name:"Armas");

                migrationBuilder.DroptTable(
                    name:"Herois");
                migrationBuilder.DroptTable(
                    nameof:Batalhas
                );
                )
                )
            }
        }
    }
}
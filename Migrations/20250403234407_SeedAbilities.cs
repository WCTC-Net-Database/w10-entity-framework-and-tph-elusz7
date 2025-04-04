using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace W9_assignment_template.Migrations
{
    public partial class SeedAbilities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Abilities",
            columns: new[] { "Id", "Name", "Description", "Discriminator" },
            values: new object[,]
            {
                { 1, "Grapple", "Grapple an enemy", "Grapple" },
                { 2, "Pounce", "Pounce on an enemy", "Pounce" },
                { 3, "Shove", "Shove an enemy", "Shove" },
                { 4, "Taunt", "Taunt an enemy", "Taunt" }
            });

            // Seed character-ability relationships
            migrationBuilder.InsertData(
                table: "CharacterAbilities",
                columns: new[] { "CharactersId", "AbilitiesId" },
                values: new object[,]
                {
                { 3, 1 }, // Character 3 has GrappleAbility
                { 3, 3 }, // Character 3 has ShoveAbility
                { 1, 2 }, // Character 1 has PounceAbility
                { 1, 4 }, // Character 1 has TauntAbility
                { 2, 4 }  // Character 2 has TauntAbility
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Delete CharacterAbilities
            migrationBuilder.Sql("DELETE FROM CharacterAbilities WHERE Id IN (1, 4)");

            //Delete Abilities
            migrationBuilder.Sql("DELETE FROM Abilities WHERE Id IN (1, 4)");
        }
    }
}

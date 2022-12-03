using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KeylessEntityTypes.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"CREATE VIEW vm_PersonOrderCount
                                    AS
                                    SELECT p.Name,COUNT(*) [Count] FROM Persons p 
                                    JOIN Orders o 
                                    	ON o.PersonId = p.PersonId
                                    GROUP BY p.Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"DROP VIEW vm_PersonOrderCount");
        }
    }
}

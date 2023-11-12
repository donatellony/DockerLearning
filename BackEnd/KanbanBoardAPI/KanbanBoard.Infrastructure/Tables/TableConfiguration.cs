using KanbanBoard.Domain.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KanbanBoard.Infrastructure.Tables;

public class TableConfiguration: IEntityTypeConfiguration<Table>
{
    public void Configure(EntityTypeBuilder<Table> builder)
    {
        builder.HasKey(tab => tab.Id);
        // builder.Property(g => g.Id)
        //     .ValueGeneratedOnAdd();

    }
}
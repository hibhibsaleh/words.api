using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vinformatix.Api.Data;

namespace Words.Api.Entity
{
    // An Entity is a table for everything
    // May have entities inside of entities that are lists/tables
    // Never return an entity, make a Dto to return certain things
    // from an entity
    public class Word : IEntity
    {
        public int Id { get; set; }
        public string WordName { get; set; }
    }

    // This adds the table to the database
    public class WordConfiguration : IEntityTypeConfiguration<Word>
    {
        public void Configure(EntityTypeBuilder<Word> builder)
        {

        }
    }
}

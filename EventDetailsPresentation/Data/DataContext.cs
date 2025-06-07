using System.Collections.Generic;
using EventDetailsPresentation.Data;
using Microsoft.EntityFrameworkCore;

namespace EventDetailsPresentation.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<EventDetailsEntity> EventDetails { get; set; }
}
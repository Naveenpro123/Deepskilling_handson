public class AppDbContext : DbContext { 
 public DbSet<Product> Product { get; set; }
 public DbSet<Category> Category { get; set; }

  public string ConnectionString{get;}
  public AppDbContext(){
    ConnectionString="Server=KARTHIKEYAN;Database=RetailStore;Trusted_Connection=True;TrustServerCertificate=True";
  }

  
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
{ 
optionsBuilder.UseSqlServer (ConnectionString);
} 
}

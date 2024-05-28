using Microsoft.EntityFrameworkCore;

namespace AspwebApiwithManyRelation.Data.Entities
{
    public class CustomerDbContext:DbContext 
        //Dbcontext is primary class that is responsible for the db interaction 
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> context) : base(context)
        //base(context) meaning we are passing the args to the parent class  
        //DbContextOptions<which is type of the current class  
        {


        }
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<CustomerAddress> CustomersAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { //we are using the EF core  fluent api so, we have to define the foreign key and one->many relationship that we are
          //using in the tble 

            modelBuilder.Entity<CustomerAddress>()    // because the customer contain the foreign key relation 
            .HasOne(_ => _.Customer) // One cutomer address contain only one customer (and the customer (name) coming from the model where we define the customer
            .WithMany(_ => _.Addresses) //Similary one customer has one adress and many address also coming from (Model)  
            .HasForeignKey(_ => _.CutomerID); // it has foreign key 
             // here in the reference of customer and the address we have to gieve the navigation property  

            }

    }
}

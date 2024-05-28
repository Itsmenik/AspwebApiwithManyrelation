using System.ComponentModel.DataAnnotations;

namespace AspwebApiwithManyRelation.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; } 
        public string? LastName { get; set; }
        public  string? phone{ get; set; }  
         
        // a customer have the multiple adderess 
        public List<CustomerAddress> Addresses { get ; set; } 
         // this is navigation property that define the relation b/w the two classed 
    
    
    }
}

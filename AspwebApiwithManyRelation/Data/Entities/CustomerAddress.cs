namespace AspwebApiwithManyRelation.Data.Entities
{
    public class CustomerAddress
    {  
        public int Id { get; set; } 
        public string? City { get; set; } 
        public string? Country { get; set; }
        public int CutomerID { get; set; }

        public Customer Customer { get; set; } // One adress contain the isnggl address 


    }
}



namespace ComputerStore.Entities
{
    public class Details
    {
        public int Id { get; set; }
        
        public int Price { get; set; }
        public ICollection<Computers> Computers { get; set; }



    }
}

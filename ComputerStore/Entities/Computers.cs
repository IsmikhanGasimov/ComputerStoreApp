namespace ComputerStore.Entities
{
    public class Computers
    {
        public int Id { get; set; }
        public string MarkaName { get; set; }
        public string ModelName { get; set; }
        public int InStock { get; set; }
        public string Size { get; set; }

        public int DetailsId { get; set; }
        public Details Details { get; set; }
        public ICollection<OrderComputer> OrderComputers { get; set; }


    }
}

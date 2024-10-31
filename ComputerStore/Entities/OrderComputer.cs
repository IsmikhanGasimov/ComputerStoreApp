namespace ComputerStore.Entities
{
    public class OrderComputer
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ComputerId { get; set; }
        public Computers Computers { get; set; }
        public Order Order { get; set; }

    }
}

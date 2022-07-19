namespace Practica.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string Steam { get; set; }
        public int Card { get; set; }
        public int Card2 { get; set; }

        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }
}

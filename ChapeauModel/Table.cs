namespace ChapeauModel
{
    public enum TableStatus { Free, Occupied }
    public class Table
    {
        public int TableId { get; set; }
        public TableStatus TableStatus { get; set; }
    }
}

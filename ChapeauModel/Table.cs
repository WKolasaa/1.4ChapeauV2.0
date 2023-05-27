namespace ChapeauModel
{
    public class Table
    {
        public int TableNumber { get; set; }
        public int TableId { get; set; }
        public TableStatus TableStatus { get; set; }
        public Table(int tableNumber,TableStatus tableStatus)
        {
          this.TableNumber=tableNumber;
          this.TableStatus=tableStatus;
        }
        public Table()
        {
               
        }
    }
}

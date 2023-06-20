namespace ChapeauModel
{
    public class Table
    {
        public int TableId { get; set; }
        public TableStatus TableStatus { get; set; }
        public Table(int tableId,TableStatus tableStatus)
        {
            this.TableId = tableId;
            this.TableStatus=tableStatus;
        }
        public Table()
        {
               
        }
    }
}

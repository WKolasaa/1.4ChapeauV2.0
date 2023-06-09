﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class TableService
    {
        private readonly TableDAO tableDAO=new TableDAO();


        // Retrieves all tables
        public List<Table> GetAllTables()
        {
            try
            {
                return tableDAO.GetAllTables();
            }
            catch (Exception ex)
            {
               
                throw new Exception("An error occurred while retrieving all tables.", ex);
            }
        }

        // Retrieves a table by ID
        public Table GetTableById(int tableID)
        {
            try
            {
                return tableDAO.GetTableById(tableID);
            }
            catch (Exception ex)
            {
               
                throw new Exception($"An error occurred while retrieving table with ID {tableID}.", ex);
            }
        }

        // Updates the status of a table
        public void UpdateTableStatus(Table table)
        {
            try
            {
                tableDAO.UpdateTableStatus(table);
            }
            catch (Exception ex)
            {
                
                throw new Exception($"An error occurred while updating the status of table with ID {table.TableId}.", ex);
            }
        }

        // Frees a table by setting its status
        public void FreeTable(int tableID, TableStatus status)
        {
            try
            {
                //tableDAO.FreeItemsTable(tableID);
                Table table = GetTableById(tableID); //without deleting the items
          
                if (table != null)
                {
                    table.TableStatus = status;
                    tableDAO.UpdateTableStatus(table);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while freeing table with ID {tableID}.", ex);
            }
        }
    }

}
    

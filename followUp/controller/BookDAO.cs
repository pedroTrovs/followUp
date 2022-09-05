using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using followUp.model;
using NpgsqlTypes;

namespace followUp.controller
{
    public class BookDAO
    {
        public int create(Book b)
        {
            DB dB = null;
            int returnValue = 0;
            try
            {
                dB = new DB();
                dB.command.CommandText = "Insert into book(bookName) values(@n)";
                dB.command.Parameters.Add("@n", NpgsqlDbType.Varchar).Value = b.name;
                dB.command.Prepare();
                returnValue = dB.command.ExecuteNonQuery();
                DB.con.Close();
                return (returnValue);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when creating new book: " + ex.Message);
            }
        }
        public void createGetId(Group g)
        {
            DB dB = null;
            int id = -1;
            try
            {
                dB = new DB();
                dB.command.CommandText = "Insert into book(bookName) values(@n) returning bookId";
                dB.command.Parameters.Add("@n", NpgsqlDbType.Varchar).Value = g.name;
                dB.command.Prepare();
                id = (int)dB.command.ExecuteScalar();
                DB.con.Close();
                g.setId(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when creating new book and getting its id: " + ex.Message);
            }
        }
        public DataTable searchByName(string search)
        {
            DB dB;
            try
            {
                dB = new DB();
                dB.command.CommandText = "select bookid, bookname from book where bookname ilike @search";
                dB.command.Parameters.Add("@search", NpgsqlDbType.Varchar).Value = "%" + search + "%";
                dB.dReader = dB.command.ExecuteReader();
                dB.dTable = new DataTable();
                dB.dTable.Load(dB.dReader);
                DB.con.Close();
                dB.dTable.Columns[0].ColumnName = "Id";
                dB.dTable.Columns[1].ColumnName = "Name";
                return (dB.dTable);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when searching books by name: " + ex.Message);
            }
        }
        public DataTable SelectOnlyNames()
        {
            DB dB;
            try
            {
                dB = new DB();
                dB.command.CommandText = "select bookname from book";
                dB.dReader = dB.command.ExecuteReader();
                dB.dTable = new DataTable();
                dB.dTable.Load(dB.dReader);
                DB.con.Close();
                dB.dTable.Columns[0].ColumnName = "Name";
                return (dB.dTable);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when searching books by name: " + ex.Message);
            }
        }
        public int getIdFromName(string n)
        {
            DB dB;
            int id = -1;
            try
            {
                dB = new DB();
                dB.command.CommandText = "select bookid from book where bookname = @n";
                dB.command.Parameters.Add("@n", NpgsqlDbType.Varchar).Value = n;
                dB.command.Prepare();
                id = (int)dB.command.ExecuteScalar();
                DB.con.Close();
                return id; 
            }
            catch (Exception ex)
            {
                throw new Exception("Error when getting id from book's name: " + ex.Message);
            }
        }
        public int update(Book b)
        {
            DB dB = null;
            int returnValue = 0;
            try
            {
                dB = new DB();
                dB.command.CommandText = "Update book set bookname=@n where bookid=@bi";
                dB.command.Parameters.Add("@n", NpgsqlDbType.Varchar).Value = b.name;
                dB.command.Parameters.Add("@gi", NpgsqlDbType.Integer).Value = b.id;
                dB.command.Prepare();
                returnValue = dB.command.ExecuteNonQuery();
                DB.con.Close();
                return (returnValue);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when updating book: " + ex.Message);
            }
        }
        public int remove(int id)
        {
            DB dB = null;
            int returnValue = 0;
            try
            {
                dB = new DB();
                dB.command.CommandText = "Delete from Book where bookid=@bi";
                dB.command.Parameters.Add("@bi", NpgsqlDbType.Integer).Value = id;
                dB.command.Prepare();
                returnValue = dB.command.ExecuteNonQuery();
                DB.con.Close();
                return (returnValue);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when removing book: " + ex.Message);
            }
        }
    }
}

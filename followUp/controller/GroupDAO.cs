using followUp.model;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace followUp.controller
{
    public class GroupDAO
    {
        public int create(Group g)
        {
            DB dB = null;
            int returnValue = 0;
            try
            {
                dB = new DB();
                dB.command.CommandText = "Insert into StudGroup(groupName, classDay, classTime) values(@n, @cd, @ct, bi)";
                dB.command.Parameters.Add("@n", NpgsqlDbType.Varchar).Value = g.name;
                dB.command.Parameters.Add("@cd", NpgsqlDbType.Integer).Value = g.day;
                dB.command.Parameters.Add("@ct", NpgsqlDbType.Time).Value = g.time;
                //dB.command.Parameters.Add("@bi", NpgsqlDbType.Integer).Value = g.bookId;
                dB.command.Prepare();
                returnValue = dB.command.ExecuteNonQuery();
                DB.con.Close();
                return (returnValue);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when creating new group: " + ex.Message);
            }
        }
        public void createGetId(Group g)
        {
            DB dB = null;
            int id = -1;
            try
            {
                dB = new DB();
                dB.command.CommandText = "Insert into StudGroup(groupName, classDay, classTime, bookId) values(@n, @cd, @ct, bi) returning groupId";
                dB.command.Parameters.Add("@n", NpgsqlDbType.Varchar).Value = g.name;
                dB.command.Parameters.Add("@cd", NpgsqlDbType.Integer).Value = g.day;
                dB.command.Parameters.Add("@ct", NpgsqlDbType.Time).Value = g.time;
                dB.command.Parameters.Add("@bi", NpgsqlDbType.Integer).Value = g.bookId;
                dB.command.Prepare();
                id = (int)dB.command.ExecuteScalar();
                DB.con.Close();
                g.setId(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when creating new group and getting its id: " + ex.Message);
            }
        }
        public DataTable searchByName(string search)
        {
            DB dB;
            DataTable result, final;
            string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            try
            {
                dB = new DB();
                dB.command.CommandText = "select g.groupid, g.groupname, g.classday, g.classtime, b.bookname from book b right join studgroup g on b.bookid = g.bookid where g.groupname ilike @search order by g.classday";
                dB.command.Parameters.Add("@search",NpgsqlDbType.Varchar).Value = "%" + search + "%";
                dB.dReader = dB.command.ExecuteReader();
                dB.dTable = new DataTable();
                dB.dTable.Load(dB.dReader);
                DB.con.Close();
                result = dB.dTable;
                final = new DataTable();
                final.Columns.Add("Id");
                final.Columns.Add("Name");
                final.Columns.Add("Day");
                final.Columns.Add("Time");
                final.Columns.Add("Book");
                foreach (DataRow item in result.Rows)
                {
                    final.Rows.Add(item[0], item[1], week[Convert.ToInt32(item[2])], item[3], item[4]);
                }
                

                return (final);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when searching groups by name: " + ex.Message);
            }
        }

    }
}

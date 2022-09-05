using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using followUp.model;
using Npgsql;
using Npgsql.Util;
using NpgsqlTypes;

namespace followUp.controller
{
    public class StudentDAO
    {
        public int create(Student s)
        {
			DB dB = null;
			int returnValue = 0;
			try
			{
				dB = new DB();
                dB.command.CommandText = "Insert into Student(fullname, groupId) values(@n, @gi)";
                dB.command.Parameters.Add("@n", NpgsqlDbType.Varchar).Value = s.name;
                dB.command.Parameters.Add("@gi", NpgsqlDbType.Integer).Value = s.groupId;
                dB.command.Prepare();
				returnValue = dB.command.ExecuteNonQuery();
				DB.con.Close();
				return (returnValue);
			}
			catch (Exception ex)
			{
				throw new Exception("Error when creating new student: " + ex.Message);
			}
        }
        public void createGetId(Student s)
        {
            DB dB = null;
            int id = -1;
            try
            {
                dB = new DB();
                if(s.isInGroup)
                {
                    dB.command.CommandText = "Insert into Student(fullname, groupId) values(@n, @gi) returning studid";
                    dB.command.Parameters.Add("@n", NpgsqlDbType.Varchar).Value = s.name;
                    dB.command.Parameters.Add("@gi", NpgsqlDbType.Integer).Value = s.groupId;
                }
                else
                {
                    dB.command.CommandText = "Insert into Student(fullname, groupId) values(@n, null) returning studid";
                    dB.command.Parameters.Add("@n", NpgsqlDbType.Varchar).Value = s.name;
                }
                dB.command.Prepare();
                id = (int)dB.command.ExecuteScalar();
                DB.con.Close();
                s.setId(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when creating new student and getting their id: " + ex.Message);
            }
        }
		public int update(Student s)
		{
            DB dB = null;
            int returnValue = 0;
            try
            {
                dB = new DB();
                dB.command.CommandText = "Update Student set fullname=@n, groupid=@gi where studid=@i";
                dB.command.Parameters.Add("@n", NpgsqlDbType.Varchar).Value = s.name;
                dB.command.Parameters.Add("@gi", NpgsqlDbType.Integer).Value = s.groupId;
                dB.command.Parameters.Add("@i", NpgsqlDbType.Integer).Value = s.id;
                dB.command.Prepare();
                returnValue = dB.command.ExecuteNonQuery();
                DB.con.Close();
                return (returnValue);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when updating student: " + ex.Message);
            }
        }
        public int remove(int id)
        {
            DB dB = null;
            int returnValue = 0;
            try
            {
                dB = new DB();
                dB.command.CommandText = "Delete from Student where studid=@i";
                dB.command.Parameters.Add("@i", NpgsqlDbType.Integer).Value = id;
                dB.command.Prepare();
                returnValue = dB.command.ExecuteNonQuery();
                DB.con.Close();
                return (returnValue);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when removing student: " + ex.Message);
            }
        }
        public DataTable searchByName(string search)
        {
            DB dB = null;

            try
            {
                dB = new DB();
                dB.command.CommandText = "select s.studid, s.fullname, g.groupname, g.groupid from studgroup g right join student s on g.groupid = s.groupid where s.fullname ilike @search"; //like: casesensitive ilike: non casesensitive
                dB.command.Parameters.Add("@search", NpgsqlDbType.Varchar).Value = "%" + search + "%";
                dB.dReader = dB.command.ExecuteReader();
                dB.dTable = new DataTable();
                dB.dTable.Load(dB.dReader); //convert from postres table to c# table
                DB.con.Close();
                dB.dTable.Columns[0].ColumnName = "Student id";
                dB.dTable.Columns[1].ColumnName = "Full name";
                dB.dTable.Columns[2].ColumnName = "Group";
                dB.dTable.Columns[3].ColumnName = "Group id";
                return (dB.dTable);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when searching students by name: " + ex.Message);
            }
        }

    }
}

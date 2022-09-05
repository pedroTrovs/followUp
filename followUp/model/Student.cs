using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace followUp.model
{
    public class Student
    {
        /*
         * create table student
            (
	            studId serial primary key,
	            fullName varchar(50),
	            groupId int references studGroup(groupId)
            );
         */
        public int id { get; private set; }
        public string name { get; private set; }
        public int groupId { get; private set; }
        public bool isInGroup { get; private set; }
        public void setId(int id)
        {
            try
            {
                this.id = id;
            }
            catch (Exception ex)
            {
                throw new Exception("Error when setting student's id: " + ex.Message);
            }
        }
        public void setId(string id)
        {
            try
            {
                this.id = Convert.ToInt32(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when setting student's id: " + ex.Message);
            }
        }
        public void setName(string n)
        {
            try
            {
                this.name = n;
            }
            catch(Exception ex)
            {
                throw new Exception("Error when setting student's name: " + ex.Message);
            }
        }
        public void setGroupId(int id)
        {
            try
            {
                this.groupId = id;
            }
            catch (Exception ex)
            {
                throw new Exception("Error when setting student's group id: " + ex.Message);
            }
        }
        public void setGroupId(string id)
        {
            try
            {
                if (id.Trim().Length == 0)
                    setWhetherIsInGroup(false);
                else
                    this.groupId = Convert.ToInt32(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when setting student's group id: " + ex.Message);
            }
        }
        public void setWhetherIsInGroup(bool isInGroup)
        {
            try
            {
                this.isInGroup = isInGroup;
            }
            catch (Exception ex)
            {
                throw new Exception("Error when setting whether student is in group: " + ex.Message);
            }
        }

    }
}

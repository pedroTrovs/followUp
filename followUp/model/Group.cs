using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace followUp.model
{
    public class Group
    {
        /*
         * create table studGroup
            (
	            groupId serial primary key,
	            groupName varchar(10),
	            classDay int,
	            classTime time,
	            bookId int references book(bookId)
            );
         */
        public int id { get; private set; }
        public string name { get; private set; }
        public int day { get; private set; }
        public DateTime time { get; private set; }
        public int bookId { get; private set; }

        public void setId(int id)
        {
            try
            {
                this.id = id;
            }
            catch (Exception ex)
            {
                throw new Exception("Error when setting group's id: " + ex.Message);
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
                throw new Exception("Error when setting group's id: " + ex.Message);
            }
        }
        public void setName(string n)
        {
            try
            {
                this.name = n;
            }
            catch (Exception ex)
            {
                throw new Exception("Error when setting gorup's name: " + ex.Message);
            }
        }
        public void setDay(int d)
        {
            try
            {
                this.day = d;
            }
            catch (Exception ex)
            {
                throw new Exception("Error when setting group's class day: " + ex.Message);
            }
        }
        public void setDay(string d)
        {
            try
            {
                this.day = Convert.ToInt32(d);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when setting group's class day: " + ex.Message);
            }
        }
        public void setTime(DateTime t)
        {
            try
            {
                this.time = t;
            }
            catch (Exception ex)
            {
                throw new Exception("Error when setting group's class time: " + ex.Message); ;
            }
        }
        public void setTime(string t)
        {
            try
            {
                this.time = Convert.ToDateTime(t);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when setting group's class time: " + ex.Message); ;
            }
        }
        public void setBookId(int id)
        {
            try
            {
                this.bookId = id;
            }
            catch (Exception ex)
            {
                throw new Exception("Error when setting group's book id: " + ex.Message);
            }
        }
        public void setBookId(string id)
        {
            try
            {
                this.bookId = Convert.ToInt32(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when setting group's book id: " + ex.Message);
            }
        }
    }
}

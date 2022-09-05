using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace followUp.model
{
    public class Book
    {
        /*
         * create table book
            (
	            bookId serial primary key,
	            bookName varchar(15)
            );
         */
        public int id { get; private set; }
        public string name { get; private set; }

        public void setId(int id)
        {
            try
            {
                this.id = id;
            }
            catch(Exception ex)
            {
                throw new Exception("Error when setting book's id: " + ex.Message);
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
                throw new Exception("Error when setting book's id: " + ex.Message);
            }
        }

        public void setName(string n)
        {
            try
            {
                name = n;
            }
            catch (Exception ex)
            {
                throw new Exception("Error when setting book's name: " + ex.Message);
            }
        }
    }
}

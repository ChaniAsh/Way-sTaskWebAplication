using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dal
{
    public class DalInstance
    {
        public static Entities db = new Entities();
        public void Save()
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}

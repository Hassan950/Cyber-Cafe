using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace CCafe
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        public int CheckForUser(int ID, string password)
        {

            string StoredProcedureName = StoredProcedures.UserLogin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@password", password);
            int returnvalue = Convert.ToInt32( dbMan.ExecuteReturnScalar(StoredProcedureName, Parameters) );
            return returnvalue;
        }



        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

    }
}

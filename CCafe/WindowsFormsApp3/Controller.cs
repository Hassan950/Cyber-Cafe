using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }
        public DataTable ViewGames()
        {
            string SPN = SP.ViewGames;
            return dbMan.ExecuteReader(SPN, null);
        }
        public int SendFeedback(string msg)
        {
            string SPN = SP.InsertintoFeedback;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@description", msg);
            Parameters.Add("@cid", 44444);
            Parameters.Add("@date", System.DateTime.Today.ToString("MM-dd-yy"));
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public int SendRequest(string msg)
        {
            string SPN = SP.InsertintoFeedback;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@description", msg);
            Parameters.Add("@cid", 44444);
            Parameters.Add("@date", System.DateTime.Today.ToString("MM-dd-yy"));
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

    }
}

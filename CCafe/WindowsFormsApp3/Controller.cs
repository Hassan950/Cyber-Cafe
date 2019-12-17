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
        public DataTable ViewGames()
        {
            string SPN = StoredProcedures.ViewGames;
            return dbMan.ExecuteReader(SPN, null);
        }
        public int SendFeedback(string msg)
        {
            string SPN = StoredProcedures.InsertintoFeedback;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@description", msg);
            Parameters.Add("@cid", 44444);
            Parameters.Add("@date", System.DateTime.Today.ToString("MM-dd-yy"));
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public int SendRequest(string msg)
        {
            string SPN = StoredProcedures.InsertintoFeedback;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@description", msg);
            Parameters.Add("@cid", 44444);
            Parameters.Add("@date", System.DateTime.Today.ToString("MM-dd-yy"));
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }

        public int CheckForUser(int ID, string password)
        {

            string StoredProcedureName = StoredProcedures.UserLogin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@password", password);
            int returnvalue = Convert.ToInt32(dbMan.ExecuteReturnScalar(StoredProcedureName, Parameters));
            return returnvalue;
        }

        public int InsertCustomer(int ID, string name, string email, string phone_num)
        {

            string StoredProcedureName = StoredProcedures.InsertIntoCustomer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@name" ,name);
            Parameters.Add("@email",email);
            Parameters.Add("@phone_no", phone_num);

            return dbMan.ExecuteNonQuery(StoredProcedureName,Parameters);
        }

        public DataTable ViewAvailibleConsoles()
        {
            string StoredProcedureName = StoredProcedures.AvailableConsoles;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int UpdateConsoles(int roomNum, string consoleName, string condition)
        {
            string StoredProcedureName = StoredProcedures.EditConsoles;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@room_no", roomNum);
            Parameters.Add("@name", consoleName);
            Parameters.Add("@condition", condition);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int CreateUser(int ID, string password, int UserType = 3) //default is customer 3
        {
            string StoredProcedureName = StoredProcedures.InsertNewUser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Password", password);
            Parameters.Add("@Usertype", UserType);
            int returnvalue = Convert.ToInt32(dbMan.ExecuteReturnScalar(StoredProcedureName, Parameters));
            return returnvalue;
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
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

        public DataTable ViewGameDetails()
        {
            string SPN = StoredProcedures.ViewGameDetails;
            return dbMan.ExecuteReader(SPN, null);
        }

        public DataTable ViewFoodAndDrinks()
        {
            string SPN = StoredProcedures.ViewFoodAndDrinks;
            return dbMan.ExecuteReader(SPN, null);
        }

        public DataTable ViewConsoleName()
        {
            string SPN = StoredProcedures.ViewConsoleName;
            return dbMan.ExecuteReader(SPN, null);
        }

        public DataTable ViewRoomNumber()
        {
            string SPN = StoredProcedures.ViewRoomNumber;
            return dbMan.ExecuteReader(SPN, null);
        }

        public DataTable ViewOffers()
        {
            string SPN = StoredProcedures.View_Available_offers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@reg_date", System.DateTime.Today.ToString("yyyy-MM-dd"));
            return dbMan.ExecuteReader(SPN, Parameters);
        }


        public DataTable ViewTournaments()
        {
            string SPN = StoredProcedures.View_Available_Tournaments;
            return dbMan.ExecuteReader(SPN, null);
        }
        public int SendFeedback(string msg, string type)
        {
            string SPN = StoredProcedures.InsertintoFeedback;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@description", msg);
            Parameters.Add("@cid", 44444);
            Parameters.Add("@date", System.DateTime.Today.ToString("MM-dd-yy"));
            Parameters.Add("@type", type);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }

        public int AcceptOffer(string name)
        {
            string SPN = StoredProcedures.Insert_Offer_Customer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            Parameters.Add("@cid", 44444);
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
        public int TournamentEnroll(string name)
        {
            string SPN = StoredProcedures.Insert_Tournament_participant;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            Parameters.Add("@cid", 44444);
            Parameters.Add("@reg_date", System.DateTime.Today.ToString("yyyy-MM-dd"));
            Console.WriteLine(name);
            Console.WriteLine(System.DateTime.Today.ToString("yyyy-MM-dd"));
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

        public DataTable ViewAllTournaments()
        {
            string StoredProcedureName = StoredProcedures.View_All_Tournaments;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable ViewAllOffers()
        {
            string StoredProcedureName = StoredProcedures.View_All_Offers;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable ViewAvailibleConsoles()
        {
            string StoredProcedureName = StoredProcedures.AvailableConsoles;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int UpdateConsoles(int roomNum,string condition)
        {
            string StoredProcedureName = StoredProcedures.EditConsoles;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@room_no", roomNum);
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
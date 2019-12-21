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
        public int CustomerReserve(int rno , string gname,int CID,string stime,string etime)
        {
            /*@EID int,
	@Date date,
	@room_no int,
	@game_name varchar(20),
	@CID int,
	@start_time time,
	@end_time time*/
            string SPN = StoredProcedures.GetShift;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@stime", stime);
            int EID =  (int)dbMan.ExecuteReturnScalar(SPN, Parameters);
            Console.WriteLine(EID);
            Parameters.Clear();
            Parameters.Add("@start_time", stime);
            Parameters.Add("@end_time", etime);
            Parameters.Add("@Date", System.DateTime.Today.ToString("yyyy-MM-dd"));
            Parameters.Add("@room_no", rno);
            Parameters.Add("@CID", CID);
            Parameters.Add("@EID", EID);
            Parameters.Add("@game_name", gname);
            SPN = StoredProcedures.MakeReservation;
            return dbMan.ExecuteNonQuery(SPN, Parameters);


        }
        public DataTable ViewRooms()
        {
            string SPN = StoredProcedures.ViewRoomNumber;
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

        public int AddTournaments(string name, string date, string status, int participants)
        {
            string StoredProcedureName = StoredProcedures.EditTourn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            Parameters.Add("@date", date);
            Parameters.Add("@status", status);
            Parameters.Add("@comp_no", participants);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddOffers(string name, string type, int discount, string startdate,string enddate)
        {
            string StoredProcedureName = StoredProcedures.MakeOffer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name",name);
            Parameters.Add("@type", type);
            Parameters.Add("@discount",discount);
            Parameters.Add("@start_date",startdate);
            Parameters.Add("@end_date", enddate);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable ViewAllFeedback()
        {
            string SPN = StoredProcedures.ViewAllFeedback;
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

        public DataTable ViewCustomerID()
        {
            string StoredProcedureName = StoredProcedures.ViewCustomerID;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int UpdateConsoles(int roomNum,string condition)
        {
            string StoredProcedureName = StoredProcedures.MaintainConsoles;
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

        public DataTable ViewSupply(string type)
        {
            string StoredProcedureName = StoredProcedures.ViewSupply;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@type", type);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }


        public int BuySupplies(string name, string type, int price, int stock)
        {
            string StoredProcedureName = StoredProcedures.BuySupplies;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            Parameters.Add("@type", type);
            Parameters.Add("@price", price);
            Parameters.Add("@stock", stock);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }


        public DataTable ViewAccounts(int type)
        {
            string StoredProcedureName = StoredProcedures.ViewAccounts;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@type", type);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int InsertEmployee(int ID, string name, int salary, string start_time, string end_time)
        {
            string StoredProcedureName = StoredProcedures.HireEmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@name", name);
            Parameters.Add("@salary", salary);
            Parameters.Add("@start_time", start_time);
            Parameters.Add("@end_time", end_time);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int MakeReservationEmployee(string date , int roomNumber , string gameName , int customerID , string start_time , string end_time)
        {
            string StoredProcedureName = StoredProcedures.MakeReservationEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Date", date);
            Parameters.Add("@room_no", roomNumber);
            Parameters.Add("@game_name", gameName);
            Parameters.Add("@CID", customerID);
            Parameters.Add("@start_time", start_time);
            Parameters.Add("@end_time", end_time);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int ModifyFoodStock(string name , int stockNum)
        {
            string StoredProcedureName = StoredProcedures.ModifyFoodStock;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            Parameters.Add("@stock", stockNum);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int ModifyGameStock(string name , int stockNum)
        {
            string StoredProcedureName = StoredProcedures.ModifyGameStock;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            Parameters.Add("@total_number", stockNum);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int PlaceFoodOrder(string fName , int quantity)
        {
            string StoredProcedureName = StoredProcedures.SellOrder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", fName);
            Parameters.Add("@quantity", quantity);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertShiftLog(int ID)
        {
            string StoredProcedureName = StoredProcedures.InsertShiftLog;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return (int)dbMan.ExecuteReturnScalar(StoredProcedureName, Parameters);
        }

        public int ChangePassword(int ID, int type, string password)
        {
            string StoredProcedureName = StoredProcedures.ChangePassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@type", type);
            Parameters.Add("@password", password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable ViewConsoles()
        {
            string StoredProcedureName = StoredProcedures.ViewConsoles;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public int EditConsoles(int room_no, string name, string condition)
        {
            string StoredProcedureName = StoredProcedures.EditConsoles;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@room_no", room_no);
            Parameters.Add("@name", name);
            Parameters.Add("@condition", condition);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int EditGames(string name, int total_number)
        {
            string StoredProcedureName = StoredProcedures.EditGames;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            Parameters.Add("@total_number", total_number);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int EditRooms(int number, string type, bool available)
        {
            string StoredProcedureName = StoredProcedures.EditRooms;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@number", number);
            Parameters.Add("@type", type);
            Parameters.Add("@available", available);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
    }
}
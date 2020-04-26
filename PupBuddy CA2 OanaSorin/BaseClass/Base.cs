using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PupBuddy_CA2_OanaSorin.BaseClass
{
    public class Base
    {
       // public string CSTestBaseURL { get; set; }

        public string PupBuddyDB { get; set; }

        //public string CSTestHeadless { get; set; }
        

        public void Setup()
        {
            // CSTestBaseURL = LoadEnvironmentVariable("CSTestBaseURL");
            PupBuddyDB = LoadEnvironmentVariable("PupBuddyDB");
          
        }

        public string LoadEnvironmentVariable(string environmentVariable)
        {
            if (Environment.GetEnvironmentVariable(environmentVariable) == null)
            {
                throw (new Exception("Need environment variable :" + environmentVariable));
            }
            else
            {
                return Environment.GetEnvironmentVariable(environmentVariable);
            }




        }
        public void joinPppyOwner()
        {


            //  Server=tcp:pupbuddyserver.database.windows.net,1433;Initial Catalog=PupBuddyDB;Persist Security Info=False;User ID=PupAdmin;Password=Sorincelmare2017;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
            SqlConnection emailsqlConec = new SqlConnection(connectionString: "Server=tcp:pupbuddyserver.database.windows.net,1433;Initial Catalog=PupBuddyDB; Password = Sorincelmare2017; Connection Timeout=30; ".ToString());
            SqlConnection connectionStr = new SqlConnection(PupBuddyDB.ToString());


            string strSQL = @"select * from CloudStore.dbo.Mail where Recipient like '%testUseraksdj%' order by DateInserted desc";


            SqlDataAdapter adaptor = new SqlDataAdapter(strSQL, connectionStr);
            //SqlParameter param = new SqlParameter("@AddNewClientName", SqlDbType.NVarChar, 255);
            //param.Value = AddNewClientName;


            

        }

    }
}
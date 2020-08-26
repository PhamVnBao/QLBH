using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Login
    {
        public bool loginValid(string userName, string passWord)
        {
            bool result = false;


            //string query = "EXEC dbo.sp_KiemTraNVTonTai @MaNV";

            DataProvider dataProvider = new DataProvider();

            //object data = dataProvider.ExecuteScalar(query, new object[] { 001 });

            return result; 
        }
    }
}

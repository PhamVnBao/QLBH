using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoginDAO
    {
        public bool loginValid(string userName, string passWord)
        {
            string query = "EXEC dbo.sp_KiemTraNVTonTai @MaNV , @PassWord";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { Int32.Parse(userName), passWord });
            if (result != null && result.ToString() == "1")
                return true;
            else
                return false;
        }
    }
}

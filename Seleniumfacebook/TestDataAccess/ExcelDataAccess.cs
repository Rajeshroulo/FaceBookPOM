using Dapper;
using System.Data.OleDb;
using System.Linq;

namespace Seleniumfacebook.TestDataAccess
{
    public class ExcelDataAccess
    {
        public static string TestDataFileConnection()
        {
            var fileName = @"C:\Users\HP\source\repos\Seleniumfacebook\Seleniumfacebook\TestDataAccess\TestData.xlsx";
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", fileName);
            return con;
        }

        public static UserData GetTestData(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [DataSet$] where key='{0}'", keyName);
                var value = connection.Query<UserData>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }

    }
}

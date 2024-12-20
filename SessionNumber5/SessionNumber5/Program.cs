using Newtonsoft.Json;
using System.Collections;
using System.Xml.Serialization;
using Microsoft.Data.SqlClient;

namespace SessionNumber5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Ado.net (activex database object)
            //2- ORM (Entity framework core (EFCORE))

            //1- Connection
            //2- Command
            //3- DataReader
            //4- DataAdapter (dataset,datatable)
            //string connectionString = "Data Source=DESKTOP-TDIEBBV\\SQLEXPRESS01;Initial Catalog=OnlineStoreDb;Integrated Security=True;Trust Server Certificate=True";

            //DataAccess dataAccess = new DataAccess();
            //dataAccess.UpdateData();

            Employee employee = new Employee();
            employee.EmployeeStatus = EmployeeStatus.Resigned;

            Console.WriteLine((int)employee.EmployeeStatus);
        }
    }
}

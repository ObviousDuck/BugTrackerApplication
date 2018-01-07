using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BugTrackerApplication
{
    /// <summary>
    /// Connectionstring / Data Source for the Sql Connection. 
    /// This is used on all parts of the program where an communication must be made.
    /// </summary>
    public class EstablishConnection
    {
            public const string SqlConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\andre\\Documents\\BugTrackerDB.mdf;Integrated Security=True;Connect Timeout=30";
    }
}

using Microsoft.Data.Sqlite;
using System.Configuration;

namespace Segalla.Utils
{
    internal class AppUtils
    {
        private static string ConnectionString { get => ConfigurationManager.ConnectionStrings["System"].ConnectionString; }
        internal static SqliteConnection connection
        {
            get
            {
                var conn = new SqliteConnection(AppUtils.ConnectionString);
                conn.Open();
                conn.EnableExtensions(true);
                conn.LoadExtension("SQLite.Interop.dll", "sqlite3_json_init");
                return conn;
            }
        }

    }
}

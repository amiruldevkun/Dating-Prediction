using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Threading.Tasks;
using datingpredic_updated;

namespace datingpredic_updated
{
    public class dbAccess
    {
        private static void ScriptAnim(string ongoing, string finished) {
            Console.WriteLine(ongoing);
            using (var progress = new ProgressBar()) {
                for (int i = 0; i < 100; i++) {
                    progress.Report((double)i / 100);
                    System.Threading.Thread.Sleep(100);
                }
            }
            Console.Clear();
            Console.WriteLine(finished);
        }

        public static void openConn()
        {
            SQLiteConnection sq_conn;
            sq_conn = new SQLiteConnection("Data Source=datingpredic.db;Version=3;New=True;Compress=True;");
            try 
            {
                sq_conn.Open();
                Console.WriteLine("Connection to SQLite DB successful");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection to SQLite DB failed");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("What do you want to do?: ");
            string choice = Console.ReadLine();

            switch(choice) {
                case "1":
                    CreateTable(sq_conn);
                    break;
                case "2":
                    
                    break;
                case "3":
                    Console.WriteLine("This will make a backup of the database. Are you sure you want to proceed? (recommended if running a server) y/n: ");
                    var ansa = Console.ReadLine();
                    if (ansa == "y") {
                        SQLiteCommand sqlite_cmd;
                        sqlite_cmd = sq_conn.CreateCommand();
                        sqlite_cmd.CommandText = ".backup datingpredic.db datingpredic.db.bak";
                        sqlite_cmd.ExecuteNonQuery();
                    }
                    else{
                        Console.WriteLine("Backup cancelled. Please key in anything to exit.");
                        Console.ReadKey();
                        ScriptAnim("Closing connection to SQLite DB and exiting...", "Exited.");
                        Environment.Exit(0);
                    }
                    break;
                default:
                    Console.WriteLine("No choice was picked. Press to any keys to abort.");
                    Console.ReadKey();
                    ScriptAnim("Closing connection to SQLite DB and exiting...", "Exited.");
                    Environment.Exit(0);
                    break;
            }
        }
        static void CreateTable(SQLiteConnection sq_conn) 
        {
            SQLiteCommand sqlite_cmd;
            string nameTable;
            Random rnd = new Random();
            var randomNum = rnd.Next(1, 100);
            
            //* User-Created tables function (commented out
            //* because it's not needed for the current version)
            // Console.WriteLine("Put in a name for your new table *no space only underscores, case-sensitive*: ");
            // nameTable = Console.ReadLine();
            // if(nameTable is null) 
            // {
            //     Console.WriteLine("Continuing without table name.");
            //     ScriptAnim("Creating table...");
            //     string CreateSql = "CREATE TABLE " + "Table_" + randomNum + "(Person VARCHAR(100),Gender VARCHAR(50), Age INT, Personality VARCHAR(100))";
            //     sqlite_cmd = sq_conn.CreateCommand();
            //     sqlite_cmd.CommandText = CreateSql;
            //     sqlite_cmd.ExecuteNonQuery();
            // }
            // else{
            //     ScriptAnim("Creating table " + nameTable + "...");
            //     string CreateSql = "CREATE TABLE " + nameTable + "(Person VARCHAR(100),Gender VARCHAR(50), Age INT, Personality VARCHAR(100))";
            //     sqlite_cmd = sq_conn.CreateCommand();
            //     sqlite_cmd.CommandText = CreateSql;
            //     sqlite_cmd.ExecuteNonQuery();
            // }

            //* Table for first run of the program and
            //* for restoring the database after a delete
            ScriptAnim("Creating table...", "Table created");
            sqlite_cmd = sq_conn.CreateCommand();
            sqlite_cmd.CommandText = "CREATE TABLE datingpredic" + randomNum + "(Person VARCHAR(100)";
            sqlite_cmd.ExecuteNonQuery();
        }

        static void InsertData(SQLiteConnection sq_conn, string nameTable) 
        {
            //! still ongoing and not finished
            SQLiteCommand sqlite_cmd;
            Console.WriteLine("What is the name of the table that you want to insert data into?: ");
            sqlite_cmd = sq_conn.CreateCommand();
            var nameTable2 = Console.ReadLine();
            sqlite_cmd.CommandText = "Select name From sqlite_master Where type='table' And name='{" + nameTable2 + "}'";
        }

        static void ReadData(SQLiteConnection sq_conn) 
        {
            //? Will be finished
            SQLiteCommand sqlite_cmd;
            string ReadSql = "SELECT * FROM Sample";
            sqlite_cmd = sq_conn.CreateCommand();
            sqlite_cmd.CommandText = ReadSql;
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read()) 
            {
                Console.WriteLine("Col1: {0}", sqlite_datareader["Col1"]);
                Console.WriteLine("Col2: {0}", sqlite_datareader["Col2"]);
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader);
            }
            sq_conn.Close();
        }
    }
}
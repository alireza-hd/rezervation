using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp1
{
    class database
    {
        SQLiteConnection m_dbConnection;
        public database ()
        {
            if (!File.Exists(Application.StartupPath.ToString() + @"\DataBase.sqlite"))
            {
                SQLiteConnection.CreateFile("DataBase" + ".sqlite");
                m_dbConnection = new SQLiteConnection("Data Source=DataBase.sqlite"+ ";Version=3;");

                m_dbConnection.Open();
                
                string sql = "create table name ( user 'TEXT NOT NULL PRIMARY KEY ' , pass 'TEXT')";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery(); //if is unfind
                m_dbConnection.Close();

            }
            m_dbConnection = new SQLiteConnection("Data Source=DataBase.sqlite" + ";Version=3;");

        }
        public bool search(string user , string pass)
        {

            m_dbConnection.Open();
            string str = "select * from name  where user = '" + user +"'" ;
            SQLiteCommand command = new SQLiteCommand(str, m_dbConnection);
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(str, m_dbConnection);

            da.Fill(dt);
            
            m_dbConnection.Close();
            if (dt.Rows.Count==1)
            {
                var a = dt.Rows[0][1];
                
                if (a.ToString()==pass)
                {
                    return true;

                }
            }
            return false;
        }

    }
}

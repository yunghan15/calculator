using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;


namespace calculator
{
    /// <summary>
    /// result.xaml 的互動邏輯
    /// </summary>
    public partial class result : Page
    {
        public result()
        {
            InitializeComponent();

            //SET Height and width to match the content of the page if it differs from 
            //mainwindow
            //Application.Current.MainWindow.Height = 450;
            //Application.Current.MainWindow.Width = 450;

            List<Dictionary<string, string>> queryResult = new List<Dictionary<string, string>>();

            DataTable data = new DataTable();
            data.Columns.Add("expression", typeof(String));
            data.Columns.Add("preorder", typeof(String));
            data.Columns.Add("postorder", typeof(String));
            data.Columns.Add("decimalResult", typeof(String));
            data.Columns.Add("binaryResult", typeof(String));

            ConnectMysql conn = new ConnectMysql();
            queryResult = conn.QueryData();

            foreach(Dictionary<string, string> rowResult in queryResult)
            {
                DataRow row = data.NewRow();
                row["expression"] = rowResult["expression"];
                row["preorder"] = rowResult["preorder"];
                row["postorder"] = rowResult["postorder"];
                row["decimalResult"] = rowResult["decimalResult"];
                row["binaryResult"] = rowResult["binaryResult"];
                data.Rows.Add(row);
            }
            this.dataGrid.ItemsSource = data.DefaultView;
        }
        public class ConnectMysql
        {
            string connString = "server=127.0.0.1;" +
                "port=3306;" +
                "user id=root;" +
                "password=;" +
                "database=calculator;" +
                "charset=utf8;";

            MySqlConnection conn = new MySqlConnection();
            public List<Dictionary<string, string>> QueryData()
            {
                conn.ConnectionString = connString;
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string sql = @"SELECT * FROM result;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader data = cmd.ExecuteReader();

                List<Dictionary<string, string>> queryResult = new List<Dictionary<string, string>>();


                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        Dictionary<string, string> rowResult = new Dictionary<string, string>();
                        rowResult.Add("expression", data["expression"].ToString());
                        rowResult.Add("preorder", data["preorder"].ToString());
                        rowResult.Add("postorder", data["postorder"].ToString());
                        rowResult.Add("decimalResult", data["decimalResult"].ToString());
                        rowResult.Add("binaryResult", data["binaryResult"].ToString());
                        queryResult.Add(rowResult);
                    }
                }
                data.Close();
                return queryResult;
            }
        }

        private void deleteClick(object sender, RoutedEventArgs e)
        {
            string connString = "server=127.0.0.1;" +
                                "port=3306;" +
                                "user id=root;" +
                                "password=;" +
                                "database=calculator;" +
                                "charset=utf8;";

            MySqlConnection conn = new MySqlConnection();


            //get selected index       
            int ID = (int)dataGrid.SelectedIndex;

            //get selected expression value
            DataRowView dataRow = (DataRowView)dataGrid.SelectedItem;
            if(dataRow != null)
            {
                string expression = dataRow.Row.ItemArray[0].ToString();

                Console.WriteLine(expression);

                string sql = "DELETE FROM `result` WHERE expression = '" + expression + "';";

                Console.WriteLine(sql);

                conn.ConnectionString = connString;
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                while (dataGrid.SelectedItems.Count >= 1)
                {

                    DataRowView drv = (DataRowView)dataGrid.SelectedItem;
                    drv.Row.Delete();
                }
            }
        }

        private void previousClick(object sender, RoutedEventArgs e)
        {
            Window w = new MainWindow();
            Window win = (Window)this.Parent;
            win.Close();
            w.Show();
        }
    }
}


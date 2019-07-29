using System;
using System.Collections.Generic;
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
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        private object content;

        public MainWindow()
        {
            InitializeComponent();
            CreateDictionary();
            //this.KeyPreview = true;
            buttonEnter.Focus();
            content = Content;
        }
        //set weight
        Dictionary<string, int> opWeight = new Dictionary<string, int>();
        private void CreateDictionary()
        {
            opWeight.Add("+", 0);
            opWeight.Add("-", 0);
            opWeight.Add("*", 1);
            opWeight.Add("/", 1);
        }


        //Conver List to String
        private string ListToString(List<string> list)
        {
            string outputStr = "";
            foreach (string str in list)
                outputStr = outputStr + str;
            return outputStr;
        }

        //Reverse
        private string Reverse(string str)
        {
            char[] caArray = str.ToCharArray();
            Array.Reverse(caArray);
            string strReverse = new string(caArray);
            return strReverse;
        }
        /*private void keyInput(object sender, KeyEventArgs e)
        {

        }*/

        /*//Key Event
        private void keyInput(object sender, KeyEventArgs e)
        {
            //Digital
            /*if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                inputText.Content = inputText.Content.ToString() + e.KeyChar.ToString();
                buttonEnter.Focus();
            }
            switch (e.KeyCode)
            {
                //0
                case D0:
                case NumPad0:
                    inputText.Content = inputText.Content.ToString() + "0";
                    break;

            }

            //Else
            switch ((int)e.KeyChar)
            {
                //ECS(zeroing)
                case 27:
                    inputText.Content = postorderLabel.Content = preorderLabel.Content = decimalLabel.Content = binaryLabel.Content = "";
                    buttonEnter.Focus();
                    break;
                //Backspace
                case 8:
                    if (inputText.Content.ToString() != "")
                        inputText.Content = inputText.Content.ToString().Substring(0, inputText.Content.ToString().Length - 1);
                    buttonEnter.Focus();
                    break;
                //Additio
                case 43:
                    inputText.Content = inputText.Content.ToString() + "+";
                    buttonEnter.Focus();
                    break;
                //Substraction
                case 45:
                    inputText.Content = inputText.Content.ToString() + "-";
                    buttonEnter.Focus();
                    break;
                //Multiplication
                case 42:
                    inputText.Content = inputText.Content.ToString() + "*";
                    buttonEnter.Focus();
                    break;
                //Division
                case 47:
                    inputText.Content = inputText.Content.ToString() + "/";
                    buttonEnter.Focus();
                    break;
            }
        }*/

        //Click Event
        private void BtnClick(object sender, EventArgs e) //Button
        {
            Button btn = (Button)sender;
            inputText.Content = inputText.Content.ToString() + btn.Content.ToString();
            buttonEnter.Focus();
        }
        private void OpClick(object sender, EventArgs e) //Operator
        {
            Button btn = (Button)sender;
            inputText.Content = inputText.Content.ToString() + btn.Content.ToString();
            buttonEnter.Focus();
        }
        private void restartClick(object sender, EventArgs e) //Zeroing
        {
            inputText.Content = postorderLabel.Content = preorderLabel.Content = decimalLabel.Content = binaryLabel.Content = "";
            buttonEnter.Focus();

        }
        private void backspaceClick(object sender, EventArgs e) //Backspace
        {
            if (inputText.Content.ToString() != "")
                inputText.Content = inputText.Content.ToString().Substring(0, inputText.Content.ToString().Length - 1);
            buttonEnter.Focus();
        }
        private void enterClick(object sender, EventArgs e) //Enter
        {
            if (inputText.Content.ToString() != "")
            {
                int result = Calculate(Postorder(inputText.Content.ToString()));
                postorderLabel.Content = ListToString(Postorder(inputText.Content.ToString())); //Postorder
                preorderLabel.Content = Reverse(ListToString(Preorder(inputText.Content.ToString()))); //Preorder
                decimalLabel.Content = Convert.ToString(result); //Decimal
                binaryLabel.Content = Convert.ToString(result, 2); //Binary
            }
        }
        //Parsing
        private List<string> Parse(string input)
        {
            List<string> list = new List<string>();
            string str = "";

            foreach (char ch in input.ToCharArray())
            {
                if (ch >= 48 && ch <= 57)
                {
                    str = str + ch;
                }
                else
                {
                    list.Add(str);
                    list.Add(ch.ToString());
                    str = "";
                }
            }
            list.Add(str);
            return list;
        }

        //Preorder
        private List<string> Preorder(string input)
        {
            List<string> list = Parse(Reverse(input));
            List<string> result = new List<string>();
            Stack<string> s = new Stack<string>();

            foreach (string str in list)
            {
                if (str != "+" && str != "-" && str != "*" && str != "/") //Digit
                    result.Add(str);
                else //Operator
                {
                    if (s.Count == 0) //The stack is empty
                    {
                        s.Push(str);
                    }
                    else //The stack is not empty
                    {
                        if (opWeight[str] >= opWeight[s.Peek()])
                            s.Push(str);
                        else
                        {
                            while (s.Count != 0 && opWeight[str] < opWeight[s.Peek()])
                                result.Add(s.Pop());
                            s.Push(str);
                        }
                    }
                }
            }
            while (s.Count != 0)
                result.Add(s.Pop());

            return result;
        }

        //Postorder
        private List<string> Postorder(string input)
        {
            List<string> list = Parse(input);
            List<string> result = new List<string>();
            Stack<string> s = new Stack<string>();

            foreach (string str in list)
            {
                if (str != "+" && str != "-" && str != "*" && str != "/") //Digit
                    result.Add(str);
                else //Operator
                {
                    if (s.Count == 0) //The stack is empty
                    {
                        s.Push(str);
                    }
                    else //The stack is not empty
                    {
                        if (opWeight[str] > opWeight[s.Peek()])
                            s.Push(str);
                        else
                        {
                            while (s.Count != 0 && opWeight[str] <= opWeight[s.Peek()])
                                result.Add(s.Pop());
                            s.Push(str);
                        }
                    }
                }
            }
            while (s.Count != 0)
                result.Add(s.Pop());

            return result;
        }

        //Calculate
        private int Calculate(List<string> input)
        {
            Stack<int> s = new Stack<int>();
            int op1, op2;
            foreach (string str in input)
            {
                if (str != "+" && str != "-" && str != "*" && str != "/") //Digit
                    s.Push(Convert.ToInt32(str));
                else //Operator
                {
                    op2 = Convert.ToInt32(s.Pop());
                    op1 = Convert.ToInt32(s.Pop());
                    switch (str)
                    {
                        case "+":
                            s.Push(op1 + op2);
                            break;
                        case "-":
                            s.Push(op1 - op2);
                            break;
                        case "*":
                            s.Push(op1 * op2);
                            break;
                        case "/":
                            s.Push(op1 / op2);
                            break;
                    }
                }
            }
            return s.Pop();
        }

        //Insert
        private void insertClick(object sender, RoutedEventArgs e)
        {
            Dictionary<string, string> input = new Dictionary<string, string>();
            input.Add("expression", inputText.Content.ToString());
            input.Add("preorder", preorderLabel.Content.ToString());
            input.Add("postorder", postorderLabel.Content.ToString());
            input.Add("decimal", decimalLabel.Content.ToString());
            input.Add("binary", binaryLabel.Content.ToString());

            ConnectMysql conn = new ConnectMysql(input);
            //expression doesn't exist
            if (conn.Check() == true)
                MessageBox.Show("The expression already exists!", "Oops!");
            //expression exists
            else
                conn.Insert();

        }

        //query
        private void queryClick(object sender, RoutedEventArgs e)
        {
            this.Content = new result();

        }
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

        string expression;
        string preorder;
        string postorder;
        string decimalResult;
        string binaryResult;
        public ConnectMysql(Dictionary<string, string> input)
        {
            expression = input["expression"];
            preorder = input["preorder"];
            postorder = input["postorder"];
            decimalResult = input["decimal"];
            binaryResult = input["binary"];
        }

        //insert
        public void Insert()
        {
            if (expression != "")
            {
                string sql = @"INSERT INTO `result` 
                       (`expression`, `preorder`, `postorder`, `decimalResult`, `binaryResult`) VALUES
                       ('" + expression + "', '" + preorder + "', '" + postorder + "', '" + decimalResult + "', '" + binaryResult + "');";

                conn.ConnectionString = connString;
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        //check if data exists
        public bool Check()
        {
            string sql = @"SELECT COUNT(*) FROM `result` WHERE expression = '" + expression + "';";

            conn.ConnectionString = connString;
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int cnt = (int)(long)cmd.ExecuteScalar();
            Console.WriteLine(cnt);
            conn.Close();
            if (cnt == 0)
                return false;
            return true;
        }
    }
}

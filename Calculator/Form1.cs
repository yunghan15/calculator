using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
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

        public Form1()
        {
            InitializeComponent();
            CreateDictionary();
            this.KeyPreview = true;
            buttonEnter.Focus();
        }

        //Key Event
        private void keyInput(object sender, KeyPressEventArgs e) //Key Press
        {
            //Digital
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                inputText.Text = inputText.Text + e.KeyChar.ToString();
                buttonEnter.Focus();
            }

            //Else
            switch ((int)e.KeyChar)
            {
                //ECS(zeroing)
                case 27:
                    inputText.Text = postorderLabel.Text = preorderLabel.Text = decimalLabel.Text = binaryLabel.Text = "";
                    buttonEnter.Focus();
                    break;
                //Backspace
                case 8:
                    if (inputText.Text != "")
                        inputText.Text = inputText.Text.Substring(0, inputText.Text.Length - 1);
                    buttonEnter.Focus();
                    break;
                //Additio
                case 43:
                    inputText.Text = inputText.Text + "+";
                    buttonEnter.Focus();
                    break;
                //Substraction
                case 45:
                    inputText.Text = inputText.Text + "-";
                    buttonEnter.Focus();
                    break;
                //Multiplication
                case 42:
                    inputText.Text = inputText.Text + "*";
                    buttonEnter.Focus();
                    break;
                //Division
                case 47:
                    inputText.Text = inputText.Text + "/";
                    buttonEnter.Focus();
                    break;
            }
        }

        //Click Event
        private void BtnClick(object sender, EventArgs e) //Button
        {
            Button btn = (Button)sender;
            inputText.Text = inputText.Text + btn.Text;
            buttonEnter.Focus();
        }
        private void OpClick(object sender, EventArgs e) //Operator
        {
            Button btn = (Button)sender;
            inputText.Text = inputText.Text + btn.Text;
            buttonEnter.Focus();
        }
        private void restartClick(object sender, EventArgs e) //Zeroing
        {
            inputText.Text = postorderLabel.Text = preorderLabel.Text = decimalLabel.Text = binaryLabel.Text = "";
            buttonEnter.Focus();

        }
        private void backspaceClick(object sender, EventArgs e) //Backspace
        {
            if (inputText.Text != "")
                inputText.Text = inputText.Text.Substring(0, inputText.Text.Length - 1);
            buttonEnter.Focus();
        }
        private void enterClick(object sender, EventArgs e) //Enter
        {
            if(inputText.Text != "")
            {
                int result = Calculate(Postorder(inputText.Text));
                postorderLabel.Text = ListToString(Postorder(inputText.Text)); //Postorder
                preorderLabel.Text = Reverse(ListToString(Preorder(inputText.Text))); //Preorder
                decimalLabel.Text = Convert.ToString(result); //Decimal
                binaryLabel.Text = Convert.ToString(result, 2); //Binary
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
    }
}
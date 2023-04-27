using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_Delegate_Event
{
    //bu delegate'i sadece bu alanda kullanacağımız için namespace altında delegate tanımı yapılır
    delegate void MyDelegateHandler();
    delegate int CalculatorHandler(int num1, int num2);
    delegate string TextHandler(string text);

    public partial class DelegateForm : Form
    {
        public DelegateForm()
        {
            InitializeComponent();
        }

        MyDelegateHandler handler;
        CalculatorHandler calculatorHandler;
        TextHandler textHandler;

        private void DelegateForm_Load(object sender, EventArgs e)
        {
            handler = new MyDelegateHandler(HelloWorld);

            Helper.AddMethod(MethodOne);
            Helper.AddMethod(MethodTwo);
            Helper.AddMethod(MethodThree);

            calculatorHandler = new CalculatorHandler(Sum);
            calculatorHandler += Multiple;
            //calculatorHandler -= Multiple;

            textHandler = new TextHandler(Reverse);
            textHandler += UpperCase;
            textHandler += EncryptText;
        }

        #region GreetingHandler
        void HelloWorld()
        {
            MessageBox.Show("Hello world!");
        }

        private void greetButton_Click(object sender, EventArgs e)
        {
            handler();
        }
        #endregion

        #region HandleMethods
        void MethodOne()
        {
            MessageBox.Show("First Method");
        }

        void MethodTwo()
        {
            MessageBox.Show("Second Method");
        }
        void MethodThree()
        {
            MessageBox.Show("Third Method");
        }
        private void btnHandle_Click(object sender, EventArgs e)
        {
            Helper.Invoke();
        }
        #endregion

        #region CalculatorHandler
        int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        int Multiple(int num1, int num2)
        {
            return num1 * num2;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            MessageBox.Show(calculatorHandler(num1, num2).ToString());
            Delegate[] delegates = calculatorHandler.GetInvocationList();

            //Delegate Method details

            foreach (Delegate item in delegates)
            {
                MessageBox.Show("Method name: " + item.Method.Name);
                MessageBox.Show("Method return type: " + item.Method.ReturnType);
                int result = (int)item.DynamicInvoke(num1, num2);
                MessageBox.Show("Method result: " + result.ToString());
            }
        }
        #endregion

        #region FindandRunMethod
        string Reverse(string text)
        {
            string reversedTxt = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedTxt += text[i];
            }

            return reversedTxt;
        }

        string UpperCase(string text)
        {
            return text.ToUpper();
        }

        string EncryptText(string text)
        {
            string encryptedTxt = "";

            foreach (char item in text)
            {
                encryptedTxt += (char)(item + 1);
            }

            return encryptedTxt;
        }

        void FindAndRunMethod(string method)
        {
            Delegate[] delegates = textHandler.GetInvocationList();
            foreach (Delegate item in delegates)
            {
                if (item.Method.Name == method)
                {
                    string retunVal = item.DynamicInvoke(txtValue.Text).ToString();
                    MessageBox.Show(retunVal);
                    break;
                }
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            FindAndRunMethod("Reverse");
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            FindAndRunMethod("UpperCase");
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            FindAndRunMethod("EncryptText");
        }
        #endregion


    }
}

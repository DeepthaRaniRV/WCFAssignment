using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            int cardno = int.Parse(txtcardno.Text);
            DateTime exp = DateTime.Parse(txtexp.Text);
            int cvv=int.Parse(txtcvv.Text);
            float trans = float.Parse(txtamt.Text);
            try
            {
                ServiceReference1.CardInfoClient cc = new ServiceReference1.CardInfoClient();
                var card = cc.Transaction(cardno, exp, cvv, trans);
                if(card)
                MessageBox.Show("Transaction Succesfull");
                else
                    MessageBox.Show("Transaction Unsuccesfull");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

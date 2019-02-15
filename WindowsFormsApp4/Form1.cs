using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Chair> seats = new List<Chair>();
            var k = 30;
            var d = 0;
            for (int i = 0; i <10 ; i++)
            {
                d++;
                var button = new Button();
                button.Name = "btnTest";
                button.Text = "Seat"+" "+d;
                button.Left = k+=65;
                this.Controls.Add(button);
                var chair = new Chair();
                seats.Add(chair);
            }
            var l = 30;
            var p = 0;
            for (int c = 0; c < 10; c++)
            {
                var chairs = new Chair();
                chairs.ID = c;
                chairs.Price = "7Azn";
                seats.Add(chairs);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var button = sender as Button;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

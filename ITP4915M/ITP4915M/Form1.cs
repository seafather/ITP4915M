using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M
{
    public partial class Form1 : Form
    {
        public store store;
        public Form1()
        {
            InitializeComponent();
            GenerateButton();
            store = new store();
            this.flowLayoutPanel1.Controls.Add(store);
        }

        private void GenerateButton()
        {
        
            /*
            for(int i = 0; i < 1; i++)
            {
                Button button = new Button();
                button.Text = "wwww";

                button.Size = new Size(30, 30);
                flowLayoutPanel1.Controls.Add(button);
            }
            using (var db = new better_shopEntities())
            {
                var info1 = from i in db.items
                            select i;

                foreach(var item in info1)
                {
                    MessageBox.Show(item.Item_Weight);
                }
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ITP4915M.UI;

namespace ITP4915M.userControl
{
    public partial class itemtest : UserControl
    {
        public itemtest()
        {
            InitializeComponent();
            //this.pictureBox1.LoadAsync("https://www.apple.com/v/macbook-air/n/images/overview/macbook_air__cvqhw0f6aq82_large.jpg");
            //this.pictureBox1.LoadAsync("https://www.telon.com.tw/Upload/product/product_d_202109011729552.png");
            //this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void doubleClick(object sender, EventArgs e)
        {
            ItemDatail itemDatailView = new ItemDatail();
            itemDatailView.ShowDialog();
            
        }


    }
}

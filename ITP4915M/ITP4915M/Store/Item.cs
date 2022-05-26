using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M.UI
{
    public partial class Item : UserControl
    {
        public Item(String[] data)
        {
            InitializeComponent();
            loadItemData(data);
            
        }

        private void loadItemData(String[] data)
        {
            lableItemNum.Text = data[0];
            labelItemName.Text = data[1];
            //labelItemQty.Text = ;
            labelItemPrice.Text = "$"+ data[2];

            pictureBoxShopCart.Tag = data[0];  //As a parameter Into the shopping cart by 

        }

        private void addItemToList(object sender, MouseEventArgs e)
        {
            PictureBox control = (PictureBox)sender;
            store.bePurchasedList.Add(control.Tag.ToString());
            MessageBox.Show(store.bePurchasedList.Count.ToString());
        }
    }
}

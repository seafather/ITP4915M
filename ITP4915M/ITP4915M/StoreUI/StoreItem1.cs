using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ITP4915M.StoreUI
{
    public partial class Item : UserControl
    {
        public Item(String[] data)
        {
            InitializeComponent();
            loadItemData(data);

            /*
            Shoping_Cart shopFrom = new Shoping_Cart();
            shopFrom.ShowDialog();
            */

        }

        private void loadItemData(String[] data)
        {
            lableItemNum.Text = data[0];
            labelItemName.Text = data[1];
            //labelItemQty.Text = ;
            labelItemPrice.Text = "$"+ data[2];

            //pictureBoxShopCart.Tag = data[0];  //As a parameter Into the shopping cart by 

        }

        private void addItemToList(object sender, MouseEventArgs e)
        {
            if (Int32.Parse(labelItemQty.Text) == 0) return;

            PictureBox pitControl = (PictureBox)sender;
            store.bePurchasedList.Add(pitControl.Tag.ToString());
            

        }

        private void Item_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ITP4915M.StoreUI;

namespace ITP4915M.StoreUI
{
    public partial class StoreItem : UserControl
    {
        public StoreItem(String[] data)
        {
            InitializeComponent();
            loadItemData(data);
        }
        private void loadItemData(String[] data)
        {
            lableItemNum.Text = data[0];
            labelItemName.Text = data[1];
            labelItemQty.Text =  "1";
            labelItemPrice.Text = "$" + data[2];

        }


        private void pictureBoxShopCart_Click(object sender, EventArgs e)
        {

            addItemToList();
        }
        private void addItemToList()
        {
            if (Int32.Parse(labelItemQty.Text) == 0)
            {
                MessageBox.Show("The amount of this item inventory is 0");
                return;
            }
            //bePurchasedList.add();
            MessageBox.Show(this.lableItemNum.Text);

        }
    }
}

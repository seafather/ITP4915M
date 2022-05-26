using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ITP4915M.userControl;

namespace ITP4915M
{
    public partial class store : UserControl
    {
        public store()
        {
            InitializeComponent();
            Loaditem();
        }

        private void Loaditem()
        {
            for (int i = 0;i<13;i++)
            {
                itemtest item = new itemtest();
                flowLayoutPanel.Controls.Add(item);
            }


        }

    }
}

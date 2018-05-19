using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_NicoleCall
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            //Set all of the form control values using nameofbox.txt = deskQuote.property
            quoteDisplay.Text = System.Convert.ToString(deskQuote.FinalQuote);
            customerName.Text = deskQuote.CustomerName;
            width.Value = deskQuote.Desk.Width;
            depth.Value = deskQuote.Desk.Depth;
            drawers.Value = deskQuote.Desk.Drawers;
            desktopMaterialComboBox.Text = System.Convert.ToString(deskQuote.Desk.SurfaceMaterial);
            rushOrderComboBox.Text = System.Convert.ToString(deskQuote.RushOrder);

        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var AddQuote = (AddQuote)Tag;
            AddQuote.Show();
        }
    }
}

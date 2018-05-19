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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void loadGrid(string searchTerm)
        {
            //dataGridview1.Rows.Clear();
        }
    }
}

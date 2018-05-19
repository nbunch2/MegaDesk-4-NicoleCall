using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            string[] textData = File.ReadAllLines("quotes.txt");
            string[] orders = textData[0].Split(',');


            for (int i = 0; i < textData.Length; i++)
            {
                quotesSearch.Rows.Add(textData[i].Split(','));
            }

            //Populate the combobox
            var materials = new List<Desk.SurfaceMaterials>();

            materials = Enum.GetValues(typeof(Desk.SurfaceMaterials))
                .Cast<Desk.SurfaceMaterials>()
                .ToList();

            searchComboBox.DataSource = materials;

            //Set it to start with empty box
            searchComboBox.SelectedIndex = -1;
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

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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            

	Form form1 = new Form();
	DataGridView dataGridView1 = new DataGridView();
	dataGridView1.Dock= DockStyle.Fill;

        //Read the data from text file
	string[] textData = System.IO.File.ReadAllLines("quotes.txt");
	string[] headers = textData[0].Split(',');

        //Create and populate DataTable
	DataTable dataTable1 = new DataTable();
	foreach(string header in headers)
	    dataTable1.Columns.Add(header,typeof(string),null);
	for(int i=1; i < textData.Length; i++)
            dataTable1.Rows.Add(textData[i].Split(','));

        //Set the DataSource of DataGridView to the DataTable
	dataGridView1.DataSource = dataTable1;
	form1.Controls.Add(dataGridView1);
	form1.ShowDialog();

        
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }
    }
}

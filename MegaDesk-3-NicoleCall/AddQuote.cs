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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            //Populate the combobox
            var materials = new List<Desk.SurfaceMaterials>();

            materials = Enum.GetValues(typeof(Desk.SurfaceMaterials))
                .Cast<Desk.SurfaceMaterials>()
                .ToList();

            desktopMaterialComboBox.DataSource = materials;

            //Set it to start with empty box
            desktopMaterialComboBox.SelectedIndex = -1;

            //Populate Shipping ComboBox
            var shipping = new List<DeskQuote.Delivery>();

            shipping = Enum.GetValues(typeof(DeskQuote.Delivery))
                .Cast<DeskQuote.Delivery>()
                .ToList();

            rushOrderComboBox.DataSource = shipping;

            //Set it to start with empty box
            rushOrderComboBox.SelectedIndex = -1;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }



        private void requestQuote_Click(object sender, EventArgs e)
        {

            var desk = new Desk
            {
                Depth = (decimal)depth.Value,
                Width = (decimal)width.Value,
                Drawers = (int)drawers.Value

            };

            //This will need to change to a combo box
            //SurfaceMaterial = desktopMaterialComboBox.Value
            switch (desktopMaterialComboBox.Text.ToLower())
            {
                case "laminate":
                    desk.SurfaceMaterial = Desk.SurfaceMaterials.Laminate;
                    break;
                case "oak":
                    desk.SurfaceMaterial = Desk.SurfaceMaterials.Oak;
                    break;
                case "pine":
                    desk.SurfaceMaterial = Desk.SurfaceMaterials.Pine;
                    break;
                case "rosewood":
                    desk.SurfaceMaterial = Desk.SurfaceMaterials.Rosewood;
                    break;
                case "veneer":
                    desk.SurfaceMaterial = Desk.SurfaceMaterials.Veneer;
                    break;
            }

            var deskQuote = new DeskQuote();


            deskQuote.CustomerName = customerName.Text;
            deskQuote.Desk = desk;
            deskQuote.CurrentDate = DateTime.Now;
            deskQuote.SurfaceArea = deskQuote.GetSurfaceArea();
            //Get cost of Material
            //Get cost of delivery
            deskQuote.FinalQuote = deskQuote.GetFinalQuote();


            switch (rushOrderComboBox.Text.ToLower())
            {
                case "rush_3_day":
                    deskQuote.RushOrder = DeskQuote.Delivery.rush_3_day;
                    break;
                case "rush_5_day":
                    deskQuote.RushOrder = DeskQuote.Delivery.rush_5_day;
                    break;
                case "rush_7_day":
                    deskQuote.RushOrder = DeskQuote.Delivery.rush_7_day;
                    break;
                case "no_rush":
                    deskQuote.RushOrder = DeskQuote.Delivery.no_rush;
                    break;
            }

            try
            {
                //Get the quote Amount
                deskQuote.FinalQuote = deskQuote.GetFinalQuote();
            
                //Write it to the file
                AddQuoteToFile(deskQuote);
                //Send infor to the display quote form

                /* THIS WAS FROM BROTHER THAYNE
               DisplayQuote frmNewQuote = new DisplayQuote(deskQuote);
                frmNewQuote.Show();
                Hide();*/

                DisplayQuote DisplayNewQuoteForm = new DisplayQuote(deskQuote);
                DisplayNewQuoteForm.Tag = this;
                DisplayNewQuoteForm.Show(this);
                Hide();
            }
            catch(Exception)
            {
                   
            }
           

            //private void createTxt()
            // {
            //StreamWriter writer;
            //writer = new StreamWriter("test.txt");

            //}
        }
        private void AddQuoteToFile(DeskQuote deskQuote)
        {
            string quotesFile = @"quotes.txt";

            using (StreamWriter streamWriter = File.AppendText(quotesFile))
            {
                streamWriter.WriteLine(
                $"{deskQuote.CurrentDate}," +
                $"{deskQuote.CustomerName}," +
                $"{deskQuote.Desk.Width}," +
                $"{deskQuote.Desk.Depth}," +
                $"{deskQuote.Desk.Drawers}," +
                $"{deskQuote.Desk.SurfaceMaterial}," +
                $"{deskQuote.RushOrder}," +
                $"{deskQuote.FinalQuote}");
               
            };
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();

        }


    }
}

    


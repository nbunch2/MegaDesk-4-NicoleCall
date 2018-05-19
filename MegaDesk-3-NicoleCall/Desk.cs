using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_NicoleCall
{
    public class Desk
    {
        //ENUMS
        public enum SurfaceMaterials
        {
            Laminate,
            Oak,
            Pine,
            Rosewood,
            Veneer

        }

        //dektopMaterialComboBox.DataSource = Surface;

  

        //public String CustomerName { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public int Drawers { get; set; }
        public SurfaceMaterials SurfaceMaterial { get; set; }
        //public Rush RushOrder { get; set; }

        public decimal surfaceMaterialCost;
           
}
    }


    




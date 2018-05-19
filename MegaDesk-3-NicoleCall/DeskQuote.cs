using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_NicoleCall
{
    public class DeskQuote
    {
        //Create constants for all the types of wood? 
        const decimal COSTOF_BASE_PRICE = 200.00M;
        const decimal COSTPER_INMORE1000 = 1.00M;
        const decimal COSTPER_DRAWER = 50.00M;
        const decimal COSTOF_OAK = 200.00M;
        const decimal COSTOF_LAMINATE = 100.00M;
        const decimal COSTOF_PINE = 50.00M;
        const decimal COSTOF_ROSEWOOD = 300.00M;
        const decimal COSTOF_VENEER = 125.00M;
        const decimal RUSH_NORUSH = 0.00M;
        const decimal RUSH_3DAY_Less_THAN1000 = 60.00M;
        const decimal RUSH_5DAY_Less_THAN1000 = 40.00M;
        const decimal RUSH_7DAY_Less_THAN1000 = 30.00M;
        const decimal RUSH_3DAY_BETWEEN = 70.00M;
        const decimal RUSH_5DAY_BETWEEN = 50.00M;
        const decimal RUSH_7DAY_BETWEEN = 350.00M;
        const decimal RUSH_3DAY_GREATER_THAN2000 = 80.00M;
        const decimal RUSH_5DAY_GREATER_THAN2000 = 60.00M;
        const decimal RUSH_7DAY_GREATER_THAN2000 = 40.00M;

        //ENUMS
        public enum Delivery
        {
            rush_3_day,
            rush_5_day,
            rush_7_day,
            no_rush


        }

        public Desk Desk { get; set; }
        public string CustomerName { get; set; }
        public Delivery RushOrder { get; set; }
        public DateTime CurrentDate { get; set; }
        public Decimal FinalQuote { get; set; }
        public Decimal SurfaceArea { get; set; }

//Get The Surface Area
        public Decimal GetSurfaceArea()
        {
            var surfaceArea = this.Desk.Depth * this.Desk.Width;
            return (decimal) surfaceArea;
        }

//Get the base price of the desk
        public Decimal GetBaseCost()
        {
            decimal surfaceCost;
            decimal surfaceArea = SurfaceArea;

            if (surfaceArea <= 1000)
            {
                surfaceCost = 200;
            }
            else
            {
                decimal additionalCost = surfaceArea - 1000;
                surfaceCost = 200 + additionalCost;
            }
            return surfaceCost;
        }
//Get the Cost of the drawers
        public Decimal GetDrawersCost()
        {
            var drawerCost = this.Desk.Drawers * COSTPER_DRAWER;
            return drawerCost;
        }

        public Decimal GetDeliveryCost()
        {
            decimal deliveryCost = 0;
            switch (RushOrder)
            {
                case Delivery.rush_3_day:
                    if(SurfaceArea < 1000)
                    {
                        deliveryCost = RUSH_3DAY_Less_THAN1000;
                    }
                    else if(SurfaceArea>= 1000 && SurfaceArea < 2000)
                    {
                        deliveryCost = RUSH_3DAY_BETWEEN;
                    }
                    else if(SurfaceArea > 2000)
                    {
                        deliveryCost = RUSH_3DAY_GREATER_THAN2000;
                    }
                    break;
                case Delivery.rush_5_day:
                    if (SurfaceArea < 1000)
                    {
                        deliveryCost = RUSH_5DAY_Less_THAN1000;
                    }
                    else if (SurfaceArea >= 1000 && SurfaceArea < 2000)
                    {
                        deliveryCost = RUSH_5DAY_BETWEEN;
                    }
                    else if (SurfaceArea > 2000)
                    {
                        deliveryCost = RUSH_5DAY_GREATER_THAN2000;
                    }
                    break;
                case Delivery.rush_7_day:
                    if (SurfaceArea < 1000)
                    {
                        deliveryCost = RUSH_7DAY_Less_THAN1000;
                    }
                    else if (SurfaceArea >= 1000 && SurfaceArea < 2000)
                    {
                        deliveryCost = RUSH_7DAY_BETWEEN;
                    }
                    else if (SurfaceArea > 2000)
                    {
                        deliveryCost = RUSH_7DAY_GREATER_THAN2000;
                    }
                    break;
                default:
                    deliveryCost = RUSH_NORUSH;
                    break;
            }
            return deliveryCost;

            
        }

 //Get the cost for the surface material
        public Decimal GetSurfaceCost()
        {
            decimal surfaceCost = 0;

            switch (Desk.SurfaceMaterial)
            {
                case Desk.SurfaceMaterials.Laminate:
                    surfaceCost = COSTOF_LAMINATE;
                    break;
                case Desk.SurfaceMaterials.Oak:
                    surfaceCost = COSTOF_OAK;
                    break;
                case Desk.SurfaceMaterials.Pine:
                    surfaceCost = COSTOF_PINE;
                    break;
                case Desk.SurfaceMaterials.Rosewood:
                    surfaceCost = COSTOF_ROSEWOOD;
                    break;
                case Desk.SurfaceMaterials.Veneer:
                    surfaceCost = COSTOF_VENEER;
                    break;
            }
            return surfaceCost;
        }


 //Get the final quote
        public Decimal GetFinalQuote()
        {
            
            var drawerCost = GetDrawersCost();
            var basePrice = GetBaseCost();
            var deliveryCost = GetDeliveryCost();
            var surfaceCost = GetSurfaceCost();

            var finalQuote = basePrice + drawerCost + deliveryCost + surfaceCost;
            return finalQuote;

        }





        //try{
        //var quote = DeskQuote.GetQuote();


    //}

        //catch (Exception err){
            //MessageBox.

//}
        //BRING THE SURFACE AREA IN HERE

        double shippingCost;

        /*
        if(RushOrder == rush_3_day && surfaceArea< 1000){ shippingCost = 60}
        else if(RushOrder == rush_5_day && surfaceArea< 1000){ shippingCost = 40}
        else if(RushOrder == rush_7_day && surfaceArea< 1000){ shippingCost = 30}
        else if(RushOrder == rush_3_day && 1000>= surfaceArea < 2000){ shippingCost = 70}
        else if(RushOrder == rush_5_day && 1000>= surfaceArea< 2000){ shippingCost = 50}
        else if(RushOrder == rush_7_day && 1000>= surfaceArea< 2000){ shippingCost = 35}
        else if(RushOrder == rush_3_day && surfaceArea > 2000){ shippingCost = 80}
        else if(RushOrder == rush_5_day && surfaceArea > 2000){ shippingCost = 60}
        else if(RushOrder == rush_7_day && surfaceArea > 2000){ shippingCost = 40}
        else { shippingCost = 0};
        */

        //double finalQuote = shippingCost + surfaceCost + drawerCost + surfaceMaterialCost;



    //SOMEHOW GET THE DESK OBJECT TO COME IN HERE????




}

   

}

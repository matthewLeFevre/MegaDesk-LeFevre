using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_LeFevre.src
{
    public enum ProductionMethod : byte
    {
        normal      = 0,
        rush3day    = 1,
        rush5day    = 2,
        rush7day    = 3
    }
    public class DeskQuote
    {
        private int              QuotePrice;
        private string           CustomerName;
        private ProductionMethod ProductionMethod;
        private Desk             Desk;

        public DeskQuote() { }

        public int getQuote()
        {
            const int BaseFee = 200;
            int materialPrice = Desk.getMaterialPrice(this.Desk.getMaterial());
            int orderPrice = DeskQuote.getOrderPrice(this.ProductionMethod, this.Desk.getSurfaceArea());
            int drawerPrice = this.Desk.getDrawerCount() * 30;


            int finalPrice = materialPrice + orderPrice + drawerPrice + BaseFee;
            return finalPrice;
        }
        public static int getOrderPrice(ProductionMethod method, int sizeOfDesk)
        {
            int orderPrice;

            switch(method.ToString())
            {
                case "rush3day":
                    if(sizeOfDesk < 1000)
                    {
                        orderPrice = 60;
                    }
                    else if (sizeOfDesk > 1000 && sizeOfDesk < 2000)
                    {
                        orderPrice = 70;
                    } else
                    {
                        orderPrice = 80;
                    }
                    break;
                case "rush5day":
                    if (sizeOfDesk < 1000)
                    {
                        orderPrice = 40;
                    }
                    else if (sizeOfDesk > 1000 && sizeOfDesk < 2000)
                    {
                        orderPrice = 50;
                    }
                    else
                    {
                        orderPrice = 60;
                    }
                    break;
                case "rush7day":
                    if (sizeOfDesk < 1000)
                    {
                        orderPrice = 30;
                    }
                    else if (sizeOfDesk > 1000 && sizeOfDesk < 2000)
                    {
                        orderPrice = 35;
                    }
                    else
                    {
                        orderPrice = 40;
                    }
                    break;
                default:
                    orderPrice = 0;
                    break;
            }

            return orderPrice;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_LeFevre.src
{
    public enum DeskMaterial :byte
    {
        Pine        = 0,
        Laminate    = 1,
        Veneer      = 2,
        Oak         = 3,
        Rosewood    = 4
    }
    public class Desk
    {
        private int          Width;
        private int          Depth;
        private int          DrawerCount;
        private DeskMaterial Material;

        public Desk(int isWidth, int isDepth, int isDrawerCount, DeskMaterial isMaterial)
        {
            this.Width       = isWidth;
            this.Depth       = isDepth;
            this.DrawerCount = isDrawerCount;
            this.Material    = isMaterial;
        }

        public int getSurfaceArea()
        {
            return this.Width * this.Depth;
        }

        public int getDrawerCount()
        {
            return this.DrawerCount;
        }

        public DeskMaterial getMaterial()
        {
            return this.Material;
        }

        public static int getMaterialPrice (DeskMaterial material)
        {
            int materialPrice;
            switch (material.ToString())
            {
                case "Pine":
                    materialPrice = 50;
                    break;
                case "Laminate":
                    materialPrice = 100;
                    break;
                case "Veneer":
                    materialPrice = 125;
                    break;
                case "Oak":
                    materialPrice = 200;
                    break;
                case "Rosewood":
                    materialPrice = 300;
                    break;
                default:
                    // Throw an error
                    materialPrice = 999;
                    break;
            }

            return materialPrice;
        }
    }
}

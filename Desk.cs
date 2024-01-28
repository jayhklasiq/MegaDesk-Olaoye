using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Olaoye
{
    internal class Desk
    {

        // Width and depth constraints as constants
        public const int MinWidth = 24;
        public const int MaxWidth = 96;
        public const int MinDepth = 12;
        public const int MaxDepth = 48;
        public const int MinDrawers = 0;
        public const int MaxDrawers = 7;



        // Attributes
        private int width;
        private int depth;
        private int numberOfDrawers;
        public int SetWidth(int value)
        {
         
                if (value >= MinWidth && value <= MaxWidth)
                {
                    width = value;
                    return width;
                }
                else
                {
                    Console.WriteLine($"Width must be between {MinWidth} and {MaxWidth} inches.");
                    return -1;
                }

        }

        public int SetDepth(int value)
        {
                if (value >= MinDepth && value <= MaxDepth)
                {
                    depth = value;
                    return depth;
                }
                else
                {
                    Console.WriteLine($"Depth must be between {MinDepth} and {MaxDepth} inches.");
                    return -1;
                }
        }

        public int SetNumberOfDrawers(int value)
        {
            if (value >= MinDrawers && value <= MaxDrawers)
            {
                numberOfDrawers = value;
                return numberOfDrawers;
            }
            else
            {
                Console.WriteLine($"Number of drawers must be between {MinDrawers} and {MaxDrawers}.");
                return -1;
            }
        }


        public int NumberOfDrawers
        {
            get { return numberOfDrawers; }
            set { SetNumberOfDrawers(value); }
        }
        public SurfaceMaterial SurfaceMaterial { get; set; }
        public RushOrderOption RushOrderOption { get; set; }

        public Desk(int width, int depth, int numberOfDrawers, SurfaceMaterial surfaceMaterial)
        {
            SetWidth(width);
            SetDepth(depth);
            SetNumberOfDrawers(numberOfDrawers);
            SurfaceMaterial = surfaceMaterial;
        }

    }

    // Enum for SurfaceMaterial
    public enum SurfaceMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }
    // Define the RushOrderOption enum
    public enum RushOrderOption
    {
        Normal = 14,
        ThreeDays = 3,
        FiveDays = 5,
        SevenDays = 7
    }

}


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_GiaoDien
{
    public static class ThemeColor
    {
        public static List<string> ColorList = new List<string>() { "#251D3A",
                                                                     "#000957",
                                                                     "#000B49",
                                                                     "#0A043C",
                                                                     "#1A1A2E",
                                                                     "#090057",
                                                                     "#000272",
                                                                     "#01005E",
                                                                     "#1F024C",
                                                                     "#001F3F",
                                                                     //"#3F3703"
                                                                     //"#EA4833",
                                                                     //"#EF937E",
                                                                     //"#F37521",
                                                                     //"#A12059",
                                                                     //"#126881",
                                                                     //"#8BC240",
                                                                     //"#364D5B",
                                                                     //"#C7DC5B",
                                                                     //"#0094BC",
                                                                     //"#E4126B",
                                                                     //"#43B76E",
                                                                     //"#7BCFE9",
                                                                     //"#B71C46"
                                                                     };
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than e, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color. T
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

    }
}

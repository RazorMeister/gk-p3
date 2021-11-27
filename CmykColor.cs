using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gk_p3
{
    internal class CmykColor
    {
        public double Cyan { get; set; } = 0.0;
        public double Magenta { get; set; }
        public double Yellow { get; set; }
        public double Black { get; set; }

        public CmykColor(int cyan, int magenta, int yellow, int black)
        {
            this.Cyan = cyan;
            this.Magenta = magenta;
            this.Yellow = yellow;
            this.Black = black;
        }

        public CmykColor(Color argbColor)
        {
            double r = argbColor.R / 255.0;
            double g = argbColor.G / 255.0;
            double b = argbColor.B / 255.0;

            double cB, cC = 0, cM = 0, cY = 0;

            cB = 1 - Math.Max(r, Math.Max(g, b));

            if (cB < 1)
            {
                cC = (1 - r - cB) / (1 - cB);
                cM = (1 - g - cB) / (1 - cB);
                cY = (1 - b - cB) / (1 - cB);
            }

            this.Cyan = Math.Round(Math.Max(0, Math.Min(1, cC)), 2);
            this.Magenta = Math.Round(Math.Max(0, Math.Min(1, cM)), 2);
            this.Yellow = Math.Round(Math.Max(0, Math.Min(1, cY)), 2);
            this.Black = Math.Round(Math.Max(0, Math.Min(1, cB)), 2);
        }

        public Color CyanToColor(Curve? curve = null)
        {
            double cyan = curve?.GetYByX(this.Cyan) ?? this.Cyan;
            return Color.FromArgb(255, (int)(255 * (1 - cyan)), 255, 255);
        }

        public Color MagentaToColor(Curve? curve = null)
        {
            double magenta = curve?.GetYByX(this.Magenta) ?? this.Magenta;
            return Color.FromArgb(255, 255, (int)(255 * (1 - magenta)), 255);
        }

        public Color YellowToColor(Curve? curve = null)
        {
            double yellow = curve?.GetYByX(this.Yellow) ?? this.Yellow;
            return Color.FromArgb(255, 255, 255, (int)(255 * (1 - yellow)));
        }

        public Color BlackToColor(Curve? curve = null)
        {
            double black = curve?.GetYByX(this.Black) ?? this.Black;
            return Color.FromArgb(255, (int)(255 * (1 - black)), (int)(255 * (1 - black)), (int)(255 * (1 - black)));
        }

        public Color ToColor(Curve cyanCurve, Curve magentaCurve, Curve yellowCurve, Curve blackCurve)
        {
            double cyan = cyanCurve.GetYByX(this.Cyan);
            double magenta = magentaCurve.GetYByX(this.Magenta);
            double yellow = yellowCurve.GetYByX(this.Yellow);
            double black = blackCurve.GetYByX(this.Black);

            return Color.FromArgb(
                255,
                (int)(255 * (1 - cyan) * (1 - black)),
                (int)(255 * (1 - magenta) * (1 - black)),
                (int)(255 * (1 - yellow) * (1 - black))
            );
        }

        public Color ComponentToColor(Settings.CMYK cmykColor, Curve? curve = null)
        {
            switch (cmykColor)
            {
                case Settings.CMYK.CYAN:
                    return this.CyanToColor(curve);
                case Settings.CMYK.MAGENTA:
                    return this.MagentaToColor(curve);
                case Settings.CMYK.YELLOW:
                    return this.YellowToColor(curve);
                default:
                    return this.BlackToColor(curve);
            }
        }
    }
}

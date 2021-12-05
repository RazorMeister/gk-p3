using System.Collections.Concurrent;

namespace gk_p3
{
    internal class CmykColor
    {
        public double Cyan { get; set; }
        public double Magenta { get; set; }
        public double Yellow { get; set; }
        public double Black { get; set; }

        public double OriginalCyan { get; set; }
        public double OriginalMagenta { get; set; }
        public double OriginalYellow { get; set; }
        public double OriginalBlack { get; set; }

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

            cC = 1 - r;
            cM = 1 - g;
            cY = 1 - b;

            this.OriginalCyan = Math.Round(Math.Max(0, Math.Min(1, cC)), 2);
            this.OriginalMagenta = Math.Round(Math.Max(0, Math.Min(1, cM)), 2);
            this.OriginalYellow = Math.Round(Math.Max(0, Math.Min(1, cY)), 2);
            this.OriginalBlack = Math.Round(Math.Max(0, Math.Min(1, cB)), 2);
        }

        public Color CyanToColor(Curve? curve = null, bool blackAndWhite = false)
        {
            double cyan = curve?.GetYByX(this.Cyan) ?? this.Cyan;
            int part = (int)(255 * (1 - cyan));

            return blackAndWhite ? Color.FromArgb(255, part, part, part) : Color.FromArgb(255, part, 255, 255);
        }

        public Color MagentaToColor(Curve? curve = null, bool blackAndWhite = false)
        {
            double magenta = curve?.GetYByX(this.Magenta) ?? this.Magenta;
            int part = (int)(255 * (1 - magenta));

            return blackAndWhite ? Color.FromArgb(255, part, part, part) : Color.FromArgb(255, 255, part, 255);
        }

        public Color YellowToColor(Curve? curve = null, bool blackAndWhite = false)
        {
            double yellow = curve?.GetYByX(this.Yellow) ?? this.Yellow;
            int part = (int)(255 * (1 - yellow));

            return blackAndWhite ? Color.FromArgb(255, part, part, part) : Color.FromArgb(255, 255, 255, part);
        }

        public Color BlackToColor(Curve? curve = null)
        {
            double black = curve?.GetYByX(this.Black) ?? this.Black;
            return Color.FromArgb(255, (int)(255 * (1 - black)), (int)(255 * (1 - black)), (int)(255 * (1 - black)));
        }

        public Color ToColor(Curve cyanCurve, Curve magentaCurve, Curve yellowCurve, Curve blackCurve)
        {
            double cyan = this.Cyan;
            double magenta = this.Magenta;
            double yellow = this.Yellow;
            double black = this.Black;

            return Color.FromArgb(
                255,
                (int)(255 * (1 - cyan) * (1 - black)),
                (int)(255 * (1 - magenta) * (1 - black)),
                (int)(255 * (1 - yellow) * (1 - black))
            );
        }

        public void SetNewColors(ConcurrentDictionary<Settings.CMYK, Curve> curves)
        {
            double kPrim = Math.Min(this.OriginalCyan, Math.Min(this.OriginalMagenta, this.OriginalYellow));

            this.Cyan = Math.Max(0.0, Math.Min(1.0, this.OriginalCyan - kPrim + curves[Settings.CMYK.CYAN].GetYByX(kPrim)));
            this.Magenta = Math.Max(0.0, Math.Min(1.0, this.OriginalMagenta - kPrim + curves[Settings.CMYK.MAGENTA].GetYByX(kPrim)));
            this.Yellow = Math.Max(0.0, Math.Min(1.0, this.OriginalYellow - kPrim + curves[Settings.CMYK.YELLOW].GetYByX(kPrim)));
            this.Black = Math.Max(0.0, Math.Min(1.0, curves[Settings.CMYK.BLACK].GetYByX(kPrim)));
        }

        public Color ComponentToColor(Settings.CMYK cmykColor, Curve? curve = null, bool blackAndWhite = false)
        {
            curve = null;

            switch (cmykColor)
            {
                case Settings.CMYK.CYAN:
                    return this.CyanToColor(curve, blackAndWhite);
                case Settings.CMYK.MAGENTA:
                    return this.MagentaToColor(curve, blackAndWhite);
                case Settings.CMYK.YELLOW:
                    return this.YellowToColor(curve, blackAndWhite);
                default:
                    return this.BlackToColor(curve);
            }
        }

        public static Color GetColorByEnum(Settings.CMYK smykColor)
        {
            switch(smykColor)
            {
                case Settings.CMYK.CYAN:
                    return Color.Cyan;
                case Settings.CMYK.MAGENTA:
                    return Color.Magenta;
                case Settings.CMYK.YELLOW:
                    return Color.Yellow;
                default:
                    return Color.Black;
            }
        }
    }
}

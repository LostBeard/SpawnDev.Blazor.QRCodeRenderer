using QRCoder;
using static QRCoder.SvgQRCode;

namespace SpawnDev.Blazor.QRCodeRenderer
{
    /// <summary>
    /// Extension methods for SvgQRCode
    /// </summary>
    public static class SvgQRCodeExtensions
    {
        /// <summary>
        /// Returns a QR code as SVG string with custom colors (in HEX syntax), optional quietzone and logo
        /// </summary>
        /// <param name="_this"></param>
        /// <param name="style"></param>
        /// <param name="pixelsPerModule"></param>
        /// <param name="darkColorHex"></param>
        /// <param name="lightColorHex"></param>
        /// <param name="drawQuietZones"></param>
        /// <param name="sizingMode"></param>
        /// <param name="logo"></param>
        /// <returns></returns>
        public static string GetGraphic(this SvgQRCode _this, string style, int pixelsPerModule, string darkColorHex, string lightColorHex, bool drawQuietZones = true, SizingMode sizingMode = SizingMode.ViewBoxAttribute, SvgLogo? logo = null)
        {
            var svg = _this.GetGraphic(pixelsPerModule, darkColorHex, lightColorHex, drawQuietZones, sizingMode, logo);
            return $"<svg style=\"{style}\"" + svg.Substring(svg.IndexOf(" "));
        }
    }
}

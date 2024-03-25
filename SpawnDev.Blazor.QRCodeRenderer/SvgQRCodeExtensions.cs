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
        /// <param name="attributes"></param>
        /// <param name="pixelsPerModule"></param>
        /// <param name="darkColorHex"></param>
        /// <param name="lightColorHex"></param>
        /// <param name="drawQuietZones"></param>
        /// <param name="sizingMode"></param>
        /// <param name="logo"></param>
        /// <returns></returns>
        public static string GetGraphic(this SvgQRCode _this, string attributes, int pixelsPerModule, string darkColorHex, string lightColorHex, bool drawQuietZones = true, SizingMode sizingMode = SizingMode.ViewBoxAttribute, SvgLogo? logo = null)
        {
            var svg = _this.GetGraphic(pixelsPerModule, darkColorHex, lightColorHex, drawQuietZones, sizingMode, logo);
            return $"<svg {attributes}" + svg.Substring(svg.IndexOf(" "));
        }
        /// <summary>
        /// Returns a QR code as SVG string with custom colors (in HEX syntax), optional quietzone and logo
        /// </summary>
        /// <param name="_this"></param>
        /// <param name="classNames"></param>
        /// <param name="style"></param>
        /// <param name="pixelsPerModule"></param>
        /// <param name="darkColorHex"></param>
        /// <param name="lightColorHex"></param>
        /// <param name="drawQuietZones"></param>
        /// <param name="sizingMode"></param>
        /// <param name="logo"></param>
        /// <returns></returns>
        public static string GetGraphic(this SvgQRCode _this, string classNames, string style, int pixelsPerModule, string darkColorHex, string lightColorHex, bool drawQuietZones = true, SizingMode sizingMode = SizingMode.ViewBoxAttribute, SvgLogo? logo = null)
        {
            var attributes = $"class=\"{classNames}\" style=\"{style}\"";
            return _this.GetGraphic(attributes, pixelsPerModule,darkColorHex,lightColorHex,drawQuietZones, sizingMode, logo);
        }
    }
}

using QRCoder;
using static QRCoder.SvgQRCode;

namespace SpawnDev.Blazor.QRCodeRenderer
{
    /// <summary>
    /// Extension methods for PngByteQRCode
    /// </summary>
    public static class PngByteQRCodeExtensions
    {
        /// <summary>
        /// Creates 2-color PNG of the QR code, using 1-bit indexed color. Accepts 3-byte RGB colors for normal images and 4-byte RGBA-colors for transparent images.
        /// </summary>
        /// <param name="_this"></param>
        /// <param name="pixelsPerModule"></param>
        /// <param name="darkColorHex"></param>
        /// <param name="lightColorHex"></param>
        /// <param name="drawQuietZones"></param>
        /// <returns></returns>
        public static string GetGraphicBase64(this PngByteQRCode _this, int pixelsPerModule, string darkColorHex, string lightColorHex, bool drawQuietZones = true)
        {
            var darkColorRgba = HtmlColorToBytes(darkColorHex);
            var lightColorRgba = HtmlColorToBytes(lightColorHex);
            var qrPngBytes = _this.GetGraphic(pixelsPerModule, darkColorRgba, lightColorRgba, drawQuietZones);
            return $"data:image/png;base64,{Convert.ToBase64String(qrPngBytes, Base64FormattingOptions.None)}";
        }
        /// <summary>
        /// Uses ColorTranslator.FromHtm to convert an HTML color to a byte array
        /// </summary>
        /// <param name="htmlColor"></param>
        /// <returns></returns>
        public static byte[] HtmlColorToBytes(string htmlColor)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml(htmlColor);
            return new byte[] { col.R, col.G, col.B, col.A };
        }
    }
}

namespace SpawnDev.Blazor.QRCodeRenderer
{
    /// <summary>
    /// The mode to use when rendering the QRCode
    /// </summary>
    public enum QRRenderMode
    {
        /// <summary>
        /// Render as an img element png
        /// </summary>
        ImageElementPng,
        /// <summary>
        /// Render as an svg element
        /// </summary>
        SvgElement,
        /// <summary>
        /// Do not render
        /// </summary>
        None = 65536,
    }
}

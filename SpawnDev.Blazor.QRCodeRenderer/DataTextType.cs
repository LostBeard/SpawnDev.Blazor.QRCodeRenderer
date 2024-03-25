namespace SpawnDev.Blazor.QRCodeRenderer
{
    /// <summary>
    /// DataTextType options indicate how DataText should be processed before rendering
    /// </summary>
    public enum DataTextType
    {
        /// <summary>
        /// DataText will be used as is (default)
        /// </summary>
        Text,
        /// <summary>
        /// DataText is a url relative to NavigationManager.Uri<br />
        /// The QRCode will automatically update on NavigationManager.LocationChanged events
        /// </summary>
        UriRelativeUrl,
        /// <summary>
        /// DataText is a url relative to NavigationManager.BaseUri
        /// </summary>
        BaseUriRelativeUrl,
    }
}

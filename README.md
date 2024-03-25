
# SpawnDev.Blazor.QRCodeRenderer
[![NuGet version](https://badge.fury.io/nu/SpawnDev.Blazor.QRCodeRenderer.svg)](https://www.nuget.org/packages/SpawnDev.Blazor.QRCodeRenderer) 
 
SpawnDev.Blazor.QRCodeRenderer is a pure C# QRCode renderer for Blazor based on the awesome [QRCoder](https://github.com/codebude/QRCoder) project.

### No Dependencies
The QRCode is generated in pure C# without any dependencies.

[Live Demo](https://lostbeard.github.io/SpawnDev.Blazor.QRCodeRenderer/)

Image QRCode renderer
```html
<QRCodeImage DarkColor="darkgreen" DataText="Hello world!" QRRenderMode="QRRenderMode.ImageElementPng" />
```

SVG QRCode renderer
```html
<QRCodeImage DarkColor="darkgreen" DataText="Hello world!" QRRenderMode="QRRenderMode.SvgElement" />
```

## Parameters
#### DataText ```(optional)```
- string - Text data that will be used for the QRCode if not null

#### DataBytes ```(optional)```
- byte[] - Binary data that will be used for the QRCode if not null

#### DataTextType ```(optional)```
- DataTextType - DataTextType indicates how DataText should be processed before rendering

#### Style ```(optional)```
- string - Style to apply to the img/svg element

#### ECCLevel ```(optional)```
- ECCLevel - Error Correction Level

#### PixelsPerModule ```(optional)```
- int - The pixel size each b/w module is drawn

#### DrawQuietZones ```(optional)```
- bool - If true a white border is drawn around the whole QR Code

#### DarkColor ```(optional)```
- string - The color of the dark/black modules in html notation

#### LightColor ```(optional)```
- string - The color of the light/white modules in html notation

#### AutoUpdateUriRelativeUrls ```(optional)```
- bool - If true (default) a DataTextType.UriRelativeUrl DataText URL will automatically be updated when a NavigationManager.LocationChanged event fires

#### QRRenderMode ```(optional)```
- QRRenderMode - The mode to use when rendering the QRCode


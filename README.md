
# SpawnDev.Blazor.QRCodeRenderer
[![NuGet version](https://badge.fury.io/nu/SpawnDev.Blazor.QRCodeRenderer.svg)](https://www.nuget.org/packages/SpawnDev.Blazor.QRCodeRenderer) 
 
SpawnDev.Blazor.QRCodeRenderer is a pure C# QRCode renderer for Blazor based on the popular open source and MIT Licensed [QRCoder](https://github.com/codebude/QRCoder).

[Live Demo](https://lostbeard.github.io/SpawnDev.Blazor.QRCodeRenderer/)

Image QRCode renderer
```html
<QRCodeImage DarkColor="darkgreen" DataText="Hello world!" QRRenderMode="QRRenderMode.ImageElementPng" />
```
![Hello world! QRCode](data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAQgAAAEIAQMAAACZOPi8AAAABlBMVEUAZAD////Ja05QAAAA4UlEQVR4nO3VUY7DQAgDUN//0lQdbCBKkx7ATFVpF96XBRTx72HFihUrngXyff9BflUxFYqGxVExFcrrpJWfrLgLJrUic8rtCnuhnESeds5E1MUd+/Rwkx3EeBqkWfETl4CQi6Wmo6hBoj+F2TITJ6ZO6vTRf/uJWqO6M1P7ie5kbLeLayXY0e8Q4rZRdgL8dlqXjTIUqvC+oJuOIvKgUDKyMBV6qPBqyyxFr1CeXt5e2ArmlXM05slWgNc2lFWvlLXgQJU2Fz05CGvRjr2Tna2oBYLGp5SjeH0rVqxY8ft9AIY1sZJB5K5cAAAAAElFTkSuQmCC)

SVG QRCode renderer
```html
<QRCodeImage DarkColor="darkgreen" DataText="Hello world!" QRRenderMode="QRRenderMode.SvgElement" />
```
<svg style="width: 256px;" version="1.1" baseProfile="full" shape-rendering="crispEdges" viewBox="0 0 264 264" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink"><rect x="0" y="0" width="264" height="264" fill="white"></rect>
<rect x="32" y="32" width="56" height="8" fill="darkgreen"></rect>
<rect x="96" y="32" width="8" height="8" fill="darkgreen"></rect>
<rect x="120" y="32" width="16" height="8" fill="darkgreen"></rect>
<rect x="152" y="32" width="16" height="8" fill="darkgreen"></rect>
<rect x="176" y="32" width="56" height="8" fill="darkgreen"></rect>
<rect x="32" y="40" width="8" height="40" fill="darkgreen"></rect>
<rect x="80" y="40" width="8" height="40" fill="darkgreen"></rect>
<rect x="104" y="40" width="24" height="8" fill="darkgreen"></rect>
<rect x="176" y="40" width="8" height="40" fill="darkgreen"></rect>
<rect x="224" y="40" width="8" height="40" fill="darkgreen"></rect>
<rect x="48" y="48" width="24" height="24" fill="darkgreen"></rect>
<rect x="104" y="48" width="8" height="16" fill="darkgreen"></rect>
<rect x="120" y="48" width="16" height="8" fill="darkgreen"></rect>
<rect x="144" y="48" width="8" height="8" fill="darkgreen"></rect>
<rect x="160" y="48" width="8" height="16" fill="darkgreen"></rect>
<rect x="192" y="48" width="24" height="24" fill="darkgreen"></rect>
<rect x="96" y="64" width="8" height="24" fill="darkgreen"></rect>
<rect x="128" y="64" width="32" height="8" fill="darkgreen"></rect>
<rect x="136" y="72" width="32" height="8" fill="darkgreen"></rect>
<rect x="32" y="80" width="56" height="8" fill="darkgreen"></rect>
<rect x="112" y="80" width="8" height="8" fill="darkgreen"></rect>
<rect x="128" y="80" width="8" height="8" fill="darkgreen"></rect>
<rect x="144" y="80" width="8" height="8" fill="darkgreen"></rect>
<rect x="160" y="80" width="8" height="8" fill="darkgreen"></rect>
<rect x="176" y="80" width="56" height="8" fill="darkgreen"></rect>
<rect x="120" y="88" width="8" height="8" fill="darkgreen"></rect>
<rect x="136" y="88" width="8" height="8" fill="darkgreen"></rect>
<rect x="152" y="88" width="8" height="8" fill="darkgreen"></rect>
<rect x="40" y="96" width="56" height="8" fill="darkgreen"></rect>
<rect x="128" y="96" width="8" height="8" fill="darkgreen"></rect>
<rect x="144" y="96" width="16" height="8" fill="darkgreen"></rect>
<rect x="184" y="96" width="16" height="8" fill="darkgreen"></rect>
<rect x="224" y="96" width="8" height="8" fill="darkgreen"></rect>
<rect x="48" y="104" width="8" height="8" fill="darkgreen"></rect>
<rect x="88" y="104" width="24" height="8" fill="darkgreen"></rect>
<rect x="152" y="104" width="16" height="8" fill="darkgreen"></rect>
<rect x="184" y="104" width="8" height="8" fill="darkgreen"></rect>
<rect x="208" y="104" width="8" height="8" fill="darkgreen"></rect>
<rect x="40" y="112" width="8" height="8" fill="darkgreen"></rect>
<rect x="56" y="112" width="16" height="8" fill="darkgreen"></rect>
<rect x="80" y="112" width="16" height="8" fill="darkgreen"></rect>
<rect x="120" y="112" width="16" height="16" fill="darkgreen"></rect>
<rect x="168" y="112" width="8" height="8" fill="darkgreen"></rect>
<rect x="192" y="112" width="16" height="8" fill="darkgreen"></rect>
<rect x="216" y="112" width="16" height="16" fill="darkgreen"></rect>
<rect x="40" y="120" width="16" height="8" fill="darkgreen"></rect>
<rect x="64" y="120" width="8" height="8" fill="darkgreen"></rect>
<rect x="144" y="120" width="8" height="8" fill="darkgreen"></rect>
<rect x="160" y="120" width="8" height="8" fill="darkgreen"></rect>
<rect x="176" y="120" width="8" height="8" fill="darkgreen"></rect>
<rect x="40" y="128" width="8" height="8" fill="darkgreen"></rect>
<rect x="56" y="128" width="16" height="8" fill="darkgreen"></rect>
<rect x="80" y="128" width="8" height="8" fill="darkgreen"></rect>
<rect x="96" y="128" width="8" height="8" fill="darkgreen"></rect>
<rect x="112" y="128" width="8" height="8" fill="darkgreen"></rect>
<rect x="128" y="128" width="8" height="8" fill="darkgreen"></rect>
<rect x="160" y="128" width="72" height="8" fill="darkgreen"></rect>
<rect x="32" y="136" width="8" height="32" fill="darkgreen"></rect>
<rect x="48" y="136" width="8" height="8" fill="darkgreen"></rect>
<rect x="64" y="136" width="8" height="8" fill="darkgreen"></rect>
<rect x="88" y="136" width="48" height="8" fill="darkgreen"></rect>
<rect x="144" y="136" width="16" height="8" fill="darkgreen"></rect>
<rect x="184" y="136" width="8" height="8" fill="darkgreen"></rect>
<rect x="208" y="136" width="8" height="8" fill="darkgreen"></rect>
<rect x="48" y="144" width="24" height="8" fill="darkgreen"></rect>
<rect x="80" y="144" width="24" height="8" fill="darkgreen"></rect>
<rect x="112" y="144" width="8" height="8" fill="darkgreen"></rect>
<rect x="128" y="144" width="80" height="8" fill="darkgreen"></rect>
<rect x="216" y="144" width="16" height="8" fill="darkgreen"></rect>
<rect x="48" y="152" width="32" height="8" fill="darkgreen"></rect>
<rect x="88" y="152" width="16" height="8" fill="darkgreen"></rect>
<rect x="152" y="152" width="8" height="8" fill="darkgreen"></rect>
<rect x="176" y="152" width="24" height="8" fill="darkgreen"></rect>
<rect x="224" y="152" width="8" height="8" fill="darkgreen"></rect>
<rect x="48" y="160" width="8" height="8" fill="darkgreen"></rect>
<rect x="80" y="160" width="16" height="8" fill="darkgreen"></rect>
<rect x="112" y="160" width="32" height="8" fill="darkgreen"></rect>
<rect x="152" y="160" width="64" height="8" fill="darkgreen"></rect>
<rect x="96" y="168" width="8" height="8" fill="darkgreen"></rect>
<rect x="120" y="168" width="8" height="8" fill="darkgreen"></rect>
<rect x="136" y="168" width="32" height="8" fill="darkgreen"></rect>
<rect x="192" y="168" width="8" height="16" fill="darkgreen"></rect>
<rect x="208" y="168" width="8" height="8" fill="darkgreen"></rect>
<rect x="224" y="168" width="8" height="8" fill="darkgreen"></rect>
<rect x="32" y="176" width="56" height="8" fill="darkgreen"></rect>
<rect x="96" y="176" width="24" height="8" fill="darkgreen"></rect>
<rect x="128" y="176" width="16" height="8" fill="darkgreen"></rect>
<rect x="152" y="176" width="16" height="8" fill="darkgreen"></rect>
<rect x="176" y="176" width="8" height="8" fill="darkgreen"></rect>
<rect x="208" y="176" width="24" height="8" fill="darkgreen"></rect>
<rect x="32" y="184" width="8" height="40" fill="darkgreen"></rect>
<rect x="80" y="184" width="8" height="40" fill="darkgreen"></rect>
<rect x="96" y="184" width="8" height="8" fill="darkgreen"></rect>
<rect x="128" y="184" width="24" height="8" fill="darkgreen"></rect>
<rect x="160" y="184" width="8" height="8" fill="darkgreen"></rect>
<rect x="192" y="184" width="16" height="8" fill="darkgreen"></rect>
<rect x="224" y="184" width="8" height="8" fill="darkgreen"></rect>
<rect x="48" y="192" width="24" height="24" fill="darkgreen"></rect>
<rect x="96" y="192" width="16" height="8" fill="darkgreen"></rect>
<rect x="128" y="192" width="8" height="8" fill="darkgreen"></rect>
<rect x="144" y="192" width="8" height="8" fill="darkgreen"></rect>
<rect x="160" y="192" width="64" height="8" fill="darkgreen"></rect>
<rect x="96" y="200" width="24" height="8" fill="darkgreen"></rect>
<rect x="152" y="200" width="16" height="8" fill="darkgreen"></rect>
<rect x="176" y="200" width="8" height="8" fill="darkgreen"></rect>
<rect x="192" y="200" width="16" height="8" fill="darkgreen"></rect>
<rect x="224" y="200" width="8" height="24" fill="darkgreen"></rect>
<rect x="96" y="208" width="8" height="8" fill="darkgreen"></rect>
<rect x="128" y="208" width="16" height="8" fill="darkgreen"></rect>
<rect x="160" y="208" width="8" height="8" fill="darkgreen"></rect>
<rect x="184" y="208" width="8" height="8" fill="darkgreen"></rect>
<rect x="200" y="208" width="8" height="8" fill="darkgreen"></rect>
<rect x="96" y="216" width="24" height="8" fill="darkgreen"></rect>
<rect x="136" y="216" width="8" height="8" fill="darkgreen"></rect>
<rect x="152" y="216" width="8" height="16" fill="darkgreen"></rect>
<rect x="176" y="216" width="24" height="8" fill="darkgreen"></rect>
<rect x="32" y="224" width="56" height="8" fill="darkgreen"></rect>
<rect x="112" y="224" width="8" height="8" fill="darkgreen"></rect>
<rect x="128" y="224" width="16" height="8" fill="darkgreen"></rect>
<rect x="168" y="224" width="24" height="8" fill="darkgreen"></rect>
<rect x="208" y="224" width="24" height="8" fill="darkgreen"></rect>
</svg>

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





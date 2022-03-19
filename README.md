# StylerCode.Css
## NuGet
* NuGet: [StylerCode.Css](https://www.nuget.org/packages/StylerCode.Css/) [![NuGet](https://img.shields.io/nuget/v/StylerCode.Css?label=NuGet)](https://www.nuget.org/packages/StylerCode.Css/)
Style html using C# codes.
```csharp
CssStyler verseStyle = new CssStyler();
            verseStyle.AddStyle(CssProperties.Font_Size, FontVerseNumberSize);
            verseStyle.AddStyle(CssProperties.Font_Style, "italic");
            verseStyle.AddStyle(CssProperties.Font_Weight, "normal");
            verseStyle.AddStyle(CssProperties.Color, SystemAccentColor.ToHex());

            var spn = $"<span {verseStyle.ToAttributeStyles()}>{verseNumber}</span>";
            <div style="@verseStyle"></div>
           
```
Cast styles to string or vice-versa
```csharp
public CssStyler DrawerStyle { get; } = (CssStyler)"height: 100%; width: 0; position: fixed; z-index: 1; top: 0; left: 0; background-color: #111; overflow-x: hidden;transition: 0.5s;padding-top: 60px;";
```
```csharp
 
  
    
    CssStyler myStyles = new CssStyler();
		myStyles.AddStyle(CssProperties.Animation_Fill_Mode, "forwards").AddStyle(CssProperties.Color, "red");
		myStyles.Align_Content = Css.Center;
		myStyles.Border_Left = "30px";

		myStyles.Remove(CssProperties.Color);
```
* Github: [https://github.com/coderbasket/StylerCode.Css](https://github.com/coderbasket/StylerCode.Css)

Code nuget publish => oy2p6bifc57fjnxo7u7al3qs5aem72kunf4cstnsqfd2la


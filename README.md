# StylerCode.Css
## NuGet
* NuGet: [StylerCode.Css](https://www.nuget.org/packages/StylerCode.Css/) [![NuGet](https://img.shields.io/nuget/v/StylerCode.Css?label=NuGet)](https://www.nuget.org/packages/StylerCode.Css/)
Style html using C# codes.
```csharp
Css verseStyle = new Css();
            verseStyle.Add(Cp.Font_Size, FontVerseNumberSize);
            verseStyle.Add(Cp.Font_Style, "italic");
            verseStyle.Add(Cp.Font_Weight, "normal");
            verseStyle.Add(Cp.Color, SystemAccentColor.ToHex());

            var spn = $"<span {verseStyle.ToAttributeStyles()}>{verseNumber}</span>";
            <div style="@verseStyle"></div>
           
```
Cast styles to string or vice-versa
```csharp
public Css DrawerStyle { get; } = (Css)"height: 100%; width: 0; position: fixed; z-index: 1; top: 0; left: 0; background-color: #111; overflow-x: hidden;transition: 0.5s;padding-top: 60px;";
```
```csharp
 
  
    
    Css myStyles = new Css();
		myStyles.Add(Cp.Animation_Fill_Mode, "forwards").AddStyle(Cp.Color, "red");
		myStyles.Align_Content = Cv.Center;
		myStyles.Border_Left = "30px";

		myStyles.Remove(Cp.Color);
```
* Github: [https://github.com/coderbasket/StylerCode.Css](https://github.com/coderbasket/StylerCode.Css)

Code nuget publish => oy2p6bifc57fjnxo7u7al3qs5aem72kunf4cstnsqfd2la


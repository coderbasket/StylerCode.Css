# StylerCode.Css
## NuGet
* NuGet: [StylerCode.Css](https://www.nuget.org/packages/StylerCode.Css/) [![NuGet](https://img.shields.io/nuget/v/StylerCode.Css?label=NuGet)](https://www.nuget.org/packages/StylerCode.Css/)
Style html using C# codes.
```csharp
Css style = new Css();
 style.Add(Cp.Font_Size, FontVerseNumberSize);
 style.Add(Cp.Font_Style, "italic");
 style.Add(Cp.Font_Weight, "normal");
 style.Add(Cp.Color, SystemAccentColor.ToHex());
	    
 style.Add(Cp.Transform, Cv.TranslateX("60px"));
	    
 var spn = $"<span {style.ToAttributeStyles()}>{verseNumber}</span>";
 <div style="@verseStyle"></div>
           
```
Cast styles to string or vice-versa
```csharp
public Css DrawerStyle { get; } = (Css)"height: 100%; width: 0; position: fixed; z-index: 1; top: 0; left: 0; background-color: #111; overflow-x: hidden;transition: 0.5s;padding-top: 60px;";

string cssValuesString = (Css)DrawerStyle;
```
```csharp
 
  
    
    Css myStyles = new Css();
		myStyles.Add(Cp.Animation_Fill_Mode, "forwards").AddStyle(Cp.Color, "red");
		myStyles.Align_Content = Cv.Center;
		myStyles.Border_Left = "30px";

                myStyles.Add(Cp.Text_Decoration, Cv.Underline);

		myStyles.Remove(Cp.Color);
```
![alt text](https://raw.githubusercontent.com/coderbasket/StylerCode.Css/main/20220319_191849.jpg)
* Github: [https://github.com/coderbasket/StylerCode.Css](https://github.com/coderbasket/StylerCode.Css)

Code nuget publish => oy2p6bifc57fjnxo7u7al3qs5aem72kunf4cstnsqfd2la


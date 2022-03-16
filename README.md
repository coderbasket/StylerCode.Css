# StylerCode.Css
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
Cast styles to string
```csharp
public CssStyler DrawerStyle { get; } = (CssStyler)"height: 100%; width: 0; position: fixed; z-index: 1; top: 0; left: 0; background-color: #111; overflow-x: hidden;transition: 0.5s;padding-top: 60px;";
```

using Raylib;
using static Raylib.Raylib;
using static Raylib.TextureFilterMode;

public partial class text_font_sdf
{
    /*******************************************************************************************
        // Parameters > font size: 16, no chars array provided (0), chars count: 95 (autogenerate chars array)
        // TODO: fix conversion
        //fontDefault.chars = LoadFontData("resources/AnonymousPro-Bold.ttf", 16, null, 95, false);
        // Parameters > chars count: 95, font size: 16, chars padding in image: 4 px, pack method: 0 (default)
        //Image atlas = GenImageFontAtlas(fontDefault.chars, 95, 16, 4, 0);
        // Parameters > font size: 16, no chars array provided (0), chars count: 0 (defaults to 95)
        // TODO: fix conversion
        //fontSDF.chars = LoadFontData("resources/AnonymousPro-Bold.ttf", 16, null, 0, true);
        // Parameters > chars count: 95, font size: 16, chars padding in image: 0 px, pack method: 1 (Skyline algorythm)
        // TODO: fix conversion
        //atlas = GenImageFontAtlas(fontSDF.chars, 95, 16, 0, 1);
        //fontSDF.texture = LoadTextureFromImage(atlas);
}
﻿using CommunityToolkit.Maui;
using InputKit.Shared.Controls;
using UraniumUI;

namespace VioletEchoes;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseUraniumUIBlurs()
            .UseUraniumUI()
            .UseUraniumUIMaterial()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                fonts.AddMaterialIconFonts();

            });

        builder.Services.AddCommunityToolkitDialogs();
        return builder.Build();
    }
}

﻿using Avalonia;
using Avalonia.Markup.Xaml;

namespace RaceRegAvalonia
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

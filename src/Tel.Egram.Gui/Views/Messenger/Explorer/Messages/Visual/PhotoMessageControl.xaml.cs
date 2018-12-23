﻿using Avalonia.Markup.Xaml;
using Tel.Egram.Components.Messenger.Explorer.Messages.Visual;

namespace Tel.Egram.Gui.Views.Messenger.Explorer.Messages.Visual
{
    public class PhotoMessageControl : BaseControl<PhotoMessageModel>
    {
        public PhotoMessageControl()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
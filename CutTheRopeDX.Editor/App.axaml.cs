using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using CutTheRopeDX.Editor.ViewModels;
using CutTheRopeDX.Editor.Views;

namespace CutTheRopeDX.Editor
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow { DataContext = new EditorViewModel() };
            }
            base.OnFrameworkInitializationCompleted();
        }
    }
}

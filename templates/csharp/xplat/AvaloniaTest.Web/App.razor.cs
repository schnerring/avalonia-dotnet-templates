using Avalonia.Web.Blazor;

namespace AvaloniaTest.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        
        WebAppBuilder.Configure<AvaloniaTest.App>()
            .SetupWithSingleViewLifetime();
    }
}
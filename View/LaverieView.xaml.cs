using LaverieClient.ModelView;

namespace LaverieClient.View;

public partial class LaverieView : ContentPage
{
	public LaverieView()
	{
		InitializeComponent();
        BindingContext = new LaverieVM();

    }
}
using CommunityToolkit.Maui.Views;

namespace NetMauiPopupNoWrapBug;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        var popup = new SimplePopup();

        this.ShowPopup(popup);
    }
}


namespace PhotoMadness;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		Shell.Current.FlyoutIsPresented = true;
    }
}
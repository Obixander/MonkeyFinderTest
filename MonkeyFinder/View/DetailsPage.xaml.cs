namespace MonkeyFinder;

public partial class DetailsPage : ContentPage
{
	
	public DetailsPage(MonkeyDetailsViewModel viewmodel)
	{
		InitializeComponent();
		BindingContext = viewmodel;
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

}
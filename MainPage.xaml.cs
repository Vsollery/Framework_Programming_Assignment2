using Assignment2.ViewModel;

namespace Assignment2;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

	}

	
}


namespace ShowdoMilhao2;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	private void Comecar (object sender, EventArgs e)
	{
		Application.Current.MainPage= new Tela();
	}

}


using Microsoft.Maui.Controls.Shapes;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    bool f1 = false;
    bool f2 = false;
    public MainPage()
	{
		InitializeComponent();
	}

	private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
	{
		Test.Text = e.TotalX + "||" + e.TotalY + "//"+ f1+"??"+ f2;
        //(sender as BoxView).TranslateTo(e.TotalX, e.TotalY);
		if((Math.Round(e.TotalY) == 150))
		{
			f1 = true;
		}
		if((Math.Round(e.TotalX) == 100))
		{
			f2 = true;
		}
		if(e.StatusType == GestureStatus.Completed && f1 == true && f1 == true) 
		{
			Test.Text = "OWO";
		}
	}
	//e.StatusType == GestureStatus .Canseled/.Complited/.Runing
	//e.TotalX & e.TotalY 
}


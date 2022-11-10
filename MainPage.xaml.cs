namespace L_MyFirstMauiApp;

public partial class MainPage : ContentPage
{
	int count = 0;
	int count2 = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Wassup";
		else
			CounterBtn.Text = $"Don't hit me again bro that's messed up.";

		if (count == 3)

			CounterBtn.Text = "Actually I lowkey respect now";
			

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void Rawr(object sender, EventArgs e)
    {
        count2++;

        if (count2 == 1)
            Wassup.Text = $"You chill bruh wassup w u";
        else
            Wassup.Text = $"I'ma call the cops";

		if (count2 == 3)
			Wassup.Text = "You're pretty strong man, good for you";


            SemanticScreenReader.Announce(CounterBtn.Text);
    }
}


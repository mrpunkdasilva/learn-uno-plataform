namespace Counter;

public sealed partial class DetailPage : Page
{
    public DetailPage()
    {
        this.InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);

        // Recebe o parâmetro passado durante a navegação
        if (e.Parameter is int count)
        {
            InfoTextBlock.Text = $"O valor atual do contador é: {count}";
        }
    }

    private void GoBackButton_Click(object sender, RoutedEventArgs e)
    {
        if (this.Frame.CanGoBack)
        {
            this.Frame.GoBack();
        }
    }
}

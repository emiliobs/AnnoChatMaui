namespace AnnoChatMaui.Views.Chat;

public partial class MessagePage : ContentPage
{

    public MessagePage()
    {
        InitializeComponent();
       

    }

    private void lstMesssage_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Navigation.PushAsync(new ChatPage(), true);
    }

    
}


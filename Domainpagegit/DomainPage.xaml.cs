namespace Domainpagegit;

public partial class DomainPage : ContentPage
{
    public DomainPage()
    {
        InitializeComponent();
    }
    //private async void OnCompanyOne_Clicked(object sender, EventArgs e)
    //{
    //    await Navigation.PushAsync(new SubdomainsPage());
    //}
    private async void OnCompanyButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SubdomainsPage());

    }
}
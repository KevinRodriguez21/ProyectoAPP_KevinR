using ProyectoAPP_KevinR.ViewModels;
using ProyectoAPP_KevinR.Models;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace ProyectoAPP_KevinR.Views;

public partial class UserSignUpPage : ContentPage
{
    EmpleadoViewModel? vm;
    public UserSignUpPage()
	{
		InitializeComponent();

        BindingContext = vm = new EmpleadoViewModel();
    }

    private async void BtnAdd_Clicked(object sender, EventArgs e)
    {
        var answer = await DisplayAlert("Confirmation Required", "Adding new user. Are you sure?", "Yes", "No");
        if (answer)
        {

            bool R = await vm.VmAddEmpleado(TxtName.Text.Trim(), TxtLast_Name.Text.Trim(), TxtPost.Text.Trim(), int.Parse(TxtPhone.Text.Trim()), TxtEmail.Text.Trim(), TxtPassword.Text.Trim());

            if (R)
            {
                await DisplayAlert(":)", "User added!!", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert(":(", "Error: ", "OK");
            }

        }
    }

    private async void BtnCancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void SwshowPassword_Toggled(object sender, ToggledEventArgs e)
    {
        TxtPassword.IsPassword = true;

        if (SwshowPassword.IsToggled)
        {
            TxtPassword.IsPassword = false;
        }
    }

}
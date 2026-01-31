namespace Basic_Login_Screen;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        string userId = txtUserName.Text?.Trim() ?? string.Empty;
        string password = txtPassword.Text ?? string.Empty;

        // Requirement:
        // User ID = your last name
        // Password = "Password1"
        const string correctUserId = "Owens";
        const string correctPassword = "Password1";

        if (string.Equals(userId, correctUserId, StringComparison.OrdinalIgnoreCase)
            && password == correctPassword)
        {
            lblMessage.Text = $"Login successful {userId}";
        }
        else
        {
            lblMessage.Text = $"Login failed {userId}";
        }
    }

    private void OnCancelClicked(object sender, EventArgs e)
    {
        txtUserName.Text = string.Empty;
        txtPassword.Text = string.Empty;
        lblMessage.Text = string.Empty;
    }
}

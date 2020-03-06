using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace TestSyncfusion.Xamarin.Views.Forms
{
    /// <summary>
    /// Page to login with user name and password
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPage" /> class.
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
        }

        async void btnSignUpClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new SignUpPage() );
        }
    }
}
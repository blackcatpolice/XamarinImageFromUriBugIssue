using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace TestSyncfusion.Xamarin.Views.Forms
{
    /// <summary>
    /// Page to sign in with user details.
    /// </summary>
    //[Preserve(AllMembers = true)]
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignUpPage" /> class.
        /// </summary>
        public SignUpPage()
        {
            InitializeComponent();
        }

        async void btnLoginClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginPage());
        }
    }
}
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using Android.Views.InputMethods;

namespace TextExample.Droid.Views
{
    [Activity(Label = "View for Text View Model", WindowSoftInputMode = SoftInput.StateVisible)]
    public class TextView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TextView);

            Button button = FindViewById<Button>(Resource.Id.buttonReset);
            EditText etKeyboard = FindViewById<EditText>(Resource.Id.textViewEdit);
            InputMethodManager mgr = (InputMethodManager)GetSystemService(Context.InputMethodService);

            mgr.ShowSoftInput(etKeyboard, ShowFlags.Implicit);
        }
    }
}
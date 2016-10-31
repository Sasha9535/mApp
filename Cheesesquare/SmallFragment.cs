using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace Cheesesquare
{
    class SmallFragment : Fragment
    {
        private string textForTextView;
        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
           
            //var parent = ((ViewGroup)view.Parent);
            //if (parent != null) parent.RemoveView(view);
            var textView = view.FindViewById<TextView>(Resource.Id.text1);
            //Bundle args = this.Arguments;
            //string textt = args.GetString("name", "empty");
            textView.Text = textForTextView;
            base.OnViewCreated(view, savedInstanceState);

        }
        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.list_item, container, false);
            return view;
        }
        public static SmallFragment newInstance(string str)
        {
            SmallFragment fr = new SmallFragment();
            Bundle args = new Bundle();
            args.PutString("name", str);
            fr.Arguments = args;
            return fr;


        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            savedInstanceState = Arguments;
            base.OnCreate(savedInstanceState);
            if (savedInstanceState != null) 
            this.textForTextView=savedInstanceState.GetString("name");
        }
}
}
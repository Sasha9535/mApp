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

            //base.OnViewCreated(view, savedInstanceState);

        }
        //public override On

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.list_item, container, false);
            //ViewGroup parent;
            //if (view != null)
            //{
            //    parent = (ViewGroup)view.Parent;
            //    if (parent != null)
            //    {
            //        parent.RemoveView(view);
            //    }
            //}
            //else parent = container;
            //try
            //{
            //    view = inflater.Inflate(Resource.Layout.list_item, parent, false);
            //}
            //catch (InflateException e)
            //{

            //}
            var textView = view.FindViewById<TextView>(Resource.Id.text1);
            textView.Text = textForTextView;
            return view;
        }
        public SmallFragment(string str)
        {
            textForTextView = str;
        }
        public SmallFragment()
        {
            textForTextView = "11";
        }

    }
}
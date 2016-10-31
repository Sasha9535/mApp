
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;

namespace Cheesesquare
{
    public class MyDialogFragment : DialogFragment
    {
        int curItem;
        public  MyDialogFragment (int curItem)
        {
            this.curItem = curItem;
        }
        public MyDialogFragment()
        {
        }
        //public override Dialog OnCreateDialog(Bundle savedInstanceState)
        //{
        //    var builder = new AlertDialog.Builder(Activity);
        //    var inflater = Activity.LayoutInflater;
        //    var dialogView = inflater.Inflate(Resource.Layout.AddServiceDialog, null);
        //}
        //public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        //{
        //    var view = inflater.Inflate(Resource.Layout.dialogFragment, container, false);
        //    var editText = view.FindViewById<EditText>(Resource.Id.txtFirstName);
        //    switch (curItem)
        //    {
        //        case 0:editText.Text = "@string/dialog_add_income";break;
        //        case 1:editText.Text = "@string/dialog_add_outcome";break; 
        //    }
        //    return view;
        //}
        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            var builder =new AlertDialog.Builder(Activity);

            var inflater = Activity.LayoutInflater;

            var dialogview = inflater.Inflate(Resource.Layout.dialogFragment, null);
            if (dialogview != null)
            {
                var editText = dialogview.FindViewById<EditText>(Resource.Id.txtAddName);
                editText.Hint = GetString(Resource.String.editTextDialog);
                builder.SetView(dialogview);
                //btn.Click += HandlePositiveButtonClick;
                //int k = btn.Id;
                //builder.SetPositiveButton(btn.Id, HandlePositiveButtonClick); 

            }
            Button btn = dialogview.FindViewById<Button>(Resource.Id.btnDialogAdd);

            RelativeLayout layout = dialogview.FindViewById<RelativeLayout>(Resource.Id.dialog_layout);
            layout.Click += layout_Click;

            var dialog = builder.Create();
            btn.Click += (sender, args) =>
              {
                  var inflate1r = Activity.LayoutInflater;
                  var layout1= inflate1r.Inflate(Resource.Layout.view_inside_viewPager,null);
                  ViewPager viewPager = layout1.FindViewById<ViewPager>(Resource.Id.viewPagerCharge);
                  customViewPagerAdapter adapter=viewPager.Adapter;
                    adapter.
                  Toast.MakeText(Activity, "yeee", ToastLength.Long).Show();  
                  dialog.Dismiss();
              };
            return dialog;


        }

        void layout_Click(object sender, EventArgs e)
        {
            InputMethodManager inputManager = (InputMethodManager)Activity.GetSystemService(Context.InputMethodService);
            inputManager.HideSoftInputFromWindow(Activity.CurrentFocus.WindowToken, HideSoftInputFlags.None);
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            string strForTitle;
            switch (curItem)
            {
                case 0: strForTitle = GetString(Resource.String.dialog_add_income); break;
                case 1: strForTitle = GetString(Resource.String.dialog_add_outcome); break;
                default:strForTitle = "What?error!"; break;
            }
            Dialog.SetTitle(strForTitle);
            base.OnActivityCreated(savedInstanceState);
            Dialog.Window.Attributes.WindowAnimations = Resource.Style.dialog_animation;
        }
       
    }

}


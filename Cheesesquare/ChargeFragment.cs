using Android.OS;
using Android.Support.V4.View;
using Android.Views;
using Android.Support.V4.App;
using System;
using Android.Content;
using Android.Widget;

namespace Cheesesquare
{
    public class ChargeFragment : Fragment
    {
        customViewPagerAdapter adapter;
        ViewPager viewPager;
        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.view_inside_viewPager, container, false);
           return view;
        }
        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            viewPager = view.FindViewById<ViewPager>(Resource.Id.viewPagerCharge);
            Button btn = view.FindViewById<Button>(Resource.Id.butForAdd);
            Button btnDelete = view.FindViewById<Button>(Resource.Id.delete);
            btnDelete.Click += btnDelete_Click;
            if (btn!=null) btn.Click += btn_Click;
            if (viewPager != null)
                setupViewPager();
        }

        void setupViewPager()
        {
            adapter = new customViewPagerAdapter(ChildFragmentManager);
            adapter.AddFragment(SmallFragment.newInstance("1"), "first");
            adapter.AddFragment(SmallFragment.newInstance("2"), "second");
            adapter.AddFragment(SmallFragment.newInstance("3"), "third");
            adapter.AddFragment(SmallFragment.newInstance("4"), "fouth");
            viewPager.Adapter = adapter;

        }

        void btn_Click(object sender, EventArgs e)
        {
            adapter.AddFragment(SmallFragment.newInstance("5"), "fifth");

            adapter.NotifyDataSetChanged();
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            int curItem = viewPager.CurrentItem;
            //var posit=adapter.GetItemPosition(this.TargetFragment);
            int l;
        }
    }

}


using Android.OS;
using Android.Support.V4.View;
using Android.Views;
using Android.Support.V4.App;
using System;
using Android.Content;

namespace Cheesesquare
{
    public class ChargeFragment : Fragment
    {
        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.view_inside_viewPager, container, false);
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
            //    view = inflater.Inflate(Resource.Layout.view_inside_viewPager, parent, false);
            //}
            //catch (InflateException e)
            //{

            //}
            var viewPager = view.FindViewById<customViewPager>(Resource.Id.viewPagerCharge);
            //var vcp = new customViewPager(Context);
            if (viewPager != null)
                setupViewPager(viewPager);

            return view;
        }
        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {

        }
        void setupViewPager(customViewPager viewPager)
        {
            var adapter = new customViewPagerAdapter(ChildFragmentManager);
            adapter.AddFragment(new SmallFragment("shop"), "first");
            adapter.AddFragment(new SmallFragment("shoop"), "second");
            adapter.AddFragment(new SmallFragment("sho0p"), "third");
            adapter.AddFragment(new SmallFragment("shoo0p"), "fouth");
            viewPager.Adapter = adapter;

        }
    }
    //public class  CustomViewPager: ViewPager
    //{
    //}
    public class customViewPager : ViewPager
    {
        public customViewPager(Context ctx) : base(ctx)
        {
        }
        public customViewPager(Context ctx, Android.Util.IAttributeSet attrs) : base(ctx, attrs)
        {
        }
        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
            View view = GetChildAt(0);
            if (view != null)
            {
                view.Measure(widthMeasureSpec, measureHeight(heightMeasureSpec, view));
            }
            SetMeasuredDimension(MeasuredWidth, MeasuredHeight);
        }
        private int measureHeight(int measureSpec, View view)
        {
            int result = 0;
            var specMode = MeasureSpec.GetMode(measureSpec);
            int specSize = MeasureSpec.GetSize(measureSpec);
            if (specMode == MeasureSpecMode.Exactly)
            {
                result = specSize;
            }
            else {
                // set the height from the base view if available
                if (view != null)
                {
                    result = view.MeasuredHeight;
                }
                if (specMode == MeasureSpecMode.AtMost)
                {
                    result = Math.Min(result, specSize);
                }
            }
            return result;
        }
    }

}


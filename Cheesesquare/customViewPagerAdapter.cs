using System;
using System.Collections.Generic;
using Android.Support.V4.App;
using Android.Views;
using V4Fragment = Android.Support.V4.App.Fragment;
namespace Cheesesquare
{
    public class customViewPagerAdapter:FragmentPagerAdapter
    {

       List<V4Fragment> fragments = new List<V4Fragment>();
        List<string> fragmentTitles = new List<string>();
        public customViewPagerAdapter(FragmentManager fm) : base (fm)
        {
        }

        public void AddFragment(V4Fragment fragment, string fragmentTitle)
        {
            fragments.Add(fragment);
            fragmentTitles.Add(fragmentTitle);
        }
        //public override void DestroyItem(Android.Views.ViewGroup container, int position, Java.Lang.Object objectValue)
        //{
        //    container.RemoveViewAt(position);
        //}
        //public override Java.Lang.Object InstantiateItem(ViewGroup container, int position)
        //{
        //    return base.InstantiateItem(container, position);
        //}
        public override V4Fragment GetItem(int position)
        {
            return fragments[position];
        }

        public override int Count
        {
            get { return fragments.Count; }
        }
        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(fragmentTitles[position]);
        }
        public override long GetItemId(int position)
        {
            return base.GetItemId(position);

        }
       //public override int GetItemPosition(Java.Lang.Object objectValue)
       // {
       //     SmallFragment fragment = (SmallFragment)objectValue;
       //     String title = fragment.Tag;
       //     int position = title.IndexOf(title);

       //     if (position >= 0)
       //     {
       //         return position;
       //     }
       //     else {
       //         return PositionNone;
       //     }
       // }
    }

}


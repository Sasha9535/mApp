using System;
using V4= Android.Support.V4.App;
using Android.Views;
using Android.OS;
using Android.Support.V7.Widget;
using System.Collections.Generic;
using Android.Widget;
using Android.Content;
using Android.Util;
using Android.Runtime;
using System.Threading.Tasks;
using System.Linq;
using Java.Lang;
using Android.App;

namespace Cheesesquare
{
    class IncomeFragment : Android.Support.V4.App.Fragment
    {
        ListView listvview;
        ListAdapter adapter;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var v = inflater.Inflate(Resource.Layout.fragment_outcome_list, container, false);
            listvview = v.FindViewById<ListView>(Resource.Id.listView1);
            string[] names = { "shop", "another", "komynalka" };
            adapter = new ListAdapter(this.Activity,names.ToList());
            listvview.Adapter = adapter;
            return listvview;
        }
    }
    class ListAdapter : BaseAdapter
    {
        List<string> names;
        V4.FragmentActivity context;
        public ListAdapter(V4.FragmentActivity parent, List<string> names)
        {
            this.context = parent;
            this.names = names;
        }
        public override int Count
        {
            get
            {
                return names.Count;
            }
        }
       
        //public override Java.Lang.Object GetItem(int position)
        //{
        //    throw new NotImplementedException();
        //}

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view=convertView;
            if (view == null) // no view to re-use, create new
                view = context.LayoutInflater.Inflate(Resource.Layout.out_incomeLayout, null);
            view.FindViewById<TextView>(Resource.Id.textForName).Text=names[position];
            return view;
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return names[position];
        }
    }

}
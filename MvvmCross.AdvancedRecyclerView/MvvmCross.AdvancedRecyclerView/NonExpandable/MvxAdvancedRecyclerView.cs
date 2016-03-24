using System;
using Android.Content;
using Android.Runtime;
using Android.Util;
using MvvmCross.Droid.Support.V7.RecyclerView;

namespace MvvmCross.AdvancedRecyclerView.NonExpandable
{
    [Register("mvvmcross.advancedrecyclerview.MvxAdvancedRecyclerView")]
    public class MvxAdvancedRecyclerView : MvxRecyclerView
    {
        public MvxAdvancedRecyclerView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public MvxAdvancedRecyclerView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public MvxAdvancedRecyclerView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
        {
        }

        public MvxAdvancedRecyclerView(Context context, IAttributeSet attrs, int defStyle, IMvxRecyclerAdapter adapter) : base(context, attrs, defStyle, adapter)
        {
        }
    }
}

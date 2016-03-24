using System;
using System.Collections;
using System.Windows.Input;
using Android.Runtime;
using Com.H6ah4i.Android.Widget.Advrecyclerview.Swipeable;
using Com.H6ah4i.Android.Widget.Advrecyclerview.Swipeable.Action;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Droid.Support.V7.RecyclerView.ItemTemplates;
using Object = Java.Lang.Object;

namespace MvvmCross.AdvancedRecyclerView.NonExpandable.Adapters
{
    internal class SwipeableMvxAdapterDecorator : Java.Lang.Object, IMvxRecyclerAdapter, ISwipeableItemAdapter
    {
        private readonly IMvxRecyclerAdapter _decoratedAdapter;
        private readonly ISwipeableItemAdapter _swipeableItemAdapter;

        public SwipeableMvxAdapterDecorator(IntPtr ptr, JniHandleOwnership ownership) : base(ptr, ownership)
        {
            
        }
        public SwipeableMvxAdapterDecorator(IMvxRecyclerAdapter decoratedAdapter, ISwipeableItemAdapter swipeableItemAdapter)
        {
            _decoratedAdapter = decoratedAdapter;
            _swipeableItemAdapter = swipeableItemAdapter;
        }

        public object GetItem(int position)
            => _decoratedAdapter.GetItem(position);

        public IEnumerable ItemsSource
        {
            get { return _decoratedAdapter.ItemsSource; }
            set { _decoratedAdapter.ItemsSource = value; }
        }

        public IItemTemplateSelector ItemTemplateSelector
        {
            get { return _decoratedAdapter.ItemTemplateSelector; }
            set { _decoratedAdapter.ItemTemplateSelector = value; }
        }

        public ICommand ItemClick
        {
            get { return _decoratedAdapter.ItemClick; }
            set { _decoratedAdapter.ItemClick = value; }
        }

        public ICommand ItemLongClick
        {
            get { return _decoratedAdapter.ItemLongClick; }
            set { _decoratedAdapter.ItemLongClick = value; }
        }


        public int OnGetSwipeReactionType(Object holder, int position, int x, int y) 
            => _swipeableItemAdapter.OnGetSwipeReactionType(holder, position, x, y);

        public void OnSetSwipeBackground(Object p0, int p1, int p2)
            => _swipeableItemAdapter.OnSetSwipeBackground(p0, p1, p2);

        public SwipeResultAction OnSwipeItem(Object p0, int p1, int p2)
            => _swipeableItemAdapter.OnSwipeItem(p0, p1, p2);


    }
}
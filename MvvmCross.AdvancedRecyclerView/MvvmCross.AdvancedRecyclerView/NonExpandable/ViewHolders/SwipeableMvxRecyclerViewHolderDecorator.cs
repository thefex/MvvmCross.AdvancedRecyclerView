using System;
using Android.Runtime;
using Android.Views;
using Com.H6ah4i.Android.Widget.Advrecyclerview.Swipeable;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Support.V7.RecyclerView;
using Object = Java.Lang.Object;

namespace MvvmCross.AdvancedRecyclerView.NonExpandable.ViewHolders
{
    internal class SwipeableMvxRecyclerViewHolderDecorator : Object, IMvxRecyclerViewHolder, ISwipeableItemViewHolder
    {
        private readonly IMvxRecyclerViewHolder _decoratedViewHolder;
        private readonly ISwipeableItemViewHolder _swipeableItemViewHolder;

        public SwipeableMvxRecyclerViewHolderDecorator(IntPtr ptr, JniHandleOwnership ownership) : base(ptr, ownership)
        {
        }

        public SwipeableMvxRecyclerViewHolderDecorator(IMvxRecyclerViewHolder decoratedViewHolder, ISwipeableItemViewHolder swipeableItemViewHolder)
        {
            _decoratedViewHolder = decoratedViewHolder;
            _swipeableItemViewHolder = swipeableItemViewHolder;
        }

        public IMvxBindingContext BindingContext
        {
            get { return _decoratedViewHolder.BindingContext; }
            set { _decoratedViewHolder.BindingContext = value; }
        }

        public void OnAttachedToWindow()
            => _decoratedViewHolder.OnAttachedToWindow();

        public void OnDetachedFromWindow()
            => _decoratedViewHolder.OnDetachedFromWindow();

        public object DataContext
        {
            get { return _decoratedViewHolder.DataContext; }
            set { _decoratedViewHolder.DataContext = value; }
        }

        public void OnSlideAmountUpdated(float p0, float p1, bool p2)
            => _swipeableItemViewHolder.OnSlideAmountUpdated(p0, p1, p2);

        public int AfterSwipeReaction
        {
            get { return _swipeableItemViewHolder.AfterSwipeReaction; }
            set { _swipeableItemViewHolder.AfterSwipeReaction = value; }
        }

        public float MaxDownSwipeAmount
        {
            get { return _swipeableItemViewHolder.MaxDownSwipeAmount; }
            set { _swipeableItemViewHolder.MaxDownSwipeAmount = value; }
        }

        public float MaxLeftSwipeAmount
        {
            get { return _swipeableItemViewHolder.MaxLeftSwipeAmount; }
            set { _swipeableItemViewHolder.MaxLeftSwipeAmount = value; }
        }

        public float MaxRightSwipeAmount
        {
            get { return _swipeableItemViewHolder.MaxRightSwipeAmount; }
            set { _swipeableItemViewHolder.MaxRightSwipeAmount = value; }
        }

        public float MaxUpSwipeAmount
        {
            get { return _swipeableItemViewHolder.MaxUpSwipeAmount; }
            set { _swipeableItemViewHolder.MaxUpSwipeAmount = value; }
        }

        public float SwipeItemHorizontalSlideAmount
        {
            get { return _swipeableItemViewHolder.SwipeItemHorizontalSlideAmount; }
            set { _swipeableItemViewHolder.SwipeItemHorizontalSlideAmount = value; }
        }

        public float SwipeItemVerticalSlideAmount
        {
            get { return _swipeableItemViewHolder.SwipeItemVerticalSlideAmount; }
            set { _swipeableItemViewHolder.SwipeItemVerticalSlideAmount = value; }
        }

        public int SwipeResult
        {
            get { return _swipeableItemViewHolder.SwipeResult; }
            set { _swipeableItemViewHolder.SwipeResult = value; }
        }

        public int SwipeStateFlags
        {
            get { return _swipeableItemViewHolder.SwipeStateFlags; }
            set { _swipeableItemViewHolder.SwipeStateFlags = value; }
        }

        public View SwipeableContainerView => _swipeableItemViewHolder.SwipeableContainerView;
    }
}
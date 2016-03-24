using System;
using Android.Runtime;
using Com.H6ah4i.Android.Widget.Advrecyclerview.Draggable;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Support.V7.RecyclerView;

namespace MvvmCross.AdvancedRecyclerView.NonExpandable.ViewHolders
{
    internal class DraggableMvxRecyclerViewHolderDecorator : Java.Lang.Object, IMvxRecyclerViewHolder, IDraggableItemViewHolder
    {
        private readonly IMvxRecyclerViewHolder _decoratedViewHolder;
        private readonly IDraggableItemViewHolder _draggableItemViewHolder;

        public DraggableMvxRecyclerViewHolderDecorator(IntPtr ptr, JniHandleOwnership ownership) : base(ptr, ownership)
        {
            
        }
        public DraggableMvxRecyclerViewHolderDecorator(IMvxRecyclerViewHolder decoratedViewHolder, IDraggableItemViewHolder draggableItemViewHolder)
        {
            _decoratedViewHolder = decoratedViewHolder;
            _draggableItemViewHolder = draggableItemViewHolder;
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

        public int DragStateFlags
        {
            get { return _draggableItemViewHolder.DragStateFlags; }
            set { _draggableItemViewHolder.DragStateFlags = value; }
        }
    }
}
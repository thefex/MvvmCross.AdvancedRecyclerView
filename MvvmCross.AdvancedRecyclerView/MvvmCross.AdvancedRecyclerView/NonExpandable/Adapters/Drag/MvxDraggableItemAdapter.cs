using System;
using Android.Runtime;
using Com.H6ah4i.Android.Widget.Advrecyclerview.Draggable;
using MvvmCross.Binding.ExtensionMethods;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.RecyclerView;
using Object = Java.Lang.Object;

namespace MvvmCross.AdvancedRecyclerView.NonExpandable.Adapters.Drag
{
    public abstract class MvxDraggableItemAdapter : Object, IDraggableItemAdapter
    {
        protected MvxDraggableItemAdapter(IntPtr ptr, JniHandleOwnership ownership) : base(ptr, ownership)
        {
        }

        protected MvxDraggableItemAdapter(IMvxRecyclerAdapter adapter)
        {
            Adapter = adapter;
        }

        protected IMvxRecyclerAdapter Adapter { get; }

        public MvxCommand<ItemMovedProperties> ItemMovedCommand { get; set; }

        public abstract bool OnCheckCanStartDrag(Object viewHolder, int position, int x, int y);

        public abstract ItemDraggableRange OnGetItemDraggableRange(Object p0, int p1);

        public virtual void OnMoveItem(int fromPosition, int toPosition)
        {
            var movedFromItem = Adapter.ItemsSource.ElementAt(fromPosition);
            var movedToItem = Adapter.ItemsSource.ElementAt(toPosition);

            ItemMovedCommand?.Execute(new ItemMovedProperties
            {
                MovedFromitem = movedFromItem,
                MovedToItem = movedToItem,
                MovedFromPosition = fromPosition,
                MovedToPosition = toPosition
            });
        }
    }
}
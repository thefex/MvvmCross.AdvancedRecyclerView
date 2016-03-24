using Com.H6ah4i.Android.Widget.Advrecyclerview.Draggable;
using Com.H6ah4i.Android.Widget.Advrecyclerview.Swipeable;
using MvvmCross.AdvancedRecyclerView.NonExpandable.Adapters.Drag.BuilderRelated;
using MvvmCross.Droid.Support.V7.RecyclerView;

namespace MvvmCross.AdvancedRecyclerView.NonExpandable.Adapters
{
    public class MvxAdvancedRecyclerAdapterBuilder
    {
        public IMvxRecyclerAdapter BuildAdapter(IMvxRecyclerAdapter baseAdapter)
        {
            IMvxRecyclerAdapter builtAdapter = baseAdapter;
            if (SwipeItemAdapter != null)
                builtAdapter = new SwipeableMvxAdapterDecorator(builtAdapter, SwipeItemAdapter);
            if (DraggableItemAdapter != null)
                builtAdapter = new DraggableMvxRecyclerAdapterDecorator(builtAdapter, DraggableItemAdapter);

            return builtAdapter;
        }

        public ISwipeableItemAdapter SwipeItemAdapter { get; set; }

        public IDraggableItemAdapter DraggableItemAdapter { get; set; }
    }
}
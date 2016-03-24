using Com.H6ah4i.Android.Widget.Advrecyclerview.Draggable;
using Com.H6ah4i.Android.Widget.Advrecyclerview.Swipeable;
using MvvmCross.Droid.Support.V7.RecyclerView;

namespace MvvmCross.AdvancedRecyclerView.NonExpandable.ViewHolders
{
    public class MvxAdvancedRecyclerViewHolderBuilder
    {
        public IMvxRecyclerViewHolder BuildViewHolder(IMvxRecyclerViewHolder baseHolder)
        {
            IMvxRecyclerViewHolder builtViewHolder = baseHolder;

            if (DraggableItemViewHolder != null)
                builtViewHolder = new DraggableMvxRecyclerViewHolderDecorator(builtViewHolder, DraggableItemViewHolder);
            if (SwipeableItemViewHolder != null)
                builtViewHolder = new SwipeableMvxRecyclerViewHolderDecorator(builtViewHolder, SwipeableItemViewHolder);

            return builtViewHolder;
        }

        public IDraggableItemViewHolder DraggableItemViewHolder { get; set; }

        public ISwipeableItemViewHolder SwipeableItemViewHolder { get; set; }
    }
}
namespace MvvmCross.AdvancedRecyclerView.NonExpandable.Adapters.Drag
{
    public class ItemMovedProperties
    {
        public object MovedFromitem { get; internal set; }

        public object MovedToItem { get; internal set; }

        public int MovedFromPosition { get; internal set; }

        public int MovedToPosition { get; internal set; }
    }
}
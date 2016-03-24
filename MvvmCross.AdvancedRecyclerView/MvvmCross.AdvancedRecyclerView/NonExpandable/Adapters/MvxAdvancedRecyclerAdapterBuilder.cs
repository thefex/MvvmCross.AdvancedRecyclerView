using MvvmCross.Binding.Droid.Views;
using MvvmCross.Droid.Support.V7.RecyclerView;

namespace MvvmCross.AdvancedRecyclerView.NonExpandable.Adapters
{
    internal abstract class MvxAdvancedRecyclerAdapterBuilder
    {
        public abstract IMvxRecyclerAdapter BuildAdapter();
    }
}
using System;
using System.Collections;
using System.Windows.Input;
using Android.Runtime;
using Com.H6ah4i.Android.Widget.Advrecyclerview.Draggable;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Droid.Support.V7.RecyclerView.ItemTemplates;
using Object = Java.Lang.Object;

namespace MvvmCross.AdvancedRecyclerView.NonExpandable.Adapters.Drag.BuilderRelated
{
    internal class DraggableMvxRecyclerAdapterDecorator : Object, IMvxRecyclerAdapter, IDraggableItemAdapter
    {
        private readonly IMvxRecyclerAdapter _decoratedAdapter;
        private readonly IDraggableItemAdapter _draggableItemAdapter;

        public DraggableMvxRecyclerAdapterDecorator(IntPtr ptr, JniHandleOwnership ownership) : base(ptr, ownership)
        {
        }

        public DraggableMvxRecyclerAdapterDecorator(IMvxRecyclerAdapter decoratedAdapter,
            IDraggableItemAdapter draggableItemAdapter)
        {
            _decoratedAdapter = decoratedAdapter;
            _draggableItemAdapter = draggableItemAdapter;
        }

        public bool OnCheckCanStartDrag(Object p0, int p1, int p2, int p3)
            => _draggableItemAdapter.OnCheckCanStartDrag(p0, p1, p2, p3);

        public ItemDraggableRange OnGetItemDraggableRange(Object p0, int p1)
            => _draggableItemAdapter.OnGetItemDraggableRange(p0, p1);

        public void OnMoveItem(int p0, int p1)
            => _draggableItemAdapter.OnMoveItem(p0, p1);

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
    }
}
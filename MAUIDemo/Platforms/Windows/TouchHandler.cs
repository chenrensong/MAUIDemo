using MAUIDemo.Controls;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDemo.Platforms.Windows
{
    public class TouchHandler : TouchHandlerBase<FrameworkElement>
    {
        private FrameworkElement _frameworkElement;

        public override void RegisterEvents(FrameworkElement frameworkElement)
        {
            _frameworkElement = frameworkElement;
            if (_frameworkElement != null)
            {
                _frameworkElement.PointerEntered += OnPointerEntered;
                _frameworkElement.PointerPressed += OnPointerPressed;
                _frameworkElement.PointerMoved += OnPointerMoved;
                _frameworkElement.PointerReleased += OnPointerReleased;
                _frameworkElement.PointerExited += OnPointerExited;
                _frameworkElement.PointerCanceled += OnPointerCancelled;
            }
        }

        public override void UnregisterEvents(FrameworkElement frameworkElement)
        {
            if (frameworkElement != null)
            {
                _frameworkElement.PointerEntered -= OnPointerEntered;
                _frameworkElement.PointerPressed -= OnPointerPressed;
                _frameworkElement.PointerMoved -= OnPointerMoved;
                _frameworkElement.PointerReleased -= OnPointerReleased;
                _frameworkElement.PointerExited -= OnPointerExited;
                _frameworkElement.PointerCanceled -= OnPointerCancelled;
            }
        }

        private void OnPointerEntered(object sender, PointerRoutedEventArgs args)
        {
            CommonHandler(sender, TouchActionType.Entered, args);
        }

        private void OnPointerPressed(object sender, PointerRoutedEventArgs args)
        {
            CommonHandler(sender, TouchActionType.Pressed, args);
            if (base.Capture)
            {
                (sender as FrameworkElement).CapturePointer(args.Pointer);
            }
        }

        private void OnPointerMoved(object sender, PointerRoutedEventArgs args)
        {
            CommonHandler(sender, TouchActionType.Moved, args);
        }

        private void OnPointerReleased(object sender, PointerRoutedEventArgs args)
        {
            CommonHandler(sender, TouchActionType.Released, args);
        }

        private void OnPointerExited(object sender, PointerRoutedEventArgs args)
        {
            CommonHandler(sender, TouchActionType.Exited, args);
        }

        private void OnPointerCancelled(object sender, PointerRoutedEventArgs args)
        {
            CommonHandler(sender, TouchActionType.Cancelled, args);
        }

        private void CommonHandler(object sender, TouchActionType touchActionType, PointerRoutedEventArgs args)
        {
            var position = args.GetCurrentPoint(sender as UIElement).Position;
            OnTouchAction(_frameworkElement, new TouchActionEventArgs(args.Pointer.PointerId, touchActionType, new TouchTrackingPoint((float)((position)).X, (float)((position)).Y), args.Pointer.IsInContact));
        }
    }
}

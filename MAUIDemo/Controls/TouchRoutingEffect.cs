using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDemo.Controls
{
    public partial class TouchRoutingEffect : RoutingEffect
    {
        public bool Capture { get; set; }

        public event TouchActionEventHandler TouchAction;

        public void OnTouchAction(object element, TouchActionEventArgs args)
        {
            TouchActionEventHandler touchAction = this.TouchAction;
            if (touchAction != null)
            {
                touchAction.Invoke(element, args);
            }
        }
    }
    public class TouchActionEventArgs : EventArgs
    {
        public long Id { get; private set; }

        public TouchActionType Type { get; private set; }

        public TouchTrackingPoint Location { get; private set; }

        public bool IsInContact { get; private set; }

        public TouchActionEventArgs(long id, TouchActionType type, TouchTrackingPoint location, bool isInContact)
        {
            Id = id;
            Type = type;
            Location = location;
            IsInContact = isInContact;
        }
    }

    public struct TouchTrackingPoint
    {
        public float X { get; set; }

        public float Y { get; set; }

        public TouchTrackingPoint(float x, float y)
        {
            this = default(TouchTrackingPoint);
            X = x;
            Y = y;
        }
    }

    public enum TouchActionType
    {
        Entered,
        Pressed,
        Moved,
        Released,
        Cancelled,
        Exited
    }

    public delegate void TouchActionEventHandler(object sender, TouchActionEventArgs args);
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDemo.Controls
{
    public class TouchHandlerBase<TElement>
    {
        public bool Capture { get; set; } = true;


        public event TouchActionEventHandler TouchAction;

        public void OnTouchAction(TElement element, TouchActionEventArgs args)
        {
            this.TouchAction?.Invoke(element, args);
        }

        public virtual void RegisterEvents(TElement element)
        {
        }

        public virtual void UnregisterEvents(TElement element)
        {
        }
    }


}

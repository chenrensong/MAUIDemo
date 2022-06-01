using MAUIDemo.Controls;
using MAUIDemo.Platforms.Windows;
using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDemo
{
    public class TouchPlatformEffect : Microsoft.Maui.Controls.Platform.PlatformEffect
    {
        private TouchHandler _touchHandler;

        private FrameworkElement _frameworkElement;

        private TouchRoutingEffect _touchEffect;

        public TouchPlatformEffect()
        {

        }

        protected override void OnAttached()
        {
            _frameworkElement = this.Control == null ? this.Container : this.Control;
            _touchEffect = (TouchRoutingEffect)Enumerable.FirstOrDefault(this.Element.Effects,
                (Effect e) => e is TouchRoutingEffect);
            if (_touchEffect != null)
            {
                _touchHandler = new TouchHandler();
                _touchHandler.TouchAction += (new TouchActionEventHandler(TouchHandlerOnTouch));
                _touchHandler.Capture = (_touchEffect.Capture);
                _touchHandler.RegisterEvents(_frameworkElement);
            }
        }

        private void TouchHandlerOnTouch(object sender, TouchActionEventArgs args)
        {
            _touchEffect.OnTouchAction(sender, args);
        }

        protected override void OnDetached()
        {
            if (_touchHandler != null)
            {
                ((TouchHandlerBase<FrameworkElement>)(object)_touchHandler).TouchAction -= (new TouchActionEventHandler(TouchHandlerOnTouch));
                ((TouchHandlerBase<FrameworkElement>)(object)_touchHandler).UnregisterEvents(_frameworkElement);
            }
        }
    }
}

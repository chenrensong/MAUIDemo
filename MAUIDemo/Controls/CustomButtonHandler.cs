using MAUIDemo.Controls;
using Microsoft.Maui.Handlers;

namespace MAUIDemo
{
    public partial class CustomButtonHandler 
    {
 
        public static PropertyMapper<ICustomButton, CustomButtonHandler>
             CustomButtonMapper =
              new PropertyMapper<ICustomButton, CustomButtonHandler>(ViewMapper)
              {
                  [nameof(ICustomButton.Content)] = MapContent,
              };


        public CustomButtonHandler() : base(CustomButtonMapper)
        {

        }

        public CustomButtonHandler(IPropertyMapper mapper = null) : base(mapper ?? CustomButtonMapper)
        {
        }
    }

  
}

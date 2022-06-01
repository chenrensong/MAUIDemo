using MAUIDemo.Controls;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;

namespace MAUIDemo;

public partial class CustomButtonHandler : ViewHandler<ICustomButton, UIButton>
{
    public CustomButtonHandler(IPropertyMapper mapper,
        CommandMapper commandMapper = null) : base(mapper, commandMapper)
    {
    }

    static void MapContent(CustomButtonHandler handler, ICustomButton view)
    {

    }
    protected override UIButton CreatePlatformView()
    {
        return new UIButton();
    }
}


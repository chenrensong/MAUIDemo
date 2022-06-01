using MAUIDemo.Controls;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDemo;

public partial class CustomButtonHandler : ViewHandler<ICustomButton, Android.Widget.Button>
{
    public CustomButtonHandler(IPropertyMapper mapper,
        CommandMapper commandMapper = null) : base(mapper, commandMapper)
    {
    }

    public static void MapContent(CustomButtonHandler handler, ICustomButton view)
    {

    }
    protected override Android.Widget.Button CreatePlatformView()
    {
        return new Android.Widget.Button(Context!);
    }
}


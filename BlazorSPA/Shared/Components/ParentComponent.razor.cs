using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSPA.Shared.Components
{
    public class ParentComponentBase : ComponentBase
    {
        protected string messageText;

        protected void ShowMessage(MouseEventArgs e)
        {
            messageText = "Blaze a new trail with Blazor!";
        }
    }
}

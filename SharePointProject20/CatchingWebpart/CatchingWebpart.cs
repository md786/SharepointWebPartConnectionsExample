using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace SharePointProject20.CatchingWebpart
{
    [ToolboxItemAttribute(false)]
    public class CatchingWebpart : WebPart
    {
        protected string messages = "This is catching Webpart and not connected";
        IMessage _imassage;
        [ConnectionConsumer("Massage")]
        public void Receiver(IMessage imassage)
        {
            messages = imassage.Message;
        }
        protected override void CreateChildControls()
        {
            this.Controls.Add(new Literal
            {
                Text = messages
            });
        }

        
    
    }
}

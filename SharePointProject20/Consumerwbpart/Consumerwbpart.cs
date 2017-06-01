using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace SharePointProject20.Consumerwbpart
{
    [ToolboxItemAttribute(false)]
    public class Consumerwbpart : WebPart,IMessage
    {
        private string _mesaage = "No Message";

        [WebBrowsable(true),
       WebDescription("This IS Browseble"),
        WebDisplayName("Massage"),
        Personalizable(PersonalizationScope.Shared),
            Category("Custom Properties")]
        public string Message {
            get
            {
                return _mesaage;
            }
            set
            {
                _mesaage=value;
            }
        }

        protected override void CreateChildControls()
        {
            this.Controls.Add(new Literal
            {
                Text = Message
            });
        }
        [ConnectionProvider("Massage")]
        public IMessage sender()
        {
            return this;
        }
    }
}

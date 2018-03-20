using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yzslz.yzslz_form
{
    public partial class WebSocketForm : Form
    {
        public WebSocketForm()
        {
            InitializeComponent();
        }

        private void btnOpenWebSocket_Click(object sender, EventArgs e)
        {

        }

        private void OpenWebSocketServer()
        {
            var listener = new HttpListener();
            listener.Prefixes.Add("http://*:9001/");
            listener.Start();
            listener.Start();
          //  var context = await listener.GetContextAsync();
         //   var wsContext = await context.AcceptWebSocketAsync(null);
          //  var ws = wsContext.WebSocket;
        }
    }
}

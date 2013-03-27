using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace APS
{
    public class Chat : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.SendMessage(name, message);
        }
    }
}
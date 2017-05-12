using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrandTheftMultiplayer.Server;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Constant;
using GrandTheftMultiplayer.Server.Managers;
using GrandTheftMultiplayer.Shared;
using GrandTheftMultiplayer.Shared.Math;

namespace CEFResource
{
    public class CEFCommands : Script
    {
        public CEFCommands()
        {
            API.onClientEventTrigger += OnClientTriggered;
        }

        [Command("test")]
        public void TestFunction(Client player)
        {
            API.triggerClientEvent(player, "testjs");
        }

        public void OnClientTriggered(Client player, string eventName, params object[] arguments)
        {
            switch (eventName)
            {
                case "BackToTheFuture":
                    API.sendNotificationToPlayer(player, "We're back where we started");
                    break;
            }
        }
    }
}

using System;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using ExampleResource.DialogHandler;

namespace ExampleResource.Commands
{
    public class DialogDisplayer : Script
    {
        public DialogDisplayer()
        {
            API.onClientEventTrigger += OnClientTriggerEvent;
        }
        
        [Command("showtextinput")]
        public ShowTextInput(Client player)
        {
          DBXHandler.ShowDialog(player, "dbx_text_input", "passwordinput", "Password", 
            "This dialog will be censored, please input some random word:",
            3, "Button 0", "Button 1", "Button 2",
            true
          );
        }
        
        [Command("showtextscroll")]
        public ShowTextScroll(Client player)
        {
          DBXHandler.ShowDialog(player, "dbx_text_scroll", "useragreement", "EULA", 
            "Please read through the text below and accept the conditions to proceed.",
            1, "I understand and agree!",
            "The user, also known as \"you\" the reader, will",
            "follow the rules stated at website/rules. The",
            "context, and therefore contract, may change",
            "at any unnotified time and place and should",
            "therefore be read occassionally.",
            " ",
            "Failture to follow the rules and guidelines",
            "explained at website/rules may result in",
            "closing of your account. At any moment your",
            "account may be suspended without any",
            "formal notice.",
            " ",
            "Your account is your responsibility and is",
            "your property which is allowed ownership",
            "over to you by this server's staff management",
            "and may be revoked at any time."
          );
        }
        
        [Command("showoptiondropdown")]
        public ShowOptionDropdown(Client player)
        {
          DBXHandler.ShowDialog(player, "dbx_option_dropdown", "optiondropdown", "Select in Dropdown", 
            "This dialog will show the options only when you hover over the dropdown.",
            3, "Button 0", "Button 1", "Button 2",
            "Option 0",
            "Option 1",
            "Option 2",
            "Option 3",
            "Option 4",
            "Option 5",
            "Option 6",
            "Option 7",
            "Option 8",
            "Option 9",
            "Option 10",
            "Option 11",
            "Option 12",
            "Option 13",
            "Option 14",
          );
        }
        
        [Command("showoptionscroll")]
        public ShowOptionScroll(Client player)
        {
          DBXHandler.ShowDialog(player, "dbx_option_scroll", "optionscroll", "Select in Selection", 
            "This dialog will display the options openly, please select one and then continue.",
            3, "Button 0", "Button 1", "Button 2",
            "Option 0",
            "Option 1",
            "Option 2",
            "Option 3",
            "Option 4",
            "Option 5",
            "Option 6",
            "Option 7",
            "Option 8",
            "Option 9",
            "Option 10",
            "Option 11",
            "Option 12",
            "Option 13",
            "Option 14",
          );
        }

        private void OnClientTriggerEvent(Client sender, string eventName, object[] args)
        {
            if (eventName == "passwordinput")
            {
              int buttonindex = Convert.ToInt32(args[0]);
              string inputtext = args[1].ToString();
              
              API.sendChatMessageToPlayer(player, "Client clicked on button: " + buttonindex);
              API.sendChatMessageToPlayer(player, "Client inputted string: " + inputtext);
            }
            else if (eventName == "useragreement") 
            {
              // Since there was only one button, the client must have clicked it in order to come here
              API.sendChatMessageToPlayer(player, "Client agreed to the EULA.");
            }
            else if (eventName == "optiondropdown") {
              int buttonindex = Convert.ToInt32(args[0]);
              int optionindex = Convert.ToInt32(args[1]);
              string optiontext = args[2].ToString();
              
              API.sendChatMessageToPlayer(player, "Clicked on button index " + buttonindex);
              API.sendChatMessageToPlayer(player, "Clicked on option index " + optionindex);
              API.sendChatMessageToPlayer(player, "Clicked on option text \"" + optiontext + "\"");
            }
            else if (eventName == "optionscroll") {
              int buttonindex = Convert.ToInt32(args[0]);
              int optionindex = Convert.ToInt32(args[1]);
              string optiontext = args[2].ToString();
              
              API.sendChatMessageToPlayer(player, "Clicked on button index " + buttonindex);
              API.sendChatMessageToPlayer(player, "Clicked on option index " + optionindex);
              API.sendChatMessageToPlayer(player, "Clicked on option text \"" + optiontext + "\"");
            }
        }
    }
}

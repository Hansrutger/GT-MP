using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Managers;


class Drawings : Script
{
    [Command("draw")]
    public void Draw(Client player, double fontsize, int wrap)
    {
        API.triggerClientEvent(player, "textfields", fontsize, wrap,
            "Once upon a time there was a little nab scripter called DirtyExpensive who worked for a bad coorporation called HUB:Network where they were very mean and stuff. One day Durty, I mean " +
            "\"Dirty\" felt like it was enough with the cowcrap and started his own thing and become very profound (is that even a word?) by a lot of members. The owner of HUB:Network became very " +
            "furious and started doing some bad stuff. Is this text long enough now to make multiple lines or do I keep having to pretend as if this story is a very well crypted line of events?"
        );
    }
}

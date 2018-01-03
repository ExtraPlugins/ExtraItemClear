
using System.Collections.Generic;
using Rocket.API;
using Rocket.Unturned.Chat;
using SDG.Unturned;

namespace ExtraConcentratedJuice.ExtraItemClear
{
    public class CommandClearItems : IRocketCommand
    {
        #region Properties

        public AllowedCaller AllowedCaller => AllowedCaller.Both;

        public string Name => "clearitems";

        public string Help => "Clears all of the items in the world.";

        public string Syntax => "/clearitems";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "extraitemclear.clearitems" };

        #endregion

        public void Execute(IRocketPlayer caller, string[] args)
        {
            ItemManager.askClearAllItems();
            UnturnedChat.Say(caller, "Items cleared successfully!");
        }
    }
}
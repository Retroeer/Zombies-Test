using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editor;
using System.ComponentModel.DataAnnotations;
using SWB_Player;
using SWB_Base;
using SWB_HUD;

namespace Sandbox.maptriggers
{
    [HammerEntity]
    [Display(Name = "Wall Buy", GroupName = "Triggers", Description = "Lets the Player purchase a weapon off the wall")]

    public partial class WallBuy : BaseTrigger
    {

        [Property(Title = "WallBuyWeapon")]
        public string WallBuyWeapon { get; set; }

        public WallBuy() { }

        public ExampleInventory Inventory { get; private set; }

        public override void StartTouch(Entity other)
        {
            base.StartTouch(other);

            if (!Game.IsServer) return;
            if (other is not ExamplePlayer) return;

            Log.Error("Touched tehe:)");


            if (Input.Pressed("use"))
            {
                Inventory.Add(new SWB_WEAPONS.(WallBuyWeapon));
            }
        }
    }
}

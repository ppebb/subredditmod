using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.UI;
using Terraria.ModLoader;

namespace rterrariamod.UI
{
    class MenuBar : UIState
    {
        public TestButton testButton;

        public override void OnInitialize()
        {
            testButton = new TestButton();

            Append(testButton);
        }
    }
}

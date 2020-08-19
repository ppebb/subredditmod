using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.UI;
using Terraria.ModLoader;

namespace rterrariamod.UI
{
    public class TestButton : UIElement
    {
        Color color = new Color(50, 255, 153);

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(ModContent.GetTexture("UI/testbutton"), new Vector2(Main.screenWidth + 20, Main.screenHeight - 20) / 2f, color); ;
        }
    }
}

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace remlo.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class Storm : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is a modded helmet.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 130;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return false;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "";
            player.meleeDamage *= 0.8f;
            player.thrownDamage *= 0.8f;
            player.rangedDamage *= 5.8f;
            player.magicDamage *= 0.8f;
            player.minionDamage *= 0.8f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("EquipMaterial"), 30);
            recipe.AddTile(mod.TileType("ExampleWorkbench"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
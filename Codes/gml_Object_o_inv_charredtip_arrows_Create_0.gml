title = "Charred-Tip Arrows"
event_inherited()
if (!variable_global_exists("charredAmmoArrowsDamage"))
  global.charredAmmoArrowsDamage = -50
if (!variable_global_exists("charredAmmoArrowsArmorP"))
  global.charredAmmoArrowsArmorP = -50
scr_consum_attribute_simple_add("Weapon_Damage", global.charredAmmoArrowsDamage)
scr_consum_attribute_simple_add("Armor_Piercing", global.charredAmmoArrowsArmorP)
base_price = 1 * stack
price = base_price

title = "Charred-Tip Bolts"
event_inherited()
if (!variable_global_exists("charredAmmoBoltsDamage"))
  global.charredAmmoBoltsDamage = -50
if (!variable_global_exists("charredAmmoBoltsArmorP"))
  global.charredAmmoBoltsArmorP = -50
scr_consum_attribute_simple_add("Weapon_Damage", global.charredAmmoBoltsDamage)
scr_consum_attribute_simple_add("Armor_Piercing", global.charredAmmoBoltsArmorP)
base_price = 1 * stack
price = base_price

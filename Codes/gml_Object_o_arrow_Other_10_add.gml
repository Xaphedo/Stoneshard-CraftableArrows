show_message("Within gml_Object_o_arrow_Other_10, loot_object is " + global.temp_loot_object_projectile)
scr_actionsLogUpdate("Probability of arrow surviving before blunt check is " + string(_arrowInsertChance) + "%")
var _resilient_ammo_loot = ["o_loot_bodkin_bolts", "o_loot_blunt_arrows", "o_loot_blunt_bolts"]
var _is_ammo_resilient = false
var i = 0
while (i < array_length(_resilient_ammo_loot))
{
    if (_resilient_ammo_loot[i] == global.temp_loot_object_projectile)
    {
        _is_ammo_resilient = true
        break
    }
    else
        i++
}
if (_is_ammo_resilient == true)
    _arrowInsertChance = ceil(100 - (100 - _arrowInsertChance) / 4)
scr_actionsLogUpdate("Probability of arrow surviving after blunt check is " + string(_arrowInsertChance) + "%")
scr_actionsLogUpdate("Probability of arrow surviving before barbed check is " + string(_arrowInsertChance) + "%")
var _delicate_ammo_loot = ["o_loot_bodkin_arrows", "o_loot_barbed_arrows", "o_loot_barbed_bolts"]
var _is_ammo_delicate = false
i = 0
while (i < array_length(_delicate_ammo_loot))
{
    if (_delicate_ammo_loot[i] == global.temp_loot_object_projectile)
    {
        _is_ammo_delicate = true
        break
    }
    else
        i++
}
if (_is_ammo_delicate == true)
    _arrowInsertChance = ceil(_arrowInsertChance / 4)
scr_actionsLogUpdate("Probability of arrow surviving after barbed check is " + string(_arrowInsertChance) + "%")
global.temp_loot_object_projectile = -4

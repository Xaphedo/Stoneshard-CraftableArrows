if (variable_global_exists("temp_loot_object_projectile") && global.temp_loot_object_projectile != -4)
{
    show_message("Within scr_damage_calculation, loot_object is " + string(global.temp_loot_object_projectile))
    var _blunt_ammo_loot = ["o_loot_bodkin_bolts", "o_loot_blunt_arrows", "o_loot_blunt_bolts"]
    var _is_ammo_blunt = false
    var i = 0
    while (i < array_length(_blunt_ammo_loot))
    {
        if (_blunt_ammo_loot[i] == global.temp_loot_object_projectile)
        {
            _is_ammo_blunt = true
            break
        }
        else
            i++
    }
    if (_is_ammo_blunt == true)
    {
        Blunt_Damage = Blunt_Damage + Slashing_Damage + Piercing_Damage + Rending_Damage
        Piercing_Damage = 0
        Slashing_Damage = 0
        Rending_Damage = 0
    }
    var _rending_ammo_loot = ["o_loot_bodkin_arrows","o_loot_barbed_arrows", "o_loot_barbed_bolts"]
    var _is_ammo_rending = false
    var i = 0
    while (i < array_length(_blunt_ammo_loot))
    {
        if (_rending_ammo_loot[i] == global.temp_loot_object_projectile)
        {
            _is_ammo_rending = true
            break
        }
        else
            i++
    }
    if (_is_ammo_rending == true)
    {
        Rending_Damage = Blunt_Damage + Slashing_Damage + Piercing_Damage + Rending_Damage
        Piercing_Damage = 0
        Slashing_Damage = 0
        Blunt_Damage = 0
    }
}
else
    show_message("Within scr_damage_calculation, loot_object is undefined")

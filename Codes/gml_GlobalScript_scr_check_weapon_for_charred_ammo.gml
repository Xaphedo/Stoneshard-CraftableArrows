function scr_check_weapon_for_charred_ammo() //gml_Script_scr_check_weapon_for_charred_ammo
{
  var _has_bladed_weapon = false
  with (o_inv_slot)
    {
      if is_weapon
      {
        if (type == "axe" || type == "sword" || type == "dagger" || type == "2hsword" || type == "2haxe")
          _has_bladed_weapon = true
      }
    }
  return _has_bladed_weapon
}

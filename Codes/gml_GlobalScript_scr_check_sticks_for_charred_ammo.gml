function scr_check_sticks_for_charred_ammo() //gml_Script_scr_check_sticks_for_charred_ammo
{
    if (instance_exists(o_inv_stick_oak) || instance_exists(o_inv_stick_linden))
        return true;
    return false;
}
function scr_check_chartiparrows_for_arrowheads() //gml_Script_scr_check_chartiparrows_for_arrowheads 
{
    if (instance_exists(o_inv_charredtip_arrows))
    {
        with (o_inv_charredtip_arrows)
        {
            if (owner = o_inventory.id)
                return true
        }
    }
    return false
}
function scr_check_chartipbolts_for_arrowheads() //gml_Script_scr_check_chartipbolts_for_arrowheads 
{
    if (instance_exists(o_inv_charredtip_bolts))
    {
        with (o_inv_charredtip_bolts)
        {
            if (owner = o_inventory.id)
                return true
        }
    }
    return false
}
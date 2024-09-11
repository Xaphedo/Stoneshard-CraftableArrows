function scr_check_hideglue_for_arrowheads() //gml_Script_scr_check_hideglue_for_arrowheads 
{
    if (instance_exists(o_inv_hideglue))
    {
        with (o_inv_hideglue)
        {
            if (owner = o_inventory.id)
                return true
        }
    }
    return false
}
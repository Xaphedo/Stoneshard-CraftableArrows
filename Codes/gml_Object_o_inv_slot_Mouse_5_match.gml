    else if object_is_ancestor(object_index, o_inv_ammunition_parent)
    {
        if (owner.object_index != o_trade_inventory)
            scr_create_context_menu("Sell", "Replace", "Equip", "Split_Stack", "Use_scroll", "Throw", "Drop")
        else
            scr_create_context_menu("Buy")
    }
    else if object_is_ancestor(object_index, o_inv_consum_passive)
    {
        if (owner.object_index != o_trade_inventory)
            scr_create_context_menu("Sell", "Replace", "Flay", "Equip", "Throw", "Split_Stack", "Drop")
        else
            scr_create_context_menu("Buy")
    }

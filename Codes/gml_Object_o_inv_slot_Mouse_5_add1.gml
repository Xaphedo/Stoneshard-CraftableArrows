    else if object_is_ancestor(object_index, o_inv_arrowheads_parent)
    {
        if (owner.object_index != o_trade_inventory)
            scr_create_context_menu("Sell", "Throw", "Split_Stack", "Drop", "Arrowheads_Make_Arrows", "Arrowheads_Make_Bolts")
        else
            scr_create_context_menu("Buy", "Split_Stack")
    }
if scr_chance_value(3, 1)
{
  with (scr_inventory_add_item(choose(o_inv_arrowheads_leafshaped, o_inv_arrowheads_broadhead, o_inv_arrowheads_bodkin)))
    stack = irandom_range(7, 25)
}

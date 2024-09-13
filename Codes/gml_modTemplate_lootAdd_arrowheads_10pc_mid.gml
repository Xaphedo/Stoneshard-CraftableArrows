if scr_chance_value(10)
{
  repeat irandom_range(1, 3)
    with (scr_inventory_add_item(choose(o_inv_arrowheads_leafshaped, o_inv_arrowheads_broadhead, o_inv_arrowheads_bodkin)))
      stack = irandom_range(1, 21)
}

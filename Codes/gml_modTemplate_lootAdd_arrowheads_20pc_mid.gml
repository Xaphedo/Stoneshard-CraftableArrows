else if scr_chance_value(33)
{
  with (scr_inventory_add_item(choose(o_inv_arrowheads_leafshaped, o_inv_arrowheads_broadhead, o_inv_arrowheads_bodkin)))
  ds_map_replace(data, "Stack", (4 + (irandom_range(1, 11))))
}

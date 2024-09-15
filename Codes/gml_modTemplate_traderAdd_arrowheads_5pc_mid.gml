if (scr_chance_value(5))
{
  new_stacked_items_stock = choose([o_inv_arrowheads_leafshaped, 6, 14],[o_inv_arrowheads_broadhead, 4, 8],[o_inv_arrowheads_bodkin, 4, 8])
  stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
}

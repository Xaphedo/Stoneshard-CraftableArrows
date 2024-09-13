if (scr_chance_value(50))
{
  new_stacked_items_stock = choose([o_inv_arrowheads_leafshaped, 10, 20],[o_inv_arrowheads_broadhead, 6, 12],[o_inv_arrowheads_bodkin, 6, 12])
  stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
}

if (scr_chance_value(15))
{
  new_stacked_items_stock = choose([o_inv_arrowheads_leafshaped, 3, 5],[o_inv_arrowheads_broadhead, 1, 2],[o_inv_arrowheads_bodkin, 1, 2])
  stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
}

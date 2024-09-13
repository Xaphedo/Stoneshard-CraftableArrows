if (scr_chance_value(50))
{
  if (scr_chance_value(20))
  {
    new_stacked_items_stock = choose([o_inv_arrowheads_leafshaped, 10, 20],[o_inv_arrowheads_broadhead, 5, 10],[o_inv_arrowheads_bodkin, 5, 10])
  }
  else
  {
    new_stacked_items_stock = choose([o_inv_arrowheads_leafshaped, 3, 5],[o_inv_arrowheads_broadhead, 1, 2],[o_inv_arrowheads_bodkin, 1, 2])
  }
  stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
}

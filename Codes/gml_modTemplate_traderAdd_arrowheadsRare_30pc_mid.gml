if (scr_chance_value(30))
{
  new_stacked_items_stock = choose([o_inv_arrowheads_broadhead, 10, 15],[o_inv_arrowheads_bodkin, 10, 15])
  stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
}

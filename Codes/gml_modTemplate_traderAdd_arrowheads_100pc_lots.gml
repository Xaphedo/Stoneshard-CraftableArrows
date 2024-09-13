if (scr_chance_value(25))
{
  new_stacked_items_stock = choose([o_inv_arrowheads_leafshaped, 40, 65, o_inv_arrowheads_broadhead, 5, 10, o_inv_arrowheads_bodkin, 5, 10],[o_inv_arrowheads_broadhead, 20, 45, o_inv_arrowheads_bodkin, 5, 10, o_inv_arrowheads_leafshaped, 10, 20],[o_inv_arrowheads_bodkin, 20, 45, o_inv_arrowheads_broadhead, 5, 10, o_inv_arrowheads_leafshaped, 10, 20])
}
else
{
  new_stacked_items_stock = choose([o_inv_arrowheads_leafshaped, 10, 20, o_inv_arrowheads_broadhead, 5, 10, o_inv_arrowheads_bodkin, 5, 10])
}
stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)

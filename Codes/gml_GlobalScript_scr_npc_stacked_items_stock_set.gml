function scr_npc_stacked_items_stock_set() //gml_Script_scr_npc_stacked_items_stock_set
{
	stacked_items_stock = []

	switch (object_index)
	{
		case (o_npc_smith):
		case (o_npc_smith_mannshire):
		case (o_npc_vogt_smith01gq):
			if (scr_chance_value(25))
			{
			  new_stacked_items_stock = choose([o_inv_arrowheads_leafshaped, 40, 65, o_inv_arrowheads_broadhead, 5, 10, o_inv_arrowheads_bodkin, 5, 10],[o_inv_arrowheads_broadhead, 20, 45, o_inv_arrowheads_bodkin, 5, 10, o_inv_arrowheads_leafshaped, 10, 20],[o_inv_arrowheads_bodkin, 20, 45, o_inv_arrowheads_broadhead, 5, 10, o_inv_arrowheads_leafshaped, 10, 20])
			}
			else
			{
			  new_stacked_items_stock = [o_inv_arrowheads_leafshaped, 10, 20, o_inv_arrowheads_broadhead, 5, 10, o_inv_arrowheads_bodkin, 5, 10]
			}
			stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
			break

		case (o_npc_pawnshop_owner):
			if (scr_chance_value(50))
			{
			  new_stacked_items_stock = choose([o_inv_arrowheads_leafshaped, 10, 20],[o_inv_arrowheads_broadhead, 6, 12],[o_inv_arrowheads_bodkin, 6, 12])
			  stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
			}
			break

		case (o_npc_merchant):
		case (o_npc_merchant_mannshire):
		case (o_npc_Merchant01d):
		case (o_npc_merchant01MS):
			if (scr_chance_value(30))
			{
			  new_stacked_items_stock = choose([o_inv_arrowheads_broadhead, 10, 15],[o_inv_arrowheads_bodkin, 10, 15])
			  stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
			}
			break

		case (o_npc_carpenter):
		case (o_npc_carpenter_mannshire):
		case (o_npc_vogt_carpenter01gq):
		case (o_npc_artisan_carpenter01gq):
		case (o_npc_artisan_carpenter02gq):
		case (o_npc_artisan_carpenter03gq):
		case (o_npc_artisan_carpenter04gq):
			new_stacked_items_stock = [o_inv_charredtip_arrows, 20, 33, o_inv_charredtip_bolts, 20, 33, o_inv_hideglue, 10, 30, o_inv_arrowheads_leafshaped, 2, 10, o_inv_arrowheads_broadhead, 1, 5, o_inv_arrowheads_bodkin, 1, 5]
			stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
			break

		case (o_npc_apprentice_carpenter01gq):
		case (o_npc_apprentice_carpenter02gq):
			new_stacked_items_stock = choose([o_inv_charredtip_arrows, 20, 33, o_inv_charredtip_bolts, 20, 33], [o_inv_hideglue, 10, 30], [o_inv_arrowheads_leafshaped, 2, 10, o_inv_arrowheads_broadhead, 1, 5, o_inv_arrowheads_bodkin, 1, 5])
			stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
			break

		case (o_npc_vogt_tailor01gq):
			new_stacked_items_stock = [o_inv_hideglue, 600, 1950]
			stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
			break

		case (o_npc_tailor):
		case (o_npc_artisan_tailor01gq):
		case (o_npc_artisan_tailor02gq):
		case (o_npc_artisan_tailor03gq):
		case (o_npc_artisan_tailor04gq):
			new_stacked_items_stock = [o_inv_hideglue, 50, 250]
			stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
			break

		case (o_npc_smith_son):
		case (o_npc_apprentice_tailor01gq):
			new_stacked_items_stock = [o_inv_hideglue, 5, 25]
			stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
			break

		case (o_npc_trapperA):
		case (o_npc_trapperB):
			new_stacked_items_stock = [o_inv_charredtip_arrows, 3, 12, o_inv_charredtip_bolts, 3, 12]
			stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
			break

		case (o_npc_drugdealer):
			if (scr_chance_value(50))
			{
			  new_stacked_items_stock = [o_inv_hideglue, 5, 25]
			  stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
			}
			break
	}

	if (array_length(stacked_items_stock) < 1)
	{

		if (object_is_ancestor(object_index, o_class_innkeeper))
		{
			new_stacked_items_stock = choose([o_inv_arrowheads_leafshaped, 3, 8],[o_inv_arrowheads_broadhead, 1, 4],[o_inv_arrowheads_bodkin, 1, 4])
			stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
		}

		else if (object_is_ancestor(object_index, o_brynn_smith))
		{
			if (scr_chance_value(25))
			{
			  new_stacked_items_stock = choose([o_inv_arrowheads_leafshaped, 40, 65, o_inv_arrowheads_broadhead, 5, 10, o_inv_arrowheads_bodkin, 5, 10],[o_inv_arrowheads_broadhead, 20, 45, o_inv_arrowheads_bodkin, 5, 10, o_inv_arrowheads_leafshaped, 10, 20],[o_inv_arrowheads_bodkin, 20, 45, o_inv_arrowheads_broadhead, 5, 10, o_inv_arrowheads_leafshaped, 10, 20])
			}
			else
			{
			  new_stacked_items_stock = [o_inv_arrowheads_leafshaped, 10, 20, o_inv_arrowheads_broadhead, 5, 10, o_inv_arrowheads_bodkin, 5, 10]
			}
			stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
		}

		else if ((object_is_ancestor(object_index, o_npc_guard_brynn)) || (object_is_ancestor(object_index, o_npc_guard)))
		{
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
		}

		else if (object_is_ancestor(object_index, o_npc_brynn))
		{
			if (scr_chance_value(5))
			{
			  new_stacked_items_stock = choose([o_inv_arrowheads_leafshaped, 6, 14],[o_inv_arrowheads_broadhead, 4, 8],[o_inv_arrowheads_bodkin, 4, 8])
			  stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
			}
		}

		else if (object_is_ancestor(object_index, o_npc_peasant))
		{
			if (scr_chance_value(15))
			{
			  new_stacked_items_stock = choose([o_inv_arrowheads_leafshaped, 3, 5],[o_inv_arrowheads_broadhead, 1, 2],[o_inv_arrowheads_bodkin, 1, 2])
			  stacked_items_stock = array_concat(stacked_items_stock, new_stacked_items_stock)
			}
        }
    }
}
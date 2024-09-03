case "Make_Charred_Arrows":
  ds_list_add(context_name, "Make_Charred_Arrows", ds_list_find_value(global.context_menu, 101))
  if (!scr_check_sticks_for_charred_ammo())
    ds_list_add(context_desc, 0, ds_list_find_value(global.context_menu, 103))
  else if other.is_fire
    ds_list_add(context_desc, 1, 0)
  else
    ds_list_add(context_desc, 0, ds_list_find_value(global.context_menu, 74))
  break
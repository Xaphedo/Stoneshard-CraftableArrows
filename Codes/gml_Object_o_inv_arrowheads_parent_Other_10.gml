event_inherited()
if (variable_global_exists("arrowheadsTradingCat"))
  ds_list_replace(category, 0, string(global.arrowheadsTradingCat))

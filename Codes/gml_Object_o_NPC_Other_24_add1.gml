if (_temp_stacked_items_stock != 0 && is_array(_temp_stacked_items_stock) && array_length(_temp_stacked_items_stock) > 0)
{
    var _stacked_i_s = _temp_stacked_items_stock
    show_message("_stacked_i_s is " + string(_stacked_i_s))
    if ((array_length(_stacked_i_s) % 3) != 0)
        show_message("stacked_items_stock is not a multiple of 3! Stackable items will not be added")
    else
    {
        for (i = 0; i < array_length(_stacked_i_s); i += 3)
        {
            var _stack_item_to_add = _stacked_i_s[i]
            var _min_stack_to_add = max(1, _stacked_i_s[(i + 1)])
            var _max_stack_to_add = max(1, _stacked_i_s[(i + 2)])
            var _stack_size_to_add = irandom_range(_min_stack_to_add, _max_stack_to_add)
            var _tempStackOfItemToAdd = 0
            var _tempStackLimitOfItemToAdd = 0
            if instance_exists(_stack_item_to_add)
            {
                if variable_instance_exists(_stack_item_to_add, "stack")
                    _tempStackOfItemToAdd = _stack_item_to_add.stack
                else
                    scr_actionsLogUpdate("There is no viable stack information for the following item:" + string(_stack_item_to_add) + ". It will not be added to the trader's inventory.")
                if variable_instance_exists(_stack_item_to_add, "stack_limit")
                    _tempStackLimitOfItemToAdd = _stack_item_to_add.stack_limit
                else
                    scr_actionsLogUpdate("There is no viable stack limit information for the following item:" + string(_stack_item_to_add) + ". It will not be added to the trader's inventory.")
            }
            else
            {
                var _temp_item_to_destroy = instance_create_depth(-15000, -15000, 0, _stack_item_to_add)
                if variable_instance_exists(id, "stack")
                    _tempStackOfItemToAdd = stack
                else
                    scr_actionsLogUpdate("There is no viable stack information for the following item:" + string(_stack_item_to_add) + ". It will not be added to the trader's inventory.")
                if variable_instance_exists(id, "stack_limit")
                    _tempStackLimitOfItemToAdd = stack_limit
                else
                    scr_actionsLogUpdate("There is no viable stack limit information for the following item:" + string(_stack_item_to_add) + ". It will not be added to the trader's inventory.")
                instance_destroy(_temp_item_to_destroy)
            }
            if (_tempStackOfItemToAdd > 0 && _tempStackLimitOfItemToAdd > 0)
            {
                repeat floor(1 + _stack_size_to_add / (_tempStackLimitOfItemToAdd + 1))
                {
                    if (_stack_size_to_add > 0)
                    {
                        with (scr_inventory_add_item(_stack_item_to_add))
                        {
                            stack = min(_tempStackLimitOfItemToAdd, _stack_size_to_add)
                            _stack_size_to_add -= stack
                        }
                    }
                }
            }
        }
    }
}

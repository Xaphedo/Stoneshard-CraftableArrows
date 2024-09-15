function scr_glueArrowheads(argument0) //gml_Script_scr_glueArrowheads
{
 // Initialize variables
    //show_message("self is: " + scr_id_get_name(self))
    //var arrowhead = self; // The initiating object instance

    var chartip_type = argument0 // could be o_inv_charredtip_bolts or o_inv_charredtip_arrows
    if (chartip_type == o_inv_charredtip_arrows)
        var output_of_glueing = self.makeswith_chartip_arrows; // The specific type of ammo stored within the arrowhead
    else if (chartip_type == o_inv_charredtip_bolts)
        var output_of_glueing = self.makeswith_chartip_bolts; // The specific type of ammo stored within the arrowhead
    var total_ammo_created = 0; // To keep track of the total ammo created
    var _arrowhead_stack_temp = self.stack
    //show_message("arrowhead stack is: " + string(_arrowhead_stack_temp))
    
    var _hideglue_index = 0
    var _chartip_index = 0
    var _min_stack = 0
    var _hideglue
    var _hideglue_stack
    var _chartip
    var _chartip_stack


    while (_arrowhead_stack_temp > 0 && instance_number(o_inv_hideglue) > 0 && instance_number(chartip_type) > 0) {
        
        // Find the first instance of o_inv_hideglue and store its stack number
        if !instance_exists(instance_find(o_inv_hideglue, _hideglue_index))
            break
        if instance_exists(o_trade_inventory)
        {
            while (instance_find(o_inv_hideglue, _hideglue_index).owner = o_trade_inventory.id)
            {
                _hideglue_index = _hideglue_index + 1
            }
            if !instance_exists(instance_find(o_inv_hideglue, _hideglue_index))
                break
        }

        _hideglue = instance_find(o_inv_hideglue, _hideglue_index)
        _hideglue_stack = _hideglue.stack
        
        // Find the first instance of chartip and store its stack number
        if !instance_exists(instance_find(chartip_type, _chartip_index))
            break
        if instance_exists(o_trade_inventory)
        {
            while (instance_find(chartip_type, _chartip_index).owner = o_trade_inventory.id)
            {
                _chartip_index = _chartip_index + 1
            }
            if !instance_exists(instance_find(chartip_type, _chartip_index))
                break
        }

        _chartip = instance_find(chartip_type, _chartip_index)
        _chartip_stack = _chartip.stack

        // Get the minimum of the three stack numbers
        _min_stack = min(_arrowhead_stack_temp, _hideglue_stack, _chartip_stack)

        // Decrease all three stack numbers by _min_stack
        _arrowhead_stack_temp -= _min_stack
        _hideglue_stack -= _min_stack
        _chartip_stack -= _min_stack

        _hideglue.stack = _hideglue_stack
        _chartip.stack = _chartip_stack

        if (_hideglue_stack == 0)
            _hideglue_index = _hideglue_index + 1
        if (_chartip_stack == 0)
            _chartip_index = _chartip_index + 1

        // Update total ammo created
        total_ammo_created += _min_stack
        _min_stack = 0
    }

    // Green text log output
    if (total_ammo_created > 0) {
        var _colorsNamesArray = []
        var _colorsNamesArrayIndex = 0

        if instance_exists(output_of_glueing)
        {
            nameof_output_of_glueing = scr_id_get_name(output_of_glueing)
        }
        else
        {
            var _temp_item_to_destroy = instance_create_depth(-15000, -15000, 0, output_of_glueing)
            nameof_output_of_glueing = scr_id_get_name(output_of_glueing)
            instance_destroy(_temp_item_to_destroy)
        }

        nameof_output_of_glueing = nameof_output_of_glueing

        for (var _h = 0; _h < total_ammo_created; _h++) {
            _colorsNamesArray[_colorsNamesArrayIndex][0] = "~lg~"
            _colorsNamesArray[_colorsNamesArrayIndex][1] = string(nameof_output_of_glueing)
            var _space = scr_actionsLogGetSpace()
            var _commaEnum = scr_actionsLogGetSymbol("commaEnum")
            var _dot = scr_actionsLogGetSymbol("dot")
            global.actionsLogBuffer = scr_actionsLogArrayPattern((_commaEnum + _space), _space, _dot, _colorsNamesArray)
            scr_actionsLog("charredAmmo", [scr_id_get_name(o_player)]); // gml_GlobalScript_table_log_text
            
        }
    }

    scr_inventory_add_item(output_of_glueing, o_inventory, total_ammo_created)

    if (total_ammo_created == 1)
        audio_play_sound(choose(snd_barell_box_impact_1, snd_barell_box_impact_2, snd_barell_box_impact_3, snd_barell_box_impact_4), 4, 0)
    else if (total_ammo_created > 1 && total_ammo_created < 6){
        audio_play_sound(choose(snd_barell_box_impact_1, snd_barell_box_impact_2, snd_barell_box_impact_3, snd_barell_box_impact_4), 4, 0)
        audio_play_sound(snd_arrow_drop, 4, 0)
        //audio_play_sound(choose(snd_barell_box_impact_3, snd_barell_box_impact_4), 4, 0, 0.7, 0.3)
    }
    else if (total_ammo_created >= 6){
        audio_play_sound(choose(snd_barell_box_impact_1, snd_barell_box_impact_2, snd_barell_box_impact_3, snd_barell_box_impact_4), 4, 0)
        audio_play_sound(snd_arrow_pick, 4, 0)
        audio_play_sound(snd_arrow_drop, 4, 0)
        //audio_play_sound(choose(snd_barell_box_impact_3, snd_barell_box_impact_4), 4, 0, 0.6, 0.2)
        //audio_play_sound(choose(snd_barell_box_impact_1, snd_barell_box_impact_2), 4, 0, 0.7, 0.5, 0.7)
    }

    total_ammo_created = 0

    self.stack = _arrowhead_stack_temp 
    //self.stack = min(_arrowhead_stack_temp,1)
}

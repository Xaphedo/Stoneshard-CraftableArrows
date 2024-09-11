function scr_makeCharredAmmo(argument0,argument1,argument2) //gml_Script_scr_makeCharredAmmo
{
    if (is_undefined(argument0))
        argument0 = o_inv_charredtip_arrows // type of ammo produced
    if (is_undefined(argument1))
        argument1 = 1 // minimum ammo produced
    if (is_undefined(argument2))
        argument2 = 2 // maximum ammo produced
    if (!variable_global_exists("makeCharredAmmoArrowsMin"))
        global.makeCharredAmmoArrowsMin = argument1
    if (!variable_global_exists("makeCharredAmmoArrowsMax"))
        global.makeCharredAmmoArrowsMax = argument2
    if (!variable_global_exists("makeCharredAmmoBoltsMin"))
        global.makeCharredAmmoBoltsMin = argument1
    if (!variable_global_exists("makeCharredAmmoBoltsMax"))
        global.makeCharredAmmoBoltsMax = argument2
    if (argument0 == o_inv_charredtip_arrows)
    {
        var _ammo_min = global.makeCharredAmmoArrowsMin
        var _ammo_max = global.makeCharredAmmoArrowsMax
    }
    if (argument0 == o_inv_charredtip_bolts)
    {
        var _ammo_min = global.makeCharredAmmoBoltsMin
        var _ammo_max = global.makeCharredAmmoBoltsMax
    }

    var _rawObjectsArray = [o_inv_stick_oak, o_inv_stick_linden]
    var _cookedResult = argument0 // could be o_inv_charredtip_bolts or o_inv_charredtip_arrows
    var _rawObjectsArrayLength = array_length(_rawObjectsArray)
    var _colorsNamesArray = false
    var _colorsNamesArrayIndex = 0
    for (var _i = 0; _i < _rawObjectsArrayLength; _i++)
    {
        var _rawObject = _rawObjectsArray[_i]
        with (_rawObject)
        {
            var _select = select
            instance_destroy()
            var _ammo_created = irandom_range(min(_ammo_min, _ammo_max), max(_ammo_min, _ammo_max))
            with (scr_inventory_add_item(_cookedResult, o_inventory, _ammo_created))
            {
                if _select
                {
                    select = true
                    global.inv_select = true
                    event_user(1)
                    scr_guiPositionOffsetUpdate(id, (global.guiMouseX - x + select_offset_x), (global.guiMouseY - y + select_offset_y))
                }
                sh_diss = 220
            }


            if instance_exists(_cookedResult)
            {
            nameof_cookedResult = scr_id_get_name(_cookedResult)
            }
            else
            {
                var _temp_item_to_destroy = instance_create_depth(-15000, -15000, 0, _cookedResult)
                    nameof_cookedResult = scr_id_get_name(_cookedResult)
                instance_destroy(_temp_item_to_destroy)
            }

            nameof_cookedResult = nameof_cookedResult

            for (var _h = 0; _h < _ammo_created; _h++)
            {
                _colorsNamesArray[_colorsNamesArrayIndex][0] = "~lg~"
                _colorsNamesArray[_colorsNamesArrayIndex][1] = string(nameof_cookedResult)
                _colorsNamesArrayIndex++
            }
            if is_array(_colorsNamesArray)
            {
                var _space = scr_actionsLogGetSpace()
                var _commaEnum = scr_actionsLogGetSymbol("commaEnum")
                var _dot = scr_actionsLogGetSymbol("dot")
                global.actionsLogBuffer = scr_actionsLogArrayPattern((_commaEnum + _space), _space, _dot, _colorsNamesArray)
                scr_actionsLog("charredAmmo", [scr_id_get_name(o_player)]) //gml_GlobalScript_table_log_text
                audio_play_sound(choose(1645, 1646), 4, 0)
            }
            var _colorsNamesArray = false
            var _colorsNamesArrayIndex = 0
        }
    }

}

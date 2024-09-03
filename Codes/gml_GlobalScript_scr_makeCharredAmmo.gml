function scr_makeCharredAmmo(argument0,argument1,argument2) //gml_Script_scr_makeCharredAmmo
{
    if (is_undefined(argument0))
        argument0 = o_inv_charredtiparrows // type of ammo produced
    if (is_undefined(argument1))
        argument1 = 2 // minimum ammo produced
    if (is_undefined(argument2))
        argument2 = 3 // maximum ammo produced

    //argument1 = int64(argument1)
    //argument2 = int64(argument2)
    var _rawObjectsArray = [o_inv_stick_oak, o_inv_stick_linden]
    var _cookedResult = argument0 // could be o_inv_charredtipbolts or o_inv_charredtiparrows
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
                var _ammo_created = irandom_range(min(argument1, argument2), max(argument1, argument2))
                for (var _h = 0; _h < _ammo_created; _h++)
                {
                    _colorsNamesArray[_colorsNamesArrayIndex][0] = "~lg~"
                    _colorsNamesArray[_colorsNamesArrayIndex][1] = scr_id_get_name(_cookedResult)
                    _colorsNamesArrayIndex++
                }
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
            }
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
}

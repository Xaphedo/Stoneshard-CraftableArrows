        with (scr_guiCreateInteractive(o_inventory.id, _objectIndex))
        {
            owner = o_inventory.id
            stack = _result
            select = true
            global.inv_select = true
            o_floor_target.draw_cursor = 0
            event_perform(ev_alarm, 0)
            event_user(1)
        }

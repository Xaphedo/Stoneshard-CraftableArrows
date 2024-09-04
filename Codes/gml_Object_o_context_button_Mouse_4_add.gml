/*
case "Make_Charred_Arrows":
  with (interact_id)
  {
    if scr_can_interract_posgrid(id, in_grid)
      scr_makeCharredAmmo(o_inv_charredtiparrows,2,4)
    else
    {
      interract_event = [scr_makeCharredAmmo, o_inv_charredtiparrows, 2, 4]
      if (!in_grid)
        scr_delay_move()
      else
        scr_delay_move_grid()
    }
  }
  break
*/

if (is_numeric(interract_event) && !is_array(interract_event))
  event_user(interract_event)
if (is_array(interract_event) && string(object_get_name(array_get(interract_event, 1))) == "o_inv_charredtip_arrows")
{
  scr_makeCharredAmmo(o_inv_charredtip_arrows)
//  show_message(string(array_get(interract_event, 0)) + " " + string(object_get_name(array_get(interract_event, 1))) + " " + string(array_get(interract_event, 2)) + " " + string(array_get(interract_event, 3)))
//  script_execute(array_get(interract_event, 0),array_get(interract_event, 1),array_get(interract_event, 2),array_get(interract_event, 3))
}

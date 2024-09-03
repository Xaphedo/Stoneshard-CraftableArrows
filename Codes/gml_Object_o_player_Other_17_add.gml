if (is_numeric(interract_event) && !is_array(interract_event))
  event_user(interract_event)
else
  script_execute(array_get(interract_event, 0),array_get(interract_event, 1),array_get(interract_event, 2))

if (is_numeric(interract_event) && !is_array(interract_event))
  event_user(interract_event)
else
  script_execute(interract_event[0], interract_event[1], interract_event[2], interract_event[3])

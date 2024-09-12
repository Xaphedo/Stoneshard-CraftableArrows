event_inherited()
charge = 1
drop_gui_sound = snd_powder_drop
pickup_sound = snd_powder_pick
draw_charges = 0
scr_consum_atr("hideglue")
stack = 50
stack_limit = 500
can_stack = true
base_price = 2
price = base_price * stack

relative_stack = stack / stack_limit
if (relative_stack <= 0.1)
    i_index = 0
else if (relative_stack <= 0.2)
    i_index = 1
else if (relative_stack <= 0.5)
    i_index = 2
else if (relative_stack <= 0.6)
    i_index = 3
else if (relative_stack <= 0.9)
    i_index = 4
else
    i_index = 5
if (stack <= 0)
    instance_destroy()

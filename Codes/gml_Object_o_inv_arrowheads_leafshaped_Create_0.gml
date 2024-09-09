event_inherited()
title = "Leaf-Shaped Arrowheads"
base_price = 4 * stack
price = base_price
i_number = image_number
s_index = sprite_index
charleft_sprite = s_empty
is_weapon = false
stack = 20
stack_limit = 100
can_stack = true
i_index = 4 + stack * (i_number - 4) / 20
drop_gui_sound = snd_caltrop_drop
pickup_sound = snd_caltrop_pick
identified = true
ds_map_replace(data, "identified", identified)
is_lock = false
can_equip = false
char_sprite = -4
Material = "metal"
Weight = "Light"
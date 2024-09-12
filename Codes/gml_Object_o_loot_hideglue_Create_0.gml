event_inherited()
inv_object = o_inv_hideglue
number = 0
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

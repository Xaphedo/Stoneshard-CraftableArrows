// Copyright (C)
// See LICENSE file for extended copyright information.
// This file is part of the repository from .

using ModShardLauncher;
using ModShardLauncher.Mods;
using UndertaleModLib;
using UndertaleModLib.Models;
using System.Text.RegularExpressions;

namespace CraftableArrows
{

    public class ScriptSet
    {
        public string Name;
        public string File;
        public EventType Type;
        public uint Subtype;

        public ScriptSet(string myName, string myFile, EventType myType = EventType.Create, uint mySubtype = 0)
        {
            Name = myName;
            File = myFile;
            Type = myType;
            Subtype = mySubtype;
        }
    }
    public class CraftableArrows : Mod
    {
        public override string Author => "Xaphedo";
        public override string Name => "Craftable Arrows";
        public override string Description => "Make sticks into cheap arrows, and glue arrowheads on them to make standard arrows";
        public override string Version => "2-0-0-0";
        public override string TargetVersion => "0.8.2.10";


    private static IEnumerable<string> LogWeaponTextIterator0(IEnumerable<string> input)
    {
        string findtext = " \";;AMMO;AMMO;;;;;AMMO;AMMO;;;;\", \"Leaf-Shaped Arrows;Листовидные стрелы;"; //the string that the iterator is looking for

        string findtextplaceafter = " \";;AMMO;AMMO;;;;;AMMO;AMMO;;;;\",";
        
        string inserttext = "\"Charred-Tip Arrows;Charred-Tip Arrows;Charred-Tip Arrows;Charred-Tip Arrows;Charred-Tip Arrows;Charred-Tip Arrows;Charred-Tip Arrows;Charred-Tip Arrows;Charred-Tip Arrows;Charred-Tip Arrows;Charred-Tip Arrows;Charred-Tip Arrows;Charred-Tip Arrows;\", \"Charred-Tip Bolts;Charred-Tip Bolts;Charred-Tip Bolts;Charred-Tip Bolts;Charred-Tip Bolts;Charred-Tip Bolts;Charred-Tip Bolts;Charred-Tip Bolts;Charred-Tip Bolts;Charred-Tip Bolts;Charred-Tip Bolts;Charred-Tip Bolts;Charred-Tip Bolts;\","; //the string that the iterator will insert
        
        foreach(string item in input)
        {
            if (item.Contains(findtext))
            {
                string newItem = item.Insert(item.IndexOf(findtext) + findtextplaceafter.Length, inserttext); //this adds the new string just after the findtextplaceafter string
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }


    private static IEnumerable<string> LogWeaponTextIterator1(IEnumerable<string> input)
    {
        string findtext = " \";;AMMO;AMMO;;;;;AMMO;AMMO;;;;\", \"Leaf-Shaped Arrows;Обычные наконечники"; //the string that the iterator is looking for

        string findtextplaceafter = " \";;AMMO;AMMO;;;;;AMMO;AMMO;;;;\",";
        
        string inserttext = "\"Charred-Tip Arrows;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;\", \"Charred-Tip Bolts;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;These sticks have been fire-hardened, sharpened to a point, and fletched. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;\", "; //the string that the iterator will insert
        
        foreach(string item in input)
        {
            if (item.Contains(findtext))
            {
                string newItem = item.Insert(item.IndexOf(findtext) + findtextplaceafter.Length, inserttext); //this adds the new string just after the findtextplaceafter string
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }

    private static IEnumerable<string> CarpenterIterator(IEnumerable<string> input)
    {
        string findtext = "ds_list_add(selling_loot_object,"; //the string that the iterator is looking for

        string inserttext = "o_inv_charredtip_arrows, 10, o_inv_charredtip_bolts, 10,"; //the string that the iterator will insert

        //string inserttext = "asset_get_index(\"o_inv_charredtip_arrows\"), 10,"; //the string that the iterator will insert
        
        foreach(string item in input)
        {
            if (item.Contains(findtext))
            {
                string newItem = item.Insert(item.IndexOf(findtext) + findtext.Length, inserttext); //this adds the new string just after the findtext string
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }
/*
    private static IEnumerable<string> TableTextIterator(IEnumerable<string> input)
    {
        string findtext = "\";context_menu_end;context_menu_end;context_menu_end;context_menu_end;context_menu_end;context_menu_end;context_menu_end;context_menu_end;context_menu_end;context_menu_end;context_menu_end;context_menu_end;\""; //the string that the iterator is looking for

        string inserttext = "\"101;Make charred-tip arrows;Make charred-tip arrows;Make charred-tip arrows;Make charred-tip arrows;Make charred-tip arrows;Make charred-tip arrows;Make charred-tip arrows;Make charred-tip arrows;Make charred-tip arrows;Make charred-tip arrows;Make charred-tip arrows;Make charred-tip arrows;\", \"102;Make charred-tip bolts;Make charred-tip bolts;Make charred-tip bolts;Make charred-tip bolts;Make charred-tip bolts;Make charred-tip bolts;Make charred-tip bolts;Make charred-tip bolts;Make charred-tip bolts;Make charred-tip bolts;Make charred-tip bolts;Make charred-tip bolts;\", \"103;You have no bladed weapon and no sticks;You have no bladed weapon and no sticks;You have no bladed weapon and no sticks;You have no bladed weapon and no sticks;You have no bladed weapon and no sticks;You have no bladed weapon and no sticks;You have no bladed weapon and no sticks;You have no bladed weapon and no sticks;You have no bladed weapon and no sticks;You have no bladed weapon and no sticks;You have no bladed weapon and no sticks;You have no bladed weapon and no sticks;\", \"104;You have a bladed weapon but no sticks;You have a bladed weapon but no sticks;You have a bladed weapon but no sticks;You have a bladed weapon but no sticks;You have a bladed weapon but no sticks;You have a bladed weapon but no sticks;You have a bladed weapon but no sticks;You have a bladed weapon but no sticks;You have a bladed weapon but no sticks;You have a bladed weapon but no sticks;You have a bladed weapon but no sticks;You have a bladed weapon but no sticks;\", \"105;You have a stick but no bladed weapon;You have a stick but no bladed weapon;You have a stick but no bladed weapon;You have a stick but no bladed weapon;You have a stick but no bladed weapon;You have a stick but no bladed weapon;You have a stick but no bladed weapon;You have a stick but no bladed weapon;You have a stick but no bladed weapon;You have a stick but no bladed weapon;You have a stick but no bladed weapon;You have a stick but no bladed weapon;\","; //the string that the iterator will insert

        foreach(string item in input)
        {
            if (item.Contains(findtext))
            {
                string newItem = item.Insert(item.IndexOf(findtext), inserttext); //this adds the new string just before the found string. To add it after, simply add ' + findtext.Length' right after 'item.Insert(item.IndexOf(findtext)'
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }
*/
    private static IEnumerable<string> CampfireContextIterator(IEnumerable<string> input)
    {
        string findtext = "\"Cook\", "; //the string that the iterator is looking for

        string inserttext = "\"Make_Charred_Arrows\", \"Make_Charred_Bolts\", "; //the string that the iterator will insert

        foreach(string item in input)
        {
            if (item.Contains(findtext))
            {
                string newItem = item.Insert(item.IndexOf(findtext) + findtext.Length, inserttext); //this adds the new string just after the findtext string
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }
    

    private static IEnumerable<string> TableLogTextIterator(IEnumerable<string> input)
    {
        string findtext = "\"cook;"; //the string that the iterator is looking for

        string inserttext = "\"charredAmmo;~w~$~/~ создает:;~w~$~/~ makes:;~w~$~/~制作：;~w~$~/~ erstellt:;~w~$~/~ crea:;~w~$~/~ crée :;~w~$~/~ crea:;~w~$~/~ cria:;~w~$~/~ tworzy:;~w~$~/~ yaratır:;~w~$~/~ は作ります：;~w~$~/~는 만듭니다 :;\", "; //the string that the iterator will insert

        foreach(string item in input)
        {
            if (item.Contains(findtext))
            {
                string newItem = item.Insert(item.IndexOf(findtext), inserttext); //this adds the new string just before the findtext string
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }


    private static IEnumerable<string> TableConsumablesIterator0(IEnumerable<string> input)
    {
        string findtext = "\"caltrop;Рогульки;"; //the string that the iterator is looking for
        
        string inserttext = "\"arrowheads_leafshaped;Leaf-Shaped Arrowheads;Leaf-Shaped Arrowheads;Leaf-Shaped Arrowheads;Leaf-Shaped Arrowheads;Leaf-Shaped Arrowheads;Leaf-Shaped Arrowheads;Leaf-Shaped Arrowheads;Leaf-Shaped Arrowheads;Leaf-Shaped Arrowheads;Leaf-Shaped Arrowheads;Leaf-Shaped Arrowheads;Leaf-Shaped Arrowheads;//;\", "; //the string that the iterator will insert
        
        foreach(string item in input)
        {
            if (item.Contains(findtext))
            {
                string newItem = item.Insert(item.IndexOf(findtext), inserttext); //this adds the new string just before the findtext string
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }


    private static IEnumerable<string> TableConsumablesIterator1(IEnumerable<string> input)
    {
        string findtext = "\"caltrop;Игнорируют"; //the string that the iterator is looking for
        
        string inserttext = "\"arrowheads_leafshaped;They can be attached to either ~lg~Charred-Tip Arrows~/~ or ~lg~Charred-Tip Bolts~/~ with just a dab of ~y~Hide Glue~/~.;They can be attached to either ~lg~Charred-Tip Arrows~/~ or ~lg~Charred-Tip Bolts~/~ with just a dab of ~y~Hide Glue~/~.;They can be attached to either ~lg~Charred-Tip Arrows~/~ or ~lg~Charred-Tip Bolts~/~ with just a dab of ~y~Hide Glue~/~.;They can be attached to either ~lg~Charred-Tip Arrows~/~ or ~lg~Charred-Tip Bolts~/~ with just a dab of ~y~Hide Glue~/~.;They can be attached to either ~lg~Charred-Tip Arrows~/~ or ~lg~Charred-Tip Bolts~/~ with just a dab of ~y~Hide Glue~/~.;They can be attached to either ~lg~Charred-Tip Arrows~/~ or ~lg~Charred-Tip Bolts~/~ with just a dab of ~y~Hide Glue~/~.;They can be attached to either ~lg~Charred-Tip Arrows~/~ or ~lg~Charred-Tip Bolts~/~ with just a dab of ~y~Hide Glue~/~.;They can be attached to either ~lg~Charred-Tip Arrows~/~ or ~lg~Charred-Tip Bolts~/~ with just a dab of ~y~Hide Glue~/~.;They can be attached to either ~lg~Charred-Tip Arrows~/~ or ~lg~Charred-Tip Bolts~/~ with just a dab of ~y~Hide Glue~/~.;They can be attached to either ~lg~Charred-Tip Arrows~/~ or ~lg~Charred-Tip Bolts~/~ with just a dab of ~y~Hide Glue~/~.;They can be attached to either ~lg~Charred-Tip Arrows~/~ or ~lg~Charred-Tip Bolts~/~ with just a dab of ~y~Hide Glue~/~.;They can be attached to either ~lg~Charred-Tip Arrows~/~ or ~lg~Charred-Tip Bolts~/~ with just a dab of ~y~Hide Glue~/~.;//;\", "; //the string that the iterator will insert
        
        foreach(string item in input)
        {
            if (item.Contains(findtext))
            {
                string newItem = item.Insert(item.IndexOf(findtext), inserttext); //this adds the new string just before the findtext string
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }


    private static IEnumerable<string> TableConsumablesIterator2(IEnumerable<string> input)
    {
        string findtext = "\"caltrop;Широко"; //the string that the iterator is looking for
        
        string inserttext = "\"arrowheads_leafshaped;These common arrowheads are equally suitable for both hunting and warfare. Arrowheads can be found anywhere in Aldor, as they are easy to carry and they hold their value almost as reliably as any currency.;These common arrowheads are equally suitable for both hunting and warfare. Arrowheads can be found anywhere in Aldor, as they are easy to carry and they hold their value almost as reliably as any currency.;These common arrowheads are equally suitable for both hunting and warfare. Arrowheads can be found anywhere in Aldor, as they are easy to carry and they hold their value almost as reliably as any currency.;These common arrowheads are equally suitable for both hunting and warfare. Arrowheads can be found anywhere in Aldor, as they are easy to carry and they hold their value almost as reliably as any currency.;These common arrowheads are equally suitable for both hunting and warfare. Arrowheads can be found anywhere in Aldor, as they are easy to carry and they hold their value almost as reliably as any currency.;These common arrowheads are equally suitable for both hunting and warfare. Arrowheads can be found anywhere in Aldor, as they are easy to carry and they hold their value almost as reliably as any currency.;These common arrowheads are equally suitable for both hunting and warfare. Arrowheads can be found anywhere in Aldor, as they are easy to carry and they hold their value almost as reliably as any currency.;These common arrowheads are equally suitable for both hunting and warfare. Arrowheads can be found anywhere in Aldor, as they are easy to carry and they hold their value almost as reliably as any currency.;These common arrowheads are equally suitable for both hunting and warfare. Arrowheads can be found anywhere in Aldor, as they are easy to carry and they hold their value almost as reliably as any currency.;These common arrowheads are equally suitable for both hunting and warfare. Arrowheads can be found anywhere in Aldor, as they are easy to carry and they hold their value almost as reliably as any currency.;These common arrowheads are equally suitable for both hunting and warfare. Arrowheads can be found anywhere in Aldor, as they are easy to carry and they hold their value almost as reliably as any currency.;These common arrowheads are equally suitable for both hunting and warfare. Arrowheads can be found anywhere in Aldor, as they are easy to carry and they hold their value almost as reliably as any currency.;//;\", "; //the string that the iterator will insert
        
        foreach(string item in input)
        {
            if (item.Contains(findtext))
            {
                string newItem = item.Insert(item.IndexOf(findtext), inserttext); //this adds the new string just before the findtext string
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }


    private static IEnumerable<string> TableConsumableParameters(IEnumerable<string> input)
    {
        string findtext = "\"caltrop;"; //the string that the iterator is looking for
        
        string inserttext = "\"arrowheads_leafshaped;other;;;;metal;Light;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;common;\", "; //the string that the iterator will insert
        
        foreach(string item in input)
        {
            if (item.Contains(findtext))
            {
                string newItem = item.Insert(item.IndexOf(findtext), inserttext); //this adds the new string just before the findtext string
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }



    public static IEnumerable<string> ContextMenuMouse4AssemblyIterator(IEnumerable<string> input)
    {
        bool fill_found = false;
        bool fill_case_found = false;
        bool jmptbl_injected = false;
        string jmp_fill = "";
        bool only_once = false;

        foreach(string item in input)
        {
            yield return item;

            if (!fill_found && item.Contains("Eat"))
            {
                fill_found = true;
            }
            else if (fill_found && !jmptbl_injected && item.Contains("bt"))
            {
                jmptbl_injected = true;
                jmp_fill = new Regex(@"\[\d+\]").Match(item).Value;
            
                yield return @"
dup.v 0
push.s ""Make_Charred_Arrows""
cmp.s.v EQ
bt [1000]

dup.v 0
push.s ""Make_Charred_Bolts""
cmp.s.v EQ
bt [1010]

dup.v 0
push.s ""Arrowheads_Make_Arrows""
cmp.s.v EQ
bt [1020]

dup.v 0
push.s ""Arrowheads_Make_Bolts""
cmp.s.v EQ
bt [1030]
";
            }
            else if (jmp_fill != "" && item.Contains(jmp_fill))
            {
                fill_case_found = true;
            }
            else if (!only_once && fill_case_found && item.Contains("b ["))
            {
                only_once = true;
                string jmp_end = new Regex(@"\[\d+\]").Match(item).Value;
                yield return @$":[1000]
push.v self.interact_id
pushi.e -9
pushenv [1006]

:[1001]
push.v self.in_grid
push.v self.id
call.i gml_Script_scr_can_interract_posgrid(argc=2)
conv.v.b
bf [1003]

:[1002]
pushi.e 2
conv.i.v
pushi.e 1
conv.i.v
pushi.e o_inv_charredtip_arrows
conv.i.v
call.i gml_Script_scr_makeCharredAmmo(argc=3)
popz.v
b [1006]

:[1003]
pushi.e 2
conv.i.v
pushi.e 1
conv.i.v
pushi.e o_inv_charredtip_arrows
conv.i.v
push.i gml_Script_scr_makeCharredAmmo
conv.i.v
call.i @@NewGMLArray@@(argc=4)
pop.v.v self.interract_event
push.v self.in_grid
conv.v.b
not.b
bf [1005]

:[1004]
call.i gml_Script_scr_delay_move(argc=0)
popz.v
b [1006]

:[1005]
call.i gml_Script_scr_delay_move_grid(argc=0)
popz.v

:[1006]
popenv [1001]
b {jmp_end}

:[1010]
push.v self.interact_id
pushi.e -9
pushenv [1016]

:[1011]
push.v self.in_grid
push.v self.id
call.i gml_Script_scr_can_interract_posgrid(argc=2)
conv.v.b
bf [1013]

:[1012]
pushi.e 2
conv.i.v
pushi.e 1
conv.i.v
pushi.e o_inv_charredtip_bolts
conv.i.v
call.i gml_Script_scr_makeCharredAmmo(argc=3)
popz.v
b [1016]

:[1013]
pushi.e 2
conv.i.v
pushi.e 1
conv.i.v
pushi.e o_inv_charredtip_bolts
conv.i.v
push.i gml_Script_scr_makeCharredAmmo
conv.i.v
call.i @@NewGMLArray@@(argc=4)
pop.v.v self.interract_event
push.v self.in_grid
conv.v.b
not.b
bf [1015]

:[1014]
call.i gml_Script_scr_delay_move(argc=0)
popz.v
b [1016]

:[1015]
call.i gml_Script_scr_delay_move_grid(argc=0)
popz.v

:[1016]
popenv [1011]
b {jmp_end}


:[1020]
push.v self.interact_id
pushi.e -9
pushenv [1022]

:[1021]
pushi.e o_inv_charredtip_arrows
conv.i.v
call.i gml_Script_scr_glueArrowheads(argc=1)
popz.v

:[1022]
popenv [1021]
b {jmp_end}


:[1030]
push.v self.interact_id
pushi.e -9
pushenv [1032]

:[1031]
pushi.e o_inv_charredtip_bolts
conv.i.v
call.i gml_Script_scr_glueArrowheads(argc=1)
popz.v

:[1032]
popenv [1031]
b {jmp_end}
";
            }
        }
        
    }
    public static IEnumerable<string> CreateContextMenuAssemblyIterator(IEnumerable<string> input)
    {
        bool fill_found = false;
        bool fill_case_found = false;
        bool jmptbl_injected = false;
        string jmp_fill = "";
        bool only_once = false;

        foreach(string item in input)
        {
            yield return item;

            if (!fill_found && item.Contains("Eat"))
            {
                fill_found = true;
            }
            else if (fill_found && !jmptbl_injected && item.Contains("bt"))
            {
                jmptbl_injected = true;
                jmp_fill = new Regex(@"\[\d+\]").Match(item).Value;
            
                yield return @"
dup.v 0
push.s ""Make_Charred_Arrows""
cmp.s.v EQ
bt [2000]

dup.v 0
push.s ""Make_Charred_Bolts""
cmp.s.v EQ
bt [2200]

dup.v 0
push.s ""Arrowheads_Make_Arrows""
cmp.s.v EQ
bt [2400]

dup.v 0
push.s ""Arrowheads_Make_Bolts""
cmp.s.v EQ
bt [2600]
";
            }
            else if (jmp_fill != "" && item.Contains(jmp_fill))
            {
                fill_case_found = true;
            }
            else if (!only_once && fill_case_found && item.Contains("b ["))
            {
                only_once = true;
                string jmp_end = new Regex(@"\[\d+\]").Match(item).Value;
                yield return @$":[2000]
pushglb.v global.context_menu_makeCharredTipArrowsID
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
push.s ""Make_Charred_Arrows""
conv.s.v
push.v self.context_name
call.i ds_list_add(argc=3)
popz.v
call.i gml_Script_scr_check_sticks_for_charred_ammo(argc=0)
conv.v.b
not.b
bf [2002]

:[2001]
call.i gml_Script_scr_check_weapon_for_charred_ammo(argc=0)
conv.v.b
not.b
b [2003]

:[2002]
push.e 0

:[2003]
bf [2005]

:[2004]
pushglb.v global.context_menu_noBladeNoSticksID
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
pushi.e 0
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v
b [2018]

:[2005]
call.i gml_Script_scr_check_sticks_for_charred_ammo(argc=0)
conv.v.b
not.b
bf [2007]

:[2006]
call.i gml_Script_scr_check_weapon_for_charred_ammo(argc=0)
conv.v.b
b [2008]

:[2007]
push.e 0

:[2008]
bf [2010]

:[2009]
pushglb.v global.context_menu_yesBladeNoSticksID
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
pushi.e 0
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v
b [2018]

:[2010]
call.i gml_Script_scr_check_sticks_for_charred_ammo(argc=0)
conv.v.b
bf [2012]

:[2011]
call.i gml_Script_scr_check_weapon_for_charred_ammo(argc=0)
conv.v.b
not.b
b [2013]

:[2012]
push.e 0

:[2013]
bf [2015]

:[2014]
pushglb.v global.context_menu_noBladeYesSticksID
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
pushi.e 0
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v
b [2018]

:[2015]
push.v other.is_fire
conv.v.b
bf [2017]

:[2016]
pushi.e 0
conv.i.v
pushi.e 1
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v
b [2018]

:[2017]
pushi.e 74
conv.i.v
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
pushi.e 0
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v

:[2018]
b {jmp_end}

:[2200]
pushglb.v global.context_menu_makeCharredTipBoltsID
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
push.s ""Make_Charred_Bolts""
conv.s.v
push.v self.context_name
call.i ds_list_add(argc=3)
popz.v
call.i gml_Script_scr_check_sticks_for_charred_ammo(argc=0)
conv.v.b
not.b
bf [2202]

:[2201]
call.i gml_Script_scr_check_weapon_for_charred_ammo(argc=0)
conv.v.b
not.b
b [2203]

:[2202]
push.e 0

:[2203]
bf [2205]

:[2204]
pushglb.v global.context_menu_noBladeNoSticksID
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
pushi.e 0
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v
b [2218]

:[2205]
call.i gml_Script_scr_check_sticks_for_charred_ammo(argc=0)
conv.v.b
not.b
bf [2207]

:[2206]
call.i gml_Script_scr_check_weapon_for_charred_ammo(argc=0)
conv.v.b
b [2208]

:[2207]
push.e 0

:[2208]
bf [2210]

:[2209]
pushglb.v global.context_menu_yesBladeNoSticksID
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
pushi.e 0
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v
b [2218]

:[2210]
call.i gml_Script_scr_check_sticks_for_charred_ammo(argc=0)
conv.v.b
bf [2212]

:[2211]
call.i gml_Script_scr_check_weapon_for_charred_ammo(argc=0)
conv.v.b
not.b
b [2213]

:[2212]
push.e 0

:[2213]
bf [2215]

:[2214]
pushglb.v global.context_menu_noBladeYesSticksID
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
pushi.e 0
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v
b [2218]

:[2215]
push.v other.is_fire
conv.v.b
bf [2217]

:[2216]
pushi.e 0
conv.i.v
pushi.e 1
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v
b [2218]

:[2217]
pushi.e 74
conv.i.v
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
pushi.e 0
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v

:[2218]
b {jmp_end}

:[2400]
pushglb.v global.context_menu_arrowheadsMakeArrowsID
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
push.s ""Arrowheads_Make_Arrows""
conv.s.v
push.v self.context_name
call.i ds_list_add(argc=3)
popz.v
call.i gml_Script_scr_check_chartiparrows_for_arrowheads(argc=0)
conv.v.b
not.b
bf [2402]

:[2401]
call.i gml_Script_scr_check_hideglue_for_arrowheads(argc=0)
conv.v.b
not.b
b [2403]

:[2402]
push.e 0

:[2403]
bf [2405]

:[2404]
pushglb.v global.context_menu_noGlueNoCharredtipArrowsID
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
pushi.e 0
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v
b [2416]

:[2405]
call.i gml_Script_scr_check_chartiparrows_for_arrowheads(argc=0)
conv.v.b
not.b
bf [2407]

:[2406]
call.i gml_Script_scr_check_hideglue_for_arrowheads(argc=0)
conv.v.b
b [2408]

:[2407]
push.e 0

:[2408]
bf [2410]

:[2409]
pushglb.v global.context_menu_yesGlueNoCharredtipArrowsID
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
pushi.e 0
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v
b [2416]

:[2410]
call.i gml_Script_scr_check_chartiparrows_for_arrowheads(argc=0)
conv.v.b
bf [2412]

:[2411]
call.i gml_Script_scr_check_hideglue_for_arrowheads(argc=0)
conv.v.b
not.b
b [2413]

:[2412]
push.e 0

:[2413]
bf [2415]

:[2414]
pushglb.v global.context_menu_noGlueYesCharredtipArrowsID
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
pushi.e 0
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v
b [2416]

:[2415]
pushi.e 0
conv.i.v
pushi.e 1
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v

:[2416]
b {jmp_end}

:[2600]
pushglb.v global.context_menu_arrowheadsMakeBoltsID
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
push.s ""Arrowheads_Make_Bolts""
conv.s.v
push.v self.context_name
call.i ds_list_add(argc=3)
popz.v
call.i gml_Script_scr_check_chartipbolts_for_arrowheads(argc=0)
conv.v.b
not.b
bf [2602]

:[2601]
call.i gml_Script_scr_check_hideglue_for_arrowheads(argc=0)
conv.v.b
not.b
b [2603]

:[2602]
push.e 0

:[2603]
bf [2605]

:[2604]
pushglb.v global.context_menu_noGlueNoCharredtipBoltsID
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
pushi.e 0
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v
b [2616]

:[2605]
call.i gml_Script_scr_check_chartipbolts_for_arrowheads(argc=0)
conv.v.b
not.b
bf [2607]

:[2606]
call.i gml_Script_scr_check_hideglue_for_arrowheads(argc=0)
conv.v.b
b [2608]

:[2607]
push.e 0

:[2608]
bf [2610]

:[2609]
pushglb.v global.context_menu_yesGlueNoCharredtipBoltsID
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
pushi.e 0
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v
b [2616]

:[2610]
call.i gml_Script_scr_check_chartipbolts_for_arrowheads(argc=0)
conv.v.b
bf [2612]

:[2611]
call.i gml_Script_scr_check_hideglue_for_arrowheads(argc=0)
conv.v.b
not.b
b [2613]

:[2612]
push.e 0

:[2613]
bf [2615]

:[2614]
pushglb.v global.context_menu_noGlueYesCharredtipBoltsID
pushglb.v global.context_menu
call.i ds_list_find_value(argc=2)
pushi.e 0
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v
b [2616]

:[2615]
pushi.e 0
conv.i.v
pushi.e 1
conv.i.v
push.v self.context_desc
call.i ds_list_add(argc=3)
popz.v

:[2616]
b {jmp_end}
";
            }
        }
    }

        public override void PatchMod()
        {

            Msl.AddMenu("Arrowheads",
                 new UIComponent(name:"Harder to sell", associatedGlobal:"arrowheadsHarderTrading", UIComponentType.CheckBox, 0, true)
            );

            Msl.AddMenu("Charred-Tip Arrows",
                new UIComponent(name:"Min from 1 stick", associatedGlobal:"makeCharredAmmoArrowsMin", UIComponentType.Slider, (0, 20), 1, true),
                new UIComponent(name:"Max from 1 stick", associatedGlobal:"makeCharredAmmoArrowsMax", UIComponentType.Slider, (0, 20), 2, true),
                new UIComponent(name:"Damage % modifier", associatedGlobal:"charredAmmoArrowsDamage", UIComponentType.Slider, (-100, 100), -50, true),
                new UIComponent(name:"Armor Penetr. % mod.", associatedGlobal:"charredAmmoArrowsArmorP", UIComponentType.Slider, (-100, 100), -50, true)
            ); 

            Msl.AddMenu("Charred-Tip Bolts",
                new UIComponent(name:"Min from 1 stick", associatedGlobal:"makeCharredAmmoBoltsMin", UIComponentType.Slider, (0, 20), 1, true),
                new UIComponent(name:"Max from 1 stick", associatedGlobal:"makeCharredAmmoBoltsMax", UIComponentType.Slider, (0, 20), 2, true),
                new UIComponent(name:"Damage % modifier", associatedGlobal:"charredAmmoBoltsDamage", UIComponentType.Slider, (-100, 100), -50, true),
                new UIComponent(name:"Armor Penetr. % mod.", associatedGlobal:"charredAmmoBoltsArmorP", UIComponentType.Slider, (-100, 100), -50, true)
            );     
            
            UndertaleGameObject invCharredTipArrows = Msl.AddObject(
                name:"o_inv_charredtip_arrows",
                spriteName:"s_inv_charredtiparrows",
                parentName:"o_inv_arrows_parent",
                isVisible:true,
                isAwake:true,
                isPersistent: true, 
                collisionShapeFlags:CollisionShapeFlags.Circle
            );

            UndertaleGameObject lootCharredTipArrows = Msl.AddObject(
                name:"o_loot_charredtip_arrows",
                spriteName:"s_loot_charredtiparrows",
                parentName:"o_loot_arrows_parent",
                isVisible:true,
                isAwake:true,
                collisionShapeFlags:CollisionShapeFlags.Circle
            );

            UndertaleGameObject usedCharredTipArrows = Msl.AddObject(
                name:"o_charredtip_arrow_used",
                spriteName:"s_charredtiparrow_used",
                parentName:"o_loot_charredtip_arrows",
                isVisible:true,
                isAwake:true,
                collisionShapeFlags:CollisionShapeFlags.Box
            );


            UndertaleGameObject invCharredTipBolts = Msl.AddObject(
                name:"o_inv_charredtip_bolts",
                spriteName:"s_inv_charredtipbolts",
                parentName:"o_inv_bolts_parent",
                isVisible:true,
                isAwake:true,
                isPersistent: true, 
                collisionShapeFlags:CollisionShapeFlags.Circle
            );

            UndertaleGameObject lootCharredTipBolts = Msl.AddObject(
                name:"o_loot_charredtip_bolts",
                spriteName:"s_loot_charredtipbolts",
                parentName:"o_loot_arrows_parent",
                isVisible:true,
                isAwake:true,
                collisionShapeFlags:CollisionShapeFlags.Circle
            );

            UndertaleGameObject usedCharredTipBolts = Msl.AddObject(
                name:"o_charredtip_bolt_used",
                spriteName:"s_charredtipbolt_used",
                parentName:"o_loot_charredtip_bolts",
                isVisible:true,
                isAwake:true,
                collisionShapeFlags:CollisionShapeFlags.Box
            );

            UndertaleGameObject invHideGlue = Msl.AddObject(
                name:"o_inv_hideglue",
                spriteName:"s_inv_hideglue",
                parentName:"o_inv_consum_passive",
                isVisible:true,
                isAwake:true,
                isPersistent: true, 
                collisionShapeFlags:CollisionShapeFlags.Circle
            );

            UndertaleGameObject lootHideGlue = Msl.AddObject(
                name:"o_loot_hideglue",
                spriteName:"s_loot_hideglue",
                parentName:"o_consument_loot",
                isVisible:true,
                isAwake:true,
                collisionShapeFlags:CollisionShapeFlags.Circle
            );
            
            UndertaleGameObject invArrowheadsParent = Msl.AddObject(
                name:"o_inv_arrowheads_parent", //based on o_inv_ammunition_parent
                parentName:"o_inv_consum_passive",
                isVisible:true,
                isAwake:true,
                isPersistent: true, 
                collisionShapeFlags:CollisionShapeFlags.Circle
            );

            UndertaleGameObject invArrowheadsLeafshaped = Msl.AddObject(
                name:"o_inv_arrowheads_leafshaped",
                spriteName:"s_inv_arrowheads_leafshaped",
                parentName:"o_inv_arrowheads_parent",
                isVisible:true,
                isAwake:true,
                isPersistent: true, 
                collisionShapeFlags:CollisionShapeFlags.Circle
            );

            UndertaleGameObject lootArrowheadsLeafshaped = Msl.AddObject(
                name:"o_loot_arrowheads_leafshaped",
                spriteName:"s_loot_arrowheads_generic",
                parentName:"o_consument_loot",
                isVisible:true,
                isAwake:true,
                collisionShapeFlags:CollisionShapeFlags.Circle
            );

            UndertaleGameObject invArrowheadsBroadhead = Msl.AddObject(
                name:"o_inv_arrowheads_broadhead",
                spriteName:"s_inv_arrowheads_broadhead",
                parentName:"o_inv_arrowheads_parent",
                isVisible:true,
                isAwake:true,
                isPersistent: true, 
                collisionShapeFlags:CollisionShapeFlags.Circle
            );

            UndertaleGameObject lootArrowheadsBroadhead = Msl.AddObject(
                name:"o_loot_arrowheads_broadhead",
                spriteName:"s_loot_arrowheads_generic",
                parentName:"o_consument_loot",
                isVisible:true,
                isAwake:true,
                collisionShapeFlags:CollisionShapeFlags.Circle
            );

            UndertaleGameObject invArrowheadsBodkin = Msl.AddObject(
                name:"o_inv_arrowheads_bodkin",
                spriteName:"s_inv_arrowheads_bodkin",
                parentName:"o_inv_arrowheads_parent",
                isVisible:true,
                isAwake:true,
                isPersistent: true, 
                collisionShapeFlags:CollisionShapeFlags.Circle
            );

            UndertaleGameObject lootArrowheadsBodkin = Msl.AddObject(
                name:"o_loot_arrowheads_bodkin",
                spriteName:"s_loot_arrowheads_generic",
                parentName:"o_consument_loot",
                isVisible:true,
                isAwake:true,
                collisionShapeFlags:CollisionShapeFlags.Circle
            );





            //listing all the scripts to create.
            ScriptSet[] scriptsToAdd = new ScriptSet[]
            {
                new ScriptSet("o_inv_charredtip_arrows", "gml_Object_o_inv_charredtip_arrows_Create_0.gml"),

                new ScriptSet("o_loot_charredtip_arrows", "gml_Object_o_loot_charredtip_arrows_Create_0.gml"),
                
                new ScriptSet("o_charredtip_arrow_used", "gml_Object_o_charredtip_arrow_used_Create_0.gml"),
                new ScriptSet("o_charredtip_arrow_used", "gml_Object_o_charredtip_arrow_used_Draw_0.gml", EventType.Draw),
                
                new ScriptSet("o_inv_charredtip_bolts", "gml_Object_o_inv_charredtip_bolts_Create_0.gml"),

                new ScriptSet("o_loot_charredtip_bolts", "gml_Object_o_loot_charredtip_bolts_Create_0.gml"),
                
                new ScriptSet("o_charredtip_bolt_used", "gml_Object_o_charredtip_bolt_used_Create_0.gml"),
                new ScriptSet("o_charredtip_bolt_used", "gml_Object_o_charredtip_bolt_used_Draw_0.gml", EventType.Draw),

                new ScriptSet("o_inv_hideglue", "gml_Object_o_inv_hideglue_Create_0.gml"),
                new ScriptSet("o_inv_hideglue", "gml_Object_o_inv_hideglue_Step_0.gml", EventType.Step),

                new ScriptSet("o_loot_hideglue", "gml_Object_o_loot_hideglue_Create_0.gml"),

                new ScriptSet("o_inv_arrowheads_parent", "gml_Object_o_inv_arrowheads_parent_Create_0.gml"),
                new ScriptSet("o_inv_arrowheads_parent", "gml_Object_o_inv_arrowheads_parent_Step_0.gml", EventType.Step),
                new ScriptSet("o_inv_arrowheads_parent", "gml_Object_o_inv_arrowheads_parent_Other_10.gml", EventType.Other, 10),

                new ScriptSet("o_inv_arrowheads_leafshaped", "gml_Object_o_inv_arrowheads_leafshaped_Create_0.gml"),

                new ScriptSet("o_loot_arrowheads_leafshaped", "gml_Object_o_loot_arrowheads_leafshaped_Create_0.gml"),

                new ScriptSet("o_inv_arrowheads_broadhead", "gml_Object_o_inv_arrowheads_broadhead_Create_0.gml"),

                new ScriptSet("o_loot_arrowheads_broadhead", "gml_Object_o_loot_arrowheads_broadhead_Create_0.gml"),

                new ScriptSet("o_inv_arrowheads_bodkin", "gml_Object_o_inv_arrowheads_bodkin_Create_0.gml"),

                new ScriptSet("o_loot_arrowheads_bodkin", "gml_Object_o_loot_arrowheads_bodkin_Create_0.gml")

            };

            //creating all the listed scripts.
            foreach (var newScript in scriptsToAdd)
            {
                Msl.AddNewEvent(
                    newScript.Name,
                    ModFiles.GetCode(newScript.File),
                    newScript.Type,
                    newScript.Subtype
                );
            }

            Msl.AddFunction(ModFiles.GetCode("gml_GlobalScript_scr_check_sticks_for_charred_ammo.gml"), "scr_check_sticks_for_charred_ammo");

            Msl.AddFunction(ModFiles.GetCode("gml_GlobalScript_scr_check_weapon_for_charred_ammo.gml"), "scr_check_weapon_for_charred_ammo");

            Msl.AddFunction(ModFiles.GetCode("gml_GlobalScript_scr_makeCharredAmmo.gml"), "scr_makeCharredAmmo");

            Msl.AddFunction(ModFiles.GetCode("gml_GlobalScript_scr_glueArrowheads.gml"), "scr_glueArrowheads");

            Msl.AddFunction(ModFiles.GetCode("gml_GlobalScript_scr_check_hideglue_for_arrowheads.gml"), "scr_check_hideglue_for_arrowheads");

            Msl.AddFunction(ModFiles.GetCode("gml_GlobalScript_scr_check_chartiparrows_for_arrowheads.gml"), "scr_check_chartiparrows_for_arrowheads");

            Msl.AddFunction(ModFiles.GetCode("gml_GlobalScript_scr_check_chartipbolts_for_arrowheads.gml"), "scr_check_chartipbolts_for_arrowheads");

            /*
            Msl.LoadGML("gml_Object_o_npc_carpenter_Create_0")
                .Apply(CarpenterIterator)
                //.Peek()
                .Save();
            */


            Msl.LoadGML("gml_GlobalScript_table_weapons_text")
                .Apply(LogWeaponTextIterator0)
                //.Peek()
                .Save();

            Msl.LoadGML("gml_GlobalScript_table_weapons_text")
                .Apply(LogWeaponTextIterator1)
                //.Peek()
                .Save();

/*
            Msl.LoadGML("gml_GlobalScript_table_consumables")
                .Apply(TableConsumablesIterator0)
                //.Peek()
                .Save();

            Msl.LoadGML("gml_GlobalScript_table_consumables")
                .Apply(TableConsumablesIterator1)
                //.Peek()
                .Save();

            Msl.LoadGML("gml_GlobalScript_table_consumables")
                .Apply(TableConsumablesIterator2)
                .Peek()
                .Save();

            Msl.LoadGML("gml_GlobalScript_table_Consumable_Parameters")
                .Apply(TableConsumableParameters)
                .Peek()
                .Save();

*/


        LocalizationItem localizationTable = new(
            "hideglue",
            "Hide Glue",
            "A small dab of it can be used to attach ~gr~Arrowheads~/~ to either ~sy~Charred-Tip Arrows~/~ or ~sy~Charred-Tip Bolts~/~.",
            "Worked hides that have been dried, diced, and boiled several times over. It smells much better than it tastes."
        );
        localizationTable.InjectTable();
        
        localizationTable = new(
            "arrowheads_leafshaped",
            "Leaf-Shaped Arrowheads",
            "They can be attached to either ~sy~Charred-Tip Arrows~/~ or ~sy~Charred-Tip Bolts~/~ with just a dab of ~o~Hide Glue~/~.",
            "These common arrowheads are equally suitable for both hunting and warfare. Arrowheads can be found anywhere in Aldor, as they are easy to carry and they hold their value almost as reliably as any currency."
        );
        localizationTable.InjectTable();
        
        localizationTable = new(
            "arrowheads_broadhead",
            "Broadhead Arrowheads",
            "They can be attached to either ~sy~Charred-Tip Arrows~/~ or ~sy~Charred-Tip Bolts~/~ with just a dab of ~o~Hide Glue~/~.",
            "Arrowheads like these often get stuck deep in the flesh, causing massive bleeding. However, they are rather heavy, cumbersome, and have limited uses against armor. Arrowheads can be found anywhere in Aldor, as they are easy to carry and they hold their value almost as reliably as any currency."
        );
        localizationTable.InjectTable();
        
        localizationTable = new(
            "arrowheads_bodkin",
            "Bodkin Arrowheads",
            "They can be attached to either ~sy~Charred-Tip Arrows~/~ or ~sy~Charred-Tip Bolts~/~ with just a dab of ~o~Hide Glue~/~.",
            "Bodkin arrowheads are designed to penetrate light armor, but they lack sheer stopping power. Arrowheads can be found anywhere in Aldor, as they are easy to carry and they hold their value almost as reliably as any currency."
        );
        localizationTable.InjectTable();

        
        Msl.InjectTableConsumableParameters(Msl.ConsumParamMetaGroup.JUNKMATERIALS, "hideglue", Msl.ConsumParamCategory.ingredient, Msl.ConsumParamMaterial.organic, Msl.ConsumParamWeight.Light, Msl.ConsumParamSubCategory.none, Msl.ConsumParamTags.common, 0);
        Msl.InjectTableConsumableParameters(Msl.ConsumParamMetaGroup.JUNKMATERIALS, "arrowheads_leafshaped", Msl.ConsumParamCategory.ingredient, Msl.ConsumParamMaterial.metal, Msl.ConsumParamWeight.Light, Msl.ConsumParamSubCategory.none, Msl.ConsumParamTags.common, 0);
        Msl.InjectTableConsumableParameters(Msl.ConsumParamMetaGroup.JUNKMATERIALS, "arrowheads_broadhead", Msl.ConsumParamCategory.ingredient, Msl.ConsumParamMaterial.metal, Msl.ConsumParamWeight.Light, Msl.ConsumParamSubCategory.none, Msl.ConsumParamTags.common, 0);
        Msl.InjectTableConsumableParameters(Msl.ConsumParamMetaGroup.JUNKMATERIALS, "arrowheads_bodkin", Msl.ConsumParamCategory.ingredient, Msl.ConsumParamMaterial.metal, Msl.ConsumParamWeight.Light, Msl.ConsumParamSubCategory.none, Msl.ConsumParamTags.common, 0);

            Msl.LoadGML("gml_Object_o_campfire01_Mouse_5")
                .Apply(CampfireContextIterator)
                //.Peek()
                .Save();

            Msl.LoadGML("gml_Object_o_campfire_crafted_Mouse_5")
                .Apply(CampfireContextIterator)
                //.Peek()
                .Save();


            Msl.LoadGML("gml_GlobalScript_scr_ds_init")
                .MatchFrom("global.missleData = __dsDebuggerMapCreate()") // Finding the line
                .InsertBelow("ds_map_add(global.missleData, \"o_inv_charredtip_arrows\", [s_charredtiparrow_shoot, o_charredtip_arrow_used, -4, -4, o_loot_charredtip_arrows])")// Inserting the snippet below
                //.InsertBelow("ds_map_add(global.missleData, \"o_inv_charredtip_arrows\", [asset_get_index(s_charredtiparrow_shoot), asset_get_index(o_charredtip_arrow_used), -4, -4, asset_get_index(o_loot_charredtip_arrows)])")// Inserting the snippet below
                .Save(); 
                
            Msl.LoadGML("gml_Object_o_player_Other_17")
                .MatchFrom("event_user(interract_event)") // Finding the line
                .ReplaceBy(ModFiles, "gml_Object_o_player_Other_17_add.gml") // Inserting the snippet above
                .Save();

/*
            Msl.LoadGML("gml_GlobalScript_table_text")
                .Apply(TableTextIterator)
                //.Peek()
                .Save();
*/
            Msl.LoadGML("gml_GlobalScript_table_log_text")
                .Apply(TableLogTextIterator)
                //.Peek()
                .Save();

            Msl.LoadGML("gml_Object_o_inv_quiver_parent_Create_0")
                .MatchFrom("ds_map_add(slot_data, \"o_inv_arrows\",") // Finding the line
                .InsertAbove("ds_map_add(slot_data, \"o_inv_charredtip_arrows\", [\"s_inv_lsa_\", s_lsarrows_marker])") // Inserting the snippet above
                .Save();

            Msl.LoadGML("gml_Object_o_inv_decorated_quiver_Create_0")
                .MatchFrom("ds_map_add(slot_data, \"o_inv_arrows\",") // Finding the line
                .InsertAbove("ds_map_add(slot_data, \"o_inv_charredtip_arrows\", [\"s_inv_lsa_\", s_lsarrows_marker])") // Inserting the snippet above
                .Save();

            Msl.LoadGML("gml_Object_o_inv_bolt_quiver_parent_Create_0")
                .MatchFrom("ds_map_add(slot_data, \"o_inv_leafshaped_bolts\",") // Finding the line
                .InsertAbove("ds_map_add(slot_data, \"o_inv_charredtip_bolts\", [\"s_inv_lsb_\", s_lsbolts_marker])") // Inserting the snippet above
                .Save();

            Msl.LoadGML("gml_Object_o_textLoader_Other_25")
                .MatchFrom("scr_tableWriteList(global.context_menu, _array, \"context_menu\")") // Finding the line
                .InsertBelow(ModFiles, "gml_Object_o_textLoader_Other_25_add.gml") // Inserting the snippet above
                .Save();

            /*Msl.LoadGML("gml_Object_o_knight_maiden_Create_0")
                .MatchFrom("scr_inventory_add_item(o_inv_map_osbrook)") // Finding the line
                .InsertBelow("scr_inventory_add_item(o_inv_arrowheads_leafshaped)") // Inserting the snippet below
                .Save();*/

            Msl.LoadGML("gml_Object_o_inv_slot_Mouse_5")
                .MatchFrom("else if object_is_ancestor(object_index, o_inv_ammunition_parent)")
                .InsertAbove(ModFiles, "gml_Object_o_inv_slot_Mouse_5_add1.gml")
                .Save();


            UndertaleSprite 
            tempSprite = Msl.GetSprite("s_inv_charredtiparrows");
            tempSprite.OriginX = 0; //13;
            tempSprite.OriginY = 0; //40;
            tempSprite.IsSpecialType = true;
            tempSprite.SVersion = 3;
            tempSprite.GMS2PlaybackSpeed = 15;
            tempSprite.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerSecond;
            tempSprite = Msl.GetSprite("s_loot_charredtiparrows");
            tempSprite.OriginX = 0; //11;
            tempSprite.OriginY = 0; //9;
            tempSprite = Msl.GetSprite("s_charredtiparrow_shoot");
            tempSprite.OriginX = 20; //10;
            tempSprite.OriginY = 9; //2;
            tempSprite.IsSpecialType = true;
            tempSprite.SVersion = 3;
            tempSprite.GMS2PlaybackSpeed = 1;
            tempSprite.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerSecond;
            tempSprite = Msl.GetSprite("s_charredtiparrow_used");
            tempSprite.OriginX = 15; //10;
            tempSprite.OriginY = 9; //10;
            tempSprite.IsSpecialType = true;
            tempSprite.SVersion = 3;
            tempSprite.GMS2PlaybackSpeed = 1;
            tempSprite.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerSecond;
            
            tempSprite = Msl.GetSprite("s_inv_charredtipbolts");
            tempSprite.OriginX = 0;
            tempSprite.OriginY = 0;
            tempSprite.IsSpecialType = true;
            tempSprite.SVersion = 3;
            tempSprite.GMS2PlaybackSpeed = 15;
            tempSprite.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerSecond;
            tempSprite = Msl.GetSprite("s_loot_charredtipbolts");
            tempSprite.OriginX = 0;
            tempSprite.OriginY = 0;
            tempSprite = Msl.GetSprite("s_charredtipbolt_shoot");
            tempSprite.OriginX = 20;
            tempSprite.OriginY = 9;
            tempSprite.IsSpecialType = true;
            tempSprite.SVersion = 3;
            tempSprite.GMS2PlaybackSpeed = 1;
            tempSprite.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerSecond;
            tempSprite = Msl.GetSprite("s_charredtipbolt_used");
            tempSprite.OriginX = 13;
            tempSprite.OriginY = 9;
            tempSprite.IsSpecialType = true;
            tempSprite.SVersion = 3;
            tempSprite.GMS2PlaybackSpeed = 1;
            tempSprite.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerSecond;

            tempSprite = Msl.GetSprite("s_inv_hideglue");
            tempSprite.OriginX = 0;
            tempSprite.OriginY = 0;
            tempSprite.IsSpecialType = true;
            tempSprite.SVersion = 3;
            tempSprite.GMS2PlaybackSpeed = 15;
            tempSprite.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerSecond;

            tempSprite = Msl.GetSprite("s_inv_arrowheads_leafshaped");
            tempSprite.OriginX = 0;
            tempSprite.OriginY = 0;
            tempSprite.IsSpecialType = true;
            tempSprite.SVersion = 3;
            tempSprite.GMS2PlaybackSpeed = 15;
            tempSprite.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerSecond;
            tempSprite = Msl.GetSprite("s_inv_arrowheads_broadhead");
            tempSprite.OriginX = 0;
            tempSprite.OriginY = 0;
            tempSprite.IsSpecialType = true;
            tempSprite.SVersion = 3;
            tempSprite.GMS2PlaybackSpeed = 15;
            tempSprite.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerSecond;
            tempSprite = Msl.GetSprite("s_inv_arrowheads_bodkin");
            tempSprite.OriginX = 0;
            tempSprite.OriginY = 0;
            tempSprite.IsSpecialType = true;
            tempSprite.SVersion = 3;
            tempSprite.GMS2PlaybackSpeed = 15;
            tempSprite.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerSecond;

            tempSprite = Msl.GetSprite("s_loot_arrowheads_generic");
            tempSprite.OriginX = 0;
            tempSprite.OriginY = 0;
            tempSprite = Msl.GetSprite("s_loot_hideglue");
            tempSprite.OriginX = 0;
            tempSprite.OriginY = 0;


            // IMPORTANT : this is temporary and for testing purposes. The items will be distributed among more appropriate traders
            /*
            Msl.LoadGML("gml_Object_o_npc_Innkeeper_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet above
                .Save();
            Msl.LoadGML("gml_Object_o_npc_Innkeeper_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_Object_o_npc_Innkeeper_Create_0_add.gml") // Inserting the snippet above
                .Save();
            */

            // This part adds the capability of adding a variable amount of stackable items to a trader's inventory
            Msl.LoadGML("gml_Object_o_NPC_Other_24")
                .MatchFrom("with (scr_guiCreateContainer(global.guiBaseContainerSideLeft, o_trade_inventory))") // Finding the line
                .InsertAbove(ModFiles, "gml_Object_o_NPC_Other_24_add0.gml") // Inserting the snippet above
                .Save();
            Msl.LoadGML("gml_Object_o_NPC_Other_24")
                .MatchFrom("var g = math_round(owner.gold_k)") // Finding the line
                .InsertAbove(ModFiles, "gml_Object_o_NPC_Other_24_add1.gml") // Inserting the snippet above
                .Save();

            //This part adds the functionality of splitting stacks within a trader's inventory
            Msl.LoadGML("gml_Object_o_inv_slot_Mouse_5")
                .MatchFrom(ModFiles, "gml_Object_o_inv_slot_Mouse_5_match.gml")
                .ReplaceBy(ModFiles, "gml_Object_o_inv_slot_Mouse_5_add0.gml")
                .Save();
            Msl.LoadGML("gml_Object_o_split_stack_slider_Other_10")
                .MatchFrom(ModFiles, "gml_Object_o_split_stack_slider_Other_10_match.gml")
                .ReplaceBy(ModFiles, "gml_Object_o_split_stack_slider_Other_10_add.gml")
                .Save();

                
            //Msl.LoadGML("gml_Object_o_context_button_Mouse_4")
            //    .MatchFrom("case \"Cook\"") // Finding the line
            //    .InsertAbove(ModFiles, "gml_Object_o_context_button_Mouse_4_add.gml") // Inserting the snippet above
            //    .Save();
            Msl.LoadAssemblyAsString("gml_Object_o_context_button_Mouse_4")
                .Apply(ContextMenuMouse4AssemblyIterator)
                //.Peek()
                .Save();

            /*
            Msl.LoadGML("gml_GlobalScript_scr_create_context_menu")
                .MatchFrom("case \"Cook\"") // Finding the line
                .InsertAbove(ModFiles, "gml_GlobalScript_scr_create_context_menu_add.gml") // Inserting the snippet above
                .Save();
            */
            Msl.LoadAssemblyAsString("gml_GlobalScript_scr_create_context_menu")
                .Apply(CreateContextMenuAssemblyIterator)
                //.Peek()
                .Save();


//----------------------- CLUNKY BUT NECESSARY ALTERNATIVE TO TRADERS INVENTORY ADDITIONS -----------------------


            Msl.AddFunction(ModFiles.GetCode("gml_GlobalScript_scr_npc_stacked_items_stock_set.gml"), "scr_npc_stacked_items_stock_set");

            Msl.LoadGML("gml_Object_o_NPC_Other_24")
                .MatchFrom("scr_village_reputation_check()") // Finding the line
                .InsertAbove("scr_npc_stacked_items_stock_set()") // Inserting the snippet below
                .Save();


//----------------------- START OF TRADERS INVENTORY ADDITIONS -----------------------
/*
            //-----VILLAGE PEASANTS-----
            Msl.LoadGML("gml_Object_o_npc_peasant_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_peasant_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_arrowheads_15pc_few.gml") // Inserting the snippet below
                .Save();

            //-----BRYNN TOWNSPEOPLE-----
            Msl.LoadGML("gml_Object_o_npc_brynn_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_brynn_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_arrowheads_5pc_mid.gml") // Inserting the snippet below
                .Save();

            //-----INNKEEPERS-----
            Msl.LoadGML("gml_Object_o_class_innkeeper_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_class_innkeeper_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_arrowheads_100pc_few.gml") // Inserting the snippet below
                .Save();

            //-----GUARDS-----
            Msl.LoadGML("gml_Object_o_npc_guard_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_guard_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_arrowheads_Mixpc_few.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_guard_brynn_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_guard_brynn_Create_0")
                .MatchFrom("scr_npc_dialogue_init") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_arrowheads_Mixpc_few.gml") // Inserting the snippet below
                .Save();
                
            //-----SMITHS-----
            Msl.LoadGML("gml_Object_o_npc_smith_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_smith_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_arrowheads_100pc_lots.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_smith_mannshire_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_smith_mannshire_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_arrowheads_100pc_lots.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_vogt_smith01gq_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_vogt_smith01gq_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_arrowheads_100pc_lots.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_brynn_smith_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_brynn_smith_Create_0")
                .MatchFrom("can_repair") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_arrowheads_100pc_lots.gml") // Inserting the snippet below
                .Save();
                
            //-----LESSER SMITHS-----
            Msl.LoadGML("gml_Object_o_npc_pawnshop_owner_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_pawnshop_owner_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_arrowheads_50pc_mid.gml") // Inserting the snippet below
                .Save();
                
            //-----MERCHANTS-----
            Msl.LoadGML("gml_Object_o_npc_merchant_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_merchant_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_arrowheadsRare_30pc_mid.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_merchant_mannshire_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_merchant_mannshire_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_arrowheadsRare_30pc_mid.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_Merchant01d_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_Merchant01d_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_arrowheadsRare_30pc_mid.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_merchant01MS_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_merchant01MS_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_arrowheadsRare_30pc_mid.gml") // Inserting the snippet below
                .Save();
                
            //-----CARPENTERS-----
            Msl.LoadGML("gml_Object_o_npc_carpenter_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_carpenter_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_charredtipGlueArrowheads_100pc_mid.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_carpenter_mannshire_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_carpenter_mannshire_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_charredtipGlueArrowheads_100pc_mid.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_vogt_carpenter01gq_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_vogt_carpenter01gq_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_charredtipGlueArrowheads_100pc_mid.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_artisan_carpenter01gq_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_artisan_carpenter01gq_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_charredtipGlueArrowheads_100pc_mid.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_artisan_carpenter02gq_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_artisan_carpenter02gq_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_charredtipGlueArrowheads_100pc_mid.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_artisan_carpenter03gq_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_artisan_carpenter03gq_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_charredtipGlueArrowheads_100pc_mid.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_artisan_carpenter04gq_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_artisan_carpenter04gq_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_charredtipGlueArrowheads_100pc_mid.gml") // Inserting the snippet below
                .Save();
                
            //-----LESSER CARPENTERS-----
            Msl.LoadGML("gml_Object_o_npc_apprentice_carpenter01gq_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_apprentice_carpenter01gq_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_charredtipGlueArrowheads_100pc_midChoose.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_apprentice_carpenter02gq_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_apprentice_carpenter02gq_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_charredtipGlueArrowheads_100pc_midChoose.gml") // Inserting the snippet below
                .Save();
                
            //-----GUILD TAILORS----
            Msl.LoadGML("gml_Object_o_npc_vogt_tailor01gq_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_vogt_tailor01gq_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_glue_100pc_lots.gml") // Inserting the snippet below
                .Save();
                
            //-----TAILORS----
            Msl.LoadGML("gml_Object_o_npc_tailor_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_tailor_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_glue_100pc_mid.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_artisan_tailor01gq_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_artisan_tailor01gq_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_glue_100pc_mid.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_artisan_tailor02gq_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_artisan_tailor02gq_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_glue_100pc_mid.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_artisan_tailor03gq_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_artisan_tailor03gq_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_glue_100pc_mid.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_artisan_tailor04gq_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_artisan_tailor04gq_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_glue_100pc_mid.gml") // Inserting the snippet below
                .Save();
                
            //-----LESSER TAILORS----
            Msl.LoadGML("gml_Object_o_npc_smith_son_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_smith_son_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_glue_100pc_low.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_apprentice_tailor01gq_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_apprentice_tailor01gq_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_glue_100pc_low.gml") // Inserting the snippet below
                .Save();
                
            //-----SURVIVALISTS----
            Msl.LoadGML("gml_Object_o_npc_trapperA_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_trapperA_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_charredtip_100pc_low.gml") // Inserting the snippet below
                .Save();
                
            //-----LESSER DRUG DEALERS----
            Msl.LoadGML("gml_Object_o_npc_drugdealer_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_npc_drugdealer_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_traderAdd_glue_50pc_low.gml") // Inserting the snippet below
                .Save();

*/
//----------------------- END OF TRADERS INVENTORY ADDITIONS -----------------------



//----------------------- START OF CONTAINERS LOOT TABLES ADDITIONS -----------------------
               
            //-----COMMON CONTAINERS----
            Msl.LoadGML("gml_GlobalScript_scr_loot_default")
                .MatchFrom("(1 << 0))") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_lootAdd_arrowheads_33pc_mid.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_GlobalScript_scr_loot_interactive_grave_digged")
                .MatchFrom("if scr_chance_value(1)") // Finding the line
                .InsertAbove(ModFiles, "gml_modTemplate_lootAdd_arrowheads_10pc_mid.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_GlobalScript_scr_loot_nightstand01")
                .MatchFrom("case 5:") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_lootAdd_arrowheads_3pc_low_poor.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_GlobalScript_scr_loot_nightstand01")
                .MatchFrom("case 10:") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_lootAdd_arrowheads_3pc_low_balanced.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_GlobalScript_scr_loot_nightstand01")
                .MatchFrom("case 20:") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_lootAdd_arrowheads_3pc_mid_balanced.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_GlobalScript_scr_loot_skeletonloot")
                .MatchFrom("if scr_chance_value(35)") // Finding the line
                .InsertAbove(ModFiles, "gml_modTemplate_lootAdd_arrowheads_5pc_low_poor.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_GlobalScript_scr_loot_chest")
                .MatchFrom("case 4:") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_lootAdd_arrowheads_5pc_low_poor.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_GlobalScript_scr_loot_chest")
                .MatchFrom("case 9:") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_lootAdd_arrowheads_5pc_mid_poor.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_GlobalScript_scr_loot_chest")
                .MatchFrom("case 14:") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_lootAdd_arrowheads_5pc_mid_balanced.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_GlobalScript_scr_loot_chest")
                .MatchFrom("case 19:") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_lootAdd_arrowheads_5pc_lots_wealthy.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_GlobalScript_scr_loot_chest")
                .MatchFrom("default:") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_lootAdd_arrowheads_5pc_mid_balanced.gml") // Inserting the snippet below
                .Save();

            //-----PRE-SET CONTAINERS-----
            Msl.LoadGML("gml_GlobalScript_scr_loot_weaponstand03")
                .MatchFrom("scr_inventory_add_item(o_inv_leafshaped_bolts)") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_lootAdd_charredtip_100pc_mid.gml") // Inserting the snippet below
                .Save();
            
//----------------------- END OF CONTAINERS LOOT TABLES ADDITIONS -----------------------



//----------------------- START OF ENEMIES LOOT TABLES ADDITIONS ----------------------- Adding stackable items to enemy drops seems quite different and challenging. For a later update.

            //-----COMMON ENEMIES----
/*
            Msl.LoadGML("gml_Object_o_bandit_poacher_Create_0")
                .MatchFrom("o_loot_hide_quiver") // Finding the line
                .InsertBelow(ModFiles, "gml_modTemplate_lootAdd_charredtipArrowheads_10pc_low.gml") // Inserting the snippet below
                .Save();
            Msl.LoadGML("gml_Object_o_bandit_longbowman_Create_0")
                .MatchFrom("if scr_chance_value(8, 1)") // Finding the line
                .InsertAbove(ModFiles, "gml_modTemplate_lootAdd_Arrowheads_10pc_mix.gml") // Inserting the snippet below
                .Save();
*/
//----------------------- END OF ENEMIES LOOT TABLES ADDITIONS -----------------------

            
        }
    }
}

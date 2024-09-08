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
        public override string Description => "Use a cooking fire and a bladed weapon to turn sticks into cheap arrows and bolts";
        public override string Version => "2-0-dev-01";
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
b {jmp_end}";
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
b {jmp_end}";
            }
        }
    }

        public override void PatchMod()
        {

            Msl.AddMenu("Charred-Tip Arrows",
                new UIComponent(name:"Min from 1 stick", associatedGlobal:"makeCharredAmmoArrowsMin", UIComponentType.Slider, (0, 20), 1, false),
                new UIComponent(name:"Max from 1 stick", associatedGlobal:"makeCharredAmmoArrowsMax", UIComponentType.Slider, (0, 20), 2, false),
                new UIComponent(name:"Damage % modifier", associatedGlobal:"charredAmmoArrowsDamage", UIComponentType.Slider, (-100, 100), -50, false),
                new UIComponent(name:"Armor Penetr. % mod.", associatedGlobal:"charredAmmoArrowsArmorP", UIComponentType.Slider, (-100, 100), -50, false)
            ); 

            Msl.AddMenu("Charred-Tip Bolts",
                new UIComponent(name:"Min from 1 stick", associatedGlobal:"makeCharredAmmoBoltsMin", UIComponentType.Slider, (0, 20), 1, false),
                new UIComponent(name:"Max from 1 stick", associatedGlobal:"makeCharredAmmoBoltsMax", UIComponentType.Slider, (0, 20), 2, false),
                new UIComponent(name:"Damage % modifier", associatedGlobal:"charredAmmoBoltsDamage", UIComponentType.Slider, (-100, 100), -50, false),
                new UIComponent(name:"Armor Penetr. % mod.", associatedGlobal:"charredAmmoBoltsArmorP", UIComponentType.Slider, (-100, 100), -50, false)
            );     

            UndertaleGameObject invCharredTipArrows = Msl.AddObject(
                name:"o_inv_charredtip_arrows",
                spriteName:"s_inv_charredtiparrows",
                parentName:"o_inv_arrows_parent",
                isVisible:true,
                isAwake:true,
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
                new ScriptSet("o_charredtip_bolt_used", "gml_Object_o_charredtip_bolt_used_Draw_0.gml", EventType.Draw)

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

            
            Msl.LoadGML("gml_Object_o_npc_carpenter_Create_0")
                .Apply(CarpenterIterator)
                //.Peek()
                .Save();

            Msl.LoadGML("gml_GlobalScript_table_weapons_text")
                .Apply(LogWeaponTextIterator0)
                //.Peek()
                .Save();

            Msl.LoadGML("gml_GlobalScript_table_weapons_text")
                .Apply(LogWeaponTextIterator1)
                //.Peek()
                .Save();

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


            // IMPORTANT : this is temporary and for testing purposes. The items will be distributed among more appropriate traders
            Msl.LoadGML("gml_Object_o_npc_Innkeeper_Create_0")
                .MatchFrom("event_inherited()") // Finding the line
                .InsertBelow("stacked_items_stock = []") // Inserting the snippet above
                .Save();
            Msl.LoadGML("gml_Object_o_npc_Innkeeper_Create_0")
                .MatchFrom("gold_k") // Finding the line
                .InsertBelow(ModFiles, "gml_Object_o_npc_Innkeeper_Create_0_add.gml") // Inserting the snippet above
                .Save();


            // This part adds the capability of adding a variable amount of stackable items to a trader's inventory
            Msl.LoadGML("gml_Object_o_NPC_Other_24")
                .MatchFrom("with (scr_guiCreateContainer(global.guiBaseContainerSideLeft, o_trade_inventory))") // Finding the line
                .InsertBelow(ModFiles, "gml_Object_o_NPC_Other_24_add0.gml") // Inserting the snippet above
                .Save();
            Msl.LoadGML("gml_Object_o_NPC_Other_24")
                .MatchFrom("var g = math_round(owner.gold_k)") // Finding the line
                .InsertBelow(ModFiles, "gml_Object_o_NPC_Other_24_add1.gml") // Inserting the snippet above
                .Save();

            //This part adds the functionality of splitting stacks within a trader's inventory
            Msl.LoadGML("gml_Object_o_inv_slot_Mouse_5")
                .MatchFrom(ModFiles, "gml_Object_o_inv_slot_Mouse_5_match.gml")
                .ReplaceBy(ModFiles, "gml_Object_o_inv_slot_Mouse_5_add.gml")
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
            
        }
    }
}

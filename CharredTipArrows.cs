// Copyright (C)
// See LICENSE file for extended copyright information.
// This file is part of the repository from .

using ModShardLauncher;
using ModShardLauncher.Mods;
using UndertaleModLib;
using UndertaleModLib.Models;
using System.Text.RegularExpressions;

namespace CharredTipArrows
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
    public class CharredTipArrows : Mod
    {
        public override string Author => "Xaphedo";
        public override string Name => "Charred-Tip Arrows and Bolts";
        public override string Description => "Cheap Weak Arrows and Bolts";
        public override string Version => "0.0.0.2";
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
        
        string inserttext = "\"Charred-Tip Arrows;Fletched sticks that have been burned and sharpened to a point. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other arrows, better than literally nothing. Used by frugal hunters and underfunded militias.;\", \"Charred-Tip Bolts;Fletched sticks that have been burned and sharpened to a point. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;Fletched sticks that have been burned and sharpened to a point. Worse than all other bolts, better than literally nothing. Used by frugal hunters and underfunded militias.;\", "; //the string that the iterator will insert
        
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

    private static IEnumerable<string> TableTextIterator(IEnumerable<string> input)
    {
        string findtext = "\";context_menu_end;context_menu_end;context_menu_end;context_menu_end;context_menu_end;context_menu_end;context_menu_end;context_menu_end;context_menu_end;context_menu_end;context_menu_end;context_menu_end;\""; //the string that the iterator is looking for

        string inserttext = "\"101;Improvise some Arrows;Improvise some Arrows;Improvise some Arrows;Improvise some Arrows;Improvise some Arrows;Improvise some Arrows;Improvise some Arrows;Improvise some Arrows;Improvise some Arrows;Improvise some Arrows;Improvise some Arrows;Improvise some Arrows;\", \"102;Improvise some Bolts;Improvise some Bolts;Improvise some Bolts;Improvise some Bolts;Improvise some Bolts;Improvise some Bolts;Improvise some Bolts;Improvise some Bolts;Improvise some Bolts;Improvise some Bolts;Improvise some Bolts;Improvise some Bolts;\", \"103;You don't have any sticks;You don't have any sticks;You don't have any sticks;You don't have any sticks;You don't have any sticks;You don't have any sticks;You don't have any sticks;You don't have any sticks;You don't have any sticks;You don't have any sticks;You don't have any sticks;You don't have any sticks;\","; //the string that the iterator will insert

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

    private static IEnumerable<string> CampfireContextIterator(IEnumerable<string> input)
    {
        string findtext = "\"Cook\""; //the string that the iterator is looking for

        string inserttext = "\"Make_Charred_Arrows\", "; //the string that the iterator will insert

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
pushi.e 4
conv.i.v
pushi.e 2
conv.i.v
pushi.e o_inv_charredtip_arrows
conv.i.v
call.i gml_Script_scr_makeCharredAmmo(argc=3)
popz.v
b [1006]

:[1003]
pushi.e 4
conv.i.v
pushi.e 2
conv.i.v
pushi.e o_inv_charredtip_arrows
pushi.e scr_makeCharredAmmo
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
b {jmp_end}";
            }
        }
    }





/*

    private static IEnumerable<string> SpeechIterator0(IEnumerable<string> input)
    {
        string findtext = "\"Ambush;Ambush;Ambush;Ambush;Ambush;Ambush;Ambush;Ambush;Ambush;Ambush;Ambush;Ambush;Ambush;"; //the string that the iterator is looking for
        
        string inserttext = "\"interruption_East;interruption_East;interruption_East;interruption_East;interruption_East;interruption_East;interruption_East;interruption_East;interruption_East;interruption_East;interruption_East;interruption_East;interruption_East\", \";Враг на Востоке!;Enemy to the East!;有敌人在东边！;Feind im osten!;¡Enemigo al este!;Ennemi à l'est !;Nemico ad est!;Inimigo ao leste!;Wróg na wschodzie!;Düşman doğuda!;東の敵だ！ / 東の敵よ！;동쪽이다 적!\", \"interruption_East_end;interruption_East_end;interruption_East_end;interruption_East_end;interruption_East_end;interruption_East_end;interruption_East_end;interruption_East_end;interruption_East_end;interruption_East_end;interruption_East_end;interruption_East_end;interruption_East_end\", \"interruption_NorthEast;interruption_NorthEast;interruption_NorthEast;interruption_NorthEast;interruption_NorthEast;interruption_NorthEast;interruption_NorthEast;interruption_NorthEast;interruption_NorthEast;interruption_NorthEast;interruption_NorthEast;interruption_NorthEast;interruption_NorthEast\", \";Враг на Северо-Востоке!;Enemy to the North-East!;有敌人在东北边！;Feind im nordosten!;¡Enemigo al noreste!;Ennemi au nord-est !;Nemico a nord-est!;Inimigo ao nordeste!;Wróg na północnym wschodzie!;Düşman kuzeydoğuda!;北東の敵だ！ / 北東の敵よ！;북동쪽이다 적!\", \"interruption_NorthEast_end;interruption_NorthEast_end;interruption_NorthEast_end;interruption_NorthEast_end;interruption_NorthEast_end;interruption_NorthEast_end;interruption_NorthEast_end;interruption_NorthEast_end;interruption_NorthEast_end;interruption_NorthEast_end;interruption_NorthEast_end;interruption_NorthEast_end;interruption_NorthEast_end\", \"interruption_North;interruption_North;interruption_North;interruption_North;interruption_North;interruption_North;interruption_North;interruption_North;interruption_North;interruption_North;interruption_North;interruption_North;interruption_North\", \";Враг на Севере!;Enemy to the North!;有敌人在北边！;Feind im norden!;¡Enemigo al norte!;Ennemi au nord !;Nemico a nord!;Inimigo ao norte!;Wróg na północy!;Düşman kuzeyde!;北の敵だ！ / 北の敵よ！;북쪽이다 적!\", \"interruption_North_end;interruption_North_end;interruption_North_end;interruption_North_end;interruption_North_end;interruption_North_end;interruption_North_end;interruption_North_end;interruption_North_end;interruption_North_end;interruption_North_end;interruption_North_end;interruption_North_end\", \"interruption_NorthWest;interruption_NorthWest;interruption_NorthWest;interruption_NorthWest;interruption_NorthWest;interruption_NorthWest;interruption_NorthWest;interruption_NorthWest;interruption_NorthWest;interruption_NorthWest;interruption_NorthWest;interruption_NorthWest;interruption_NorthWest\", \";Враг на Северо-Западе!;Enemy to the North-West!;有敌人在西北边！;Feind im nordwesten!;¡Enemigo al noroeste!;Ennemi au nord-ouest !;Nemico a nord-ovest!;Inimigo ao noroeste!;Wróg na północnym zachodzie!;Düşman kuzeybatıda!;北西の敵だ！ / 北西の敵よ！;북서쪽이다 적!\", \"interruption_NorthWest_end;interruption_NorthWest_end;interruption_NorthWest_end;interruption_NorthWest_end;interruption_NorthWest_end;interruption_NorthWest_end;interruption_NorthWest_end;interruption_NorthWest_end;interruption_NorthWest_end;interruption_NorthWest_end;interruption_NorthWest_end;interruption_NorthWest_end;interruption_NorthWest_end\", \"interruption_West;interruption_West;interruption_West;interruption_West;interruption_West;interruption_West;interruption_West;interruption_West;interruption_West;interruption_West;interruption_West;interruption_West;interruption_West\", \";Враг на Западе!;Enemy to the West!;有敌人在西边！;Feind im westen!;¡Enemigo al oeste!;Ennemi à l'ouest !;Nemico ad ovest!;Inimigo ao oeste!;Wróg na zachodzie!;Düşman batıda!;西の敵だ！ / 西の敵よ！;서쪽이다 적!\", \"interruption_West_end;interruption_West_end;interruption_West_end;interruption_West_end;interruption_West_end;interruption_West_end;interruption_West_end;interruption_West_end;interruption_West_end;interruption_West_end;interruption_West_end;interruption_West_end;interruption_West_end\", \"interruption_SouthWest;interruption_SouthWest;interruption_SouthWest;interruption_SouthWest;interruption_SouthWest;interruption_SouthWest;interruption_SouthWest;interruption_SouthWest;interruption_SouthWest;interruption_SouthWest;interruption_SouthWest;interruption_SouthWest;interruption_SouthWest\", \";Враг на Юго-Западе!;Enemy to the South-West!;有敌人在西南边！;Feind im südwesten!;¡Enemigo al suroeste!;Ennemi au sud-ouest !;Nemico a sud-ovest!;Inimigo ao sudoeste!;Wróg na południowym zachodzie!;Düşman güneybatıda!;南西の敵だ！ / 南西の敵よ！;남서쪽이다 적!\", \"interruption_SouthWest_end;interruption_SouthWest_end;interruption_SouthWest_end;interruption_SouthWest_end;interruption_SouthWest_end;interruption_SouthWest_end;interruption_SouthWest_end;interruption_SouthWest_end;interruption_SouthWest_end;interruption_SouthWest_end;interruption_SouthWest_end;interruption_SouthWest_end;interruption_SouthWest_end\", \"interruption_South;interruption_South;interruption_South;interruption_South;interruption_South;interruption_South;interruption_South;interruption_South;interruption_South;interruption_South;interruption_South;interruption_South;interruption_South\", \";Враг на Юге!;Enemy to the South!;有敌人在南边！;Feind im süden!;¡Enemigo al sur!;Ennemi au sud !;Nemico a sud!;Inimigo ao sul!;Wróg na południu!;Düşman güneyde!;南の敵だ！ / 南の敵よ！;남쪽이다 적!\", \"interruption_South_end;interruption_South_end;interruption_South_end;interruption_South_end;interruption_South_end;interruption_South_end;interruption_South_end;interruption_South_end;interruption_South_end;interruption_South_end;interruption_South_end;interruption_South_end;interruption_South_end\", \"interruption_SouthEast;interruption_SouthEast;interruption_SouthEast;interruption_SouthEast;interruption_SouthEast;interruption_SouthEast;interruption_SouthEast;interruption_SouthEast;interruption_SouthEast;interruption_SouthEast;interruption_SouthEast;interruption_SouthEast;interruption_SouthEast\", \";Враг на Юго-Востоке!;Enemy to the South-East!;有敌人在东南边！;Feind im südosten!;¡Enemigo al sureste!;Ennemi au sud-est !;Nemico a sud-est!;Inimigo ao sudeste!;Wróg na południowym wschodzie!;Düşman güneydoğuda!;南東の敵だ！ / 南東の敵よ！;남동쪽이다 적!\", \"interruption_SouthEast_end;interruption_SouthEast_end;interruption_SouthEast_end;interruption_SouthEast_end;interruption_SouthEast_end;interruption_SouthEast_end;interruption_SouthEast_end;interruption_SouthEast_end;interruption_SouthEast_end;interruption_SouthEast_end;interruption_SouthEast_end;interruption_SouthEast_end;interruption_SouthEast_end\", "; //the string that the iterator will insert
        
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

    private static IEnumerable<string> SpeechIterator1(IEnumerable<string> input)
    {
        string findtext = "\"Ambush;100;100;"; //the string that the iterator is looking for
        
        string inserttext = "\"interruption_East;100;100;100;100;100;100;100;100;100;100;100;100\", \"interruption_NorthEast;100;100;100;100;100;100;100;100;100;100;100;100\", \"interruption_North;100;100;100;100;100;100;100;100;100;100;100;100\", \"interruption_NorthWest;100;100;100;100;100;100;100;100;100;100;100;100\", \"interruption_West;100;100;100;100;100;100;100;100;100;100;100;100\", \"interruption_SouthWest;100;100;100;100;100;100;100;100;100;100;100;100\", \"interruption_South;100;100;100;100;100;100;100;100;100;100;100;100\", \"interruption_SouthEast;100;100;100;100;100;100;100;100;100;100;100;100\", "; //the string that the iterator will insert
        
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

        public override void PatchMod()
        {

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
                new ScriptSet("o_charredtip_bolt_used", "gml_Object_o_charredtip_bolt_used_Draw_0.gml", EventType.Draw),

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

            Msl.AddFunction(ModFiles.GetCode("gml_GlobalScript_scr_makeCharredAmmo.gml"), "scr_makeCharredAmmo");

            
            Msl.LoadGML("gml_Object_o_npc_carpenter_Create_0")
                .Apply(CarpenterIterator)
                .Peek()
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
                .Peek()
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

            Msl.LoadGML("gml_GlobalScript_scr_create_context_menu")
                .MatchFrom("case \"Cook\"") // Finding the line
                .InsertAbove(ModFiles, "gml_GlobalScript_scr_create_context_menu_add.gml") // Inserting the snippet above
                .Save();
                
            Msl.LoadGML("gml_Object_o_player_Other_17")
                .MatchFrom("event_user(interract_event)") // Finding the line
                .ReplaceBy(ModFiles, "gml_Object_o_player_Other_17_add.gml") // Inserting the snippet above
                .Save();


            Msl.LoadGML("gml_GlobalScript_table_text")
                .Apply(TableTextIterator)
                .Peek()
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
                
            //Msl.LoadGML("gml_Object_o_context_button_Mouse_4")
            //    .MatchFrom("case \"Cook\"") // Finding the line
            //    .InsertAbove(ModFiles, "gml_Object_o_context_button_Mouse_4_add.gml") // Inserting the snippet above
            //    .Save();
            Msl.LoadAssemblyAsString("gml_Object_o_context_button_Mouse_4")
                .Apply(ContextMenuMouse4AssemblyIterator)
                .Peek()
                .Save();


            // Msl.AddFunction(ModFiles.GetCode("gml_Object_o_charredtip_arrow_used_Create_0.gml"), "scr_makeCharredAmmo");


            /*
            
            Msl.AddFunction(ModFiles.GetCode("gml_GlobalScript_scr_GetCardinalDirection.gml"), "scr_getCardinalDirection");

            Msl.LoadGML("gml_GlobalScript_table_log_text")
                .Apply(LogTextIterator)
                //.Peek()
                .Save();

            Msl.LoadGML("gml_GlobalScript_table_speech")
                .Apply(SpeechIterator0)
                //.Peek()
                .Save();

            Msl.LoadGML("gml_GlobalScript_table_speech")
                .Apply(SpeechIterator1)
                //.Peek()
                .Save();

            Msl.LoadGML("gml_Object_o_fogrender_Other_12")
                .MatchFrom("logFOVTurns = 20") // Finding the line
                .InsertBelow(ModFiles, "gml_Object_o_fogrender_Other_12_add0.gml")// Inserting the snippet below
                .Save(); 

            Msl.LoadGML("gml_Object_o_fogrender_Other_12")
                .MatchFrom("if (state == \"attack\")") // Finding the line
                .InsertAbove(ModFiles, "gml_Object_o_fogrender_Other_12_add1.gml") // Inserting the snippet above
                .Save();

            Msl.LoadGML("gml_Object_o_fogrender_Other_12") // Loading a script from the game's files
                .MatchFrom("scr_actionsLog(\"enemyHostileFOV\", [_name, _name])") // Finding the line
                .ReplaceBy("scr_actionsLog(\"enemyHostileFOV\", [_nameAndDirection, _name])")// Replacing it
                .Save();

            Msl.LoadGML("gml_Object_o_fogrender_Other_12")
                .MatchFrom("scr_actionsLog(\"enemyAlarmFOV\", [_name, _name])")
                .ReplaceBy("scr_actionsLog(\"enemyAlarmFOV\", [_nameAndDirection, _name])")
                .Save();

            Msl.LoadGML("gml_Object_o_fogrender_Other_12")
                .MatchFrom("scr_actionsLog(\"enemyUnawareFOV\", [_name, _name])")
                .ReplaceBy("scr_actionsLog(\"enemyUnawareFOV\", [_nameAndDirection, _name])")
                .Save();


            Msl.LoadGML("gml_GlobalScript_scr_stateAttack")
                .MatchFrom("scr_random_speech(\"interruption\", 100, o_player)") // Finding the line
                .ReplaceBy(ModFiles, "gml_GlobalScript_scr_stateAttack_add0.gml") // Replacing with
                .MatchFrom("scr_random_speech(\"interruption\", 100, o_player)") // Finding the line once again
                .ReplaceBy(ModFiles, "gml_GlobalScript_scr_stateAttack_add0.gml") // Replacing with once again
                //.Peek()
                .Save();

            */
        }
    }
}

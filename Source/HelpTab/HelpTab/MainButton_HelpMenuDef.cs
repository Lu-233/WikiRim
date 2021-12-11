﻿using RimWorld;
using UnityEngine;

namespace HelpTab;

public class MainButton_HelpMenuDef : MainButtonDef
{
    public float listWidth = MainTabWindow_ModHelp.MinListWidth;
    public bool pauseGame = false;

    public Vector2 windowSize = new Vector2(MainTabWindow_ModHelp.MinWidth, MainTabWindow_ModHelp.MinHeight);
}
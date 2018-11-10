﻿using System;
using Verse;

namespace Merthsoft.DesignatorShapes {
    public class DesignatorSettings : ModSettings {
        public bool ShowShapesPanelOnDesignationSelection = true;
        public bool MoveDesignationTabToEndOfList = false;
        public int FloodFillCellLimit = 1500;
        [Obsolete] public bool ShowUndoAndRedoButtons = false;
        public bool UseOldUi = false;
        public bool UseSubMenus = true;
        public bool AutoSelectShape = false;

        public override void ExposeData() {
            base.ExposeData();

            Scribe_Values.Look(ref ShowShapesPanelOnDesignationSelection, "ShowShapesPanelOnDesignationSelection", true);
            Scribe_Values.Look(ref MoveDesignationTabToEndOfList, "MoveDesignationTabToEndOfList", false);
            Scribe_Values.Look(ref FloodFillCellLimit, "FloodFillCellLimit", 1500);
            Scribe_Values.Look(ref UseOldUi, "UseOldUi", false);
            Scribe_Values.Look(ref UseSubMenus, "UseSubMenus", true);
            Scribe_Values.Look(ref AutoSelectShape, "AutoSelectShape", false);
        }
    }
}
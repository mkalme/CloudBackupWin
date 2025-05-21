﻿using System;
using CustomDialogs;

namespace CloudBackup.Gui {
    public class ItemSelectorProfile : CustomDialogs.ItemSelectorProfile {
        public override Func<object, bool> DoubleClickValidator => item => ((Item)item).ID != ItemID.Group;
        public override Func<object, string> ItemNameCreator => item => ((Item)item).Name;
        public override Func<object, INode> NodeCreator => item => new GroupNode(item as Group);
    }
}

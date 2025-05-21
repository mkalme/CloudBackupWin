﻿using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup.Gui {
    public class AppInformationDeserializer : IObjectDeserializer<AppInformation> {
        public AppInformation Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            return new AppInformation() { 
                KeyChangeHistory = new DateTimeHistory((DateTime[])obj["KeyChangeHistory"]),
                Created = obj["Created"]
            };
        }
    }
}

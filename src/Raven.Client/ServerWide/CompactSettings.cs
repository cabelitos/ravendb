﻿using System.Collections.Generic;
using Sparrow.Json.Parsing;

namespace Raven.Server.Documents
{
    public class CompactSettings
    {
        public string DatabaseName { get; set; }

        public bool Documents { get; set; }

        public string[] Indexes { get; set; }

        public DynamicJsonValue ToJson()
        {
            return new DynamicJsonValue
            {
                [nameof(DatabaseName)] = DatabaseName,
                [nameof(Documents)] = Documents,
                [nameof(Indexes)] = Indexes
            };
        }
    }
}

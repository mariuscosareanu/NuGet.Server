// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using System.Web.Configuration;
using NuGet.Server.Core.Infrastructure;

namespace NuGet.Server.Infrastructure
{
    public class WebConfigSettingsProvider : ISettingsProvider
    {
        public bool GetBoolSetting(string key, bool defaultValue)
        {
            var appSettings = WebConfigurationManager.AppSettings;
            return !bool.TryParse(appSettings[key], out var value) ? defaultValue : value;
        }

        public int GetIntSetting(string key, int defaultValue)
        {
            var appSettings = WebConfigurationManager.AppSettings;
            return !int.TryParse(appSettings[key], out var value) ? defaultValue : value;
        }
    }
}
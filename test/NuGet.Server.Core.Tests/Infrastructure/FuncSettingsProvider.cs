// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 
using System;
using NuGet.Server.Core.Infrastructure;

namespace NuGet.Server.Core.Tests.Infrastructure
{
    class FuncSettingsProvider : ISettingsProvider
    {
        readonly Func<string, bool, bool> _getSetting;
        readonly Func<string, int, int> _getIntSetting;

        internal FuncSettingsProvider(Func<string,bool,bool> getSetting, Func<string, int, int> getIntSetting)
        {
            if (getSetting == null)
            {
                throw new ArgumentNullException(nameof(getSetting));
            }

            if (getIntSetting == null)
            {
                throw new ArgumentNullException(nameof(getIntSetting));
            }

            _getSetting = getSetting;
            _getIntSetting = getIntSetting;
        }

        public bool GetBoolSetting(string key, bool defaultValue)
        {
            return _getSetting(key, defaultValue);
        }

        public int GetIntSetting(string key, int defaultValue)
        {
            return _getIntSetting(key, defaultValue);
        }
    }
}

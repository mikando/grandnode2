﻿using System.Collections.Generic;

namespace Grand.Web.Common.Themes
{
    public interface IThemeList
    {
        IList<ThemeConfiguration> ThemeConfigurations { get; }
    }
}

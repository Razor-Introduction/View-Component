﻿using System;
using System.Threading.Tasks;
using global::Microsoft.AspNetCore.Mvc.Rendering;
using global::Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Razor.Inroduction.ViewComponentsAndPartialView.Web.Utils
{
    public class NullView : IView
    {
        public static readonly NullView Instance = new NullView();

        public string Path => string.Empty;

        public Task RenderAsync(ViewContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            return Task.CompletedTask;
        }
    }
}

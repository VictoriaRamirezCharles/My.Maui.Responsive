﻿using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace My.Maui.Responsive.Extensions
{
    internal static class ViewExtensions
    {
        internal static int GetColumnSpan(this IView view, int @default = default)
        {
            var columnSpan = Row.GetColumnSpan((BindableObject)view).Current;

            return columnSpan == default ? @default : columnSpan;
        }

        internal static bool IsAutoColumn(this IView view)
        {
            var columnSpan = Row.GetColumnSpan((BindableObject)view).Current;

            return columnSpan == default;
        }

        internal static int GetOrder(this IView view) => Row.GetOrder((BindableObject)view).Current;

        internal static int GetOffset(this IView view) => Row.GetOffset((BindableObject)view).Current;
    }
}

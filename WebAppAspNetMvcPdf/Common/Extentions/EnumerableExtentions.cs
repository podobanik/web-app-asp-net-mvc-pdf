﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Common.Extentions
{
    public static class EnumerableExtentions
    {

        public static IEnumerable<SelectListItem> ToSelectList<TItem, TValue>(this IEnumerable<TItem> items, Func<TItem, TValue> valueSelector, Func<TItem, string> nameSelector, Func<TItem, bool> selectedValueSelector)
        {
            foreach (var item in items)
            {
                var value = valueSelector(item);

                yield return new SelectListItem
                {
                    Text = nameSelector(item),
                    Value = value.ToString(),
                    Selected = selectedValueSelector(item)
                };
            }
        }

    }
}
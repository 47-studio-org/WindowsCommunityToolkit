// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Microsoft.Toolkit.Uwp.UI.Controls.Graph
{
    internal class PlannerTaskItemSelector : DataTemplateSelector
    {
        public DataTemplate NormalTemplate { get; set; }

        public DataTemplate ActiveTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            ListViewItem itemContainer = container as ListViewItem;
            DataTemplate dataTemplate = NormalTemplate;
            if (item is bool && (bool)item)
            {
                dataTemplate = ActiveTemplate;
            }

            if (itemContainer != null)
            {
                itemContainer.ContentTemplate = dataTemplate;
            }

            return dataTemplate;
        }
    }
}

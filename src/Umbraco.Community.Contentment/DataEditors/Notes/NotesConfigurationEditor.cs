﻿/* Copyright © 2019 Lee Kelleher.
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System.Collections.Generic;
using Umbraco.Core.IO;
using Umbraco.Core.PropertyEditors;

namespace Umbraco.Community.Contentment.DataEditors
{
    internal sealed class NotesConfigurationEditor : ConfigurationEditor
    {
        internal const string Notes = NotesConfigurationField.Notes;

        public NotesConfigurationEditor()
            : base()
        {
            Fields.Add(
                Notes,
                nameof(Notes),
                "Enter the notes to be displayed for the content editor.",
                IOHelper.ResolveUrl("~/umbraco/views/propertyeditors/rte/rte.html"),
                new Dictionary<string, object>
                {
                    { "editor", new
                        {
                            maxImageSize = 500,
                            mode = "classic",
                            stylesheets = false,
                            toolbar = new[]
                            {
                                "ace",
                                "undo",
                                "redo",
                                "cut",
                                "styleselect",
                                "removeformat",
                                "bold",
                                "italic",
                                "alignleft",
                                "aligncenter",
                                "alignright",
                                "bullist",
                                "numlist",
                                "link",
                                "umbmediapicker",
                                "umbmacro",
                                "umbembeddialog"
                            },
                        }
                    }
                });

            Fields.Add(new HideLabelConfigurationField());
        }
    }
}

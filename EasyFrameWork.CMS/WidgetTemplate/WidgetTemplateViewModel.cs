﻿using System.Collections.Generic;

namespace Easy.Web.CMS.WidgetTemplate
{
    public class WidgetTemplateViewModel
    {
        public string PageID { get; set; }
        public string LayoutID { get; set; }
        public string ZoneID { get; set; }
        public bool CanPasteWidget { get; set; }
        public string ReturnUrl { get; set; }
        public List<WidgetTemplateEntity> WidgetTemplates { get; set; }
    }
}

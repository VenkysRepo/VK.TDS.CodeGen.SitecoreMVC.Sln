using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VTDSGlass.Models.Common.Interfaces;

namespace VTDSGlass.Models.Common.Classes
{
    public abstract class GlassBase : IGlassBase
    {

        [SitecoreId]
        public virtual Guid Id { get; private set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language { get; private set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get; private set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        public virtual Guid Template_Id { get; set; }
    }
}
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VTDSGlass.Models.Common.Interfaces
{
    public interface IGlassBase
    {

        [SitecoreId]
        Guid Id { get; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        Language Language { get; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        Guid Template_Id { get; }

    }
}
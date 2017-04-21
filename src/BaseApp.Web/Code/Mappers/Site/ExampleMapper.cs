﻿using BaseApp.Data.DataContext.Entities;
using BaseApp.Web.Models.Example;

namespace BaseApp.Web.Code.Mappers.Site
{
    public class ExampleMapper: MapperBase
    {
        protected override void CreateMaps()
        {
            CreateMap<Country, CountryListItemModel>();
        }
    }
}

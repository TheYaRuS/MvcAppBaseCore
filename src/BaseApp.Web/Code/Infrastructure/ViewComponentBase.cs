﻿using System;
using AutoMapper;
using BaseApp.Data.Infrastructure;
using BaseApp.Web.Code.Infrastructure.LogOn;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace BaseApp.Web.Code.Infrastructure
{
    public abstract class ViewComponentBase: ViewComponent
    {
        protected UnitOfWork UnitOfWork => RequestServices.GetRequiredService<IUnitOfWorkFactory>().UnitOfWork;
        protected ILoggedUserAccessor LoggedUser => RequestServices.GetRequiredService<ILoggedUserAccessor>();
        protected IMapper Mapper => RequestServices.GetRequiredService<IMapper>();
        

        private IServiceProvider RequestServices => ViewComponentContext.ViewContext.HttpContext.RequestServices;
    }
}

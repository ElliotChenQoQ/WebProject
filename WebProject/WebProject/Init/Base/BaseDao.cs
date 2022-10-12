using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using WebProject.Core.EntityFramework;
using WebProject.Init.Base.Interface;

namespace WebProject.Init.Base
{
    public abstract class BaseDao : BaseLayer, IBaseDao
    {
        private IServiceProvider _services;

        /// <summary>
        /// AutoMapper
        /// </summary>
        protected IMapper Mapper { get; set; }

        /// <summary>
        /// AutoMapper
        /// </summary>
        protected abstract void AutoMapperConfiguration();

        /// <summary>
        /// Initializes a new instance 
        /// </summary>
        public BaseDao(IServiceProvider services)
        {
            _services = services;
            AutoMapperConfiguration();
        }

        /// <summary>
        /// 取得 Entity Framework Context
        /// </summary>
        /// <returns>Context</returns>
        public dynamic GetContext()
        {
            MainContext context = ActivatorUtilities.CreateInstance<MainContext>(_services);

            return context;
        }
    }
}

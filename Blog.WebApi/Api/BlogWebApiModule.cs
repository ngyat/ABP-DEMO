using System.Reflection;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Abp.Web;

namespace Blog.Api
{
    [DependsOn(typeof(AbpWebApiModule), typeof(BlogApplicationModule))]
    public class BlogWebApiModule : AbpModule
    {
        //public override void Initialize()
        //{
        //    IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

        //    Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
        //        .ForAll<IApplicationService>(typeof(BlogApplicationModule).Assembly, "app")
        //        .Build();

        //    Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));
        //}


        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            //http://localhost/api/services/app/player/getPlayers
            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(BlogApplicationModule).Assembly, "app")
                //.ForMethods(builder =>
                //{
                //    builder.Verb = HttpVerb.Get;
                //})
                .Build();

            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));
        }
    }
}

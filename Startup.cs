using System;
using AspNetCoreTodo.Services;

namespace AspNetCoreTodo
{
    public class Startup
    {
        public void ConfigurationServices(IServiceCollection services)
        {

            //services.AddMvc();

            services.AddSingleton<ITodoItemService, FakeTodoItemService>();

        }
    }
}


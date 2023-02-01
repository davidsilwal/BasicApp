using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace SharedKernel.Application.Extensions
{
    public static class WebApplicationExtension
    {
        public static void AddBasicWebAppExtensions(this WebApplication? app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

        }
    }
}

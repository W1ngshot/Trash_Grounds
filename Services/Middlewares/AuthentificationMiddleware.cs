using System;
using Microsoft.AspNetCore.Http;
using TrashGrounds.Services;
using Microsoft.AspNetCore.Mvc;
using TrashGrounds.Models.Database;

namespace TrashGrounds.Services.Middlewares;

public class AuthentificationMiddleware
{
    private readonly RequestDelegate next;

    public AuthentificationMiddleware(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if (context.Request.Cookies.TryGetValue("auth", out var sessionKey))
        {
            var user = SessionCaseStorage.GetUserByKey(sessionKey ?? "");
            context.Items["User"] = user;
        }

        await next(context);
    }
}

public static class AuthentificationControllerExtensions {
    public static User? GetUser(this Controller controller) 
    {
        if (controller.HttpContext.Items.TryGetValue("User", out var user))
            return user as User;

        return null;
    }

    public static void ProvideUserToViewBag(this Controller controller) {
        controller.ViewBag.User = controller.GetUser();
    }
} 

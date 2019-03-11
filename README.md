# coreapp-karolien-peeters
coreapp-karolien-peeters created by GitHub Classroom

services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings  
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.LoginPath = "/Identity/Account/Login"; // If the LoginPath is not set here, ASP.NET Core will default to /Account/Login  
                options.LogoutPath = "/Identity/Account/Logout"; // If the LogoutPath is not set here, ASP.NET Core will default to /Account/Logout  
                 options.AccessDeniedPath = "/Identity/Account/Login";  // If the AccessDeniedPath is not set here, ASP.NET Core will default to /Account/AccessDenied  
             
                options.SlidingExpiration = true;
            });

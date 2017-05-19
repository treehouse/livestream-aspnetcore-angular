
# Treehouse Live Coding - ASP.NET Core and Angular (2017-05-19)

In this livestream, Treehouse teacher James Churchill ([@SmashDev](https://twitter.com/SmashDev)) builds a simple ASP.NET Core web API and Angular client web app.

Watch the video on YouTube at: [https://www.youtube.com/watch?v=hZDqJJ5tZeg](https://www.youtube.com/watch?v=hZDqJJ5tZeg)

## Building and Running the API and Client Web App

Our overall project setup and build process is a little lacking, but functional. If you make a change to the Angular client web app, you'll need to use the Angular CLI to build and deploy a production release into the ASP.NET Core project's `wwwroot` folder.

```
cd ClientApp
ng build --prod
```

Then, use the .NET Core CLI to restore, build, and run the ASP.NET Core app.

```
cd WebApp
dotnet restore
dotnet build
dotnet run
```

Now you should be able to browse to `http://localhost:5000/index.html` to view the web app. Click the "Get Video Games" button to call the ASP.NET Core Web API and display the returned data.

## Resources

For a list of useful resources, see [this list](resources.md).

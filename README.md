
# Treehouse Live Coding - ASP.NET Core and Angular (2017-05-19)

In this livestream, Treehouse teacher James Churchill ([@SmashDev](https://twitter.com/SmashDev)) builds a simple ASP.NET Core web API and Angular client web app.

Watch the video on YouTube at: [https://www.youtube.com/watch?v=hZDqJJ5tZeg](https://www.youtube.com/watch?v=hZDqJJ5tZeg)

## Application Overview

Our application will be a basic CRUD (create, read, update, and delete) single-page application (SPA) that allows users to manage a video game library. We'll use ASP.NET Core for the backend REST/HTTP API and Angular for the frontend client.

### API Methods

Our ASP.NET Core (v1.1) REST/HTTP API will support the following methods:

* Get - Returns a list of records
* Get(id) - Returns a single record for the provided `id` parameter
* Post - Adds a record
* Put - Updates a record 
* Delete(id) - Deletes a single record for the provided `id` parameter

We'll be using the .NET Core CLI (`dotnet`) throughout this livestream to build and run the ASP.NET Core application. Initially, we'll be using in-memory data but later on we'll add Entity Framework Core into the mix for data persistence.

### Frontend Client

Our Angular (v4) frontend client will include the following screens:

* Video Games - Displays a list of video games
* Video Game - Displays the details for a single video game
* Add Video Game - Allows the user to add a video game
* Edit Video Game - Allows the user to edit a video game

We'll be using the Angular CLI (`ng`) throughout this livestream to build and run the Angular application.

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

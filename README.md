
# Treehouse Live Coding - ASP.NET Core and Angular

In this series of livestream sessions, Treehouse teacher James Churchill ([@SmashDev](https://twitter.com/SmashDev)) builds a simple ASP.NET Core web API and Angular client web app.

Watch the videos on YouTube at:

* Week 1 (5/19/2017): [https://www.youtube.com/watch?v=hZDqJJ5tZeg](https://www.youtube.com/watch?v=hZDqJJ5tZeg)
* Week 2 (7/28/2017): [https://www.youtube.com/watch?v=hZDqJJ5tZeg](https://www.youtube.com/watch?v=hZDqJJ5tZeg)
* Week 3 (8/4/2017): TBD
* Week 4 (8/11/2017): TBD

## Application Overview

Our application will be a basic CRUD (create, read, update, and delete) single-page application (SPA) that allows users to manage a video game library. We'll use ASP.NET Core for the backend REST/HTTP API and Angular for the frontend client.

### API Methods

Our ASP.NET Core (v1.1) REST/HTTP API will support the following methods:

* Get - Returns a list of records
* Get(id) - Returns a single record for the provided `id` parameter
* Post - Adds a record
* Put - Updates a record 
* Delete(id) - Deletes a single record for the provided `id` parameter

We'll be using the .NET Core CLI (`dotnet`) throughout this livestream series to build and run the ASP.NET Core application. Initially, we'll be using in-memory data but later on we'll add Entity Framework Core into the mix for data persistence.

### Frontend Client

Our Angular (v4) frontend client will include the following screens:

* Video Games - Displays a list of video games
* Video Game - Displays the details for a single video game
* Add Video Game - Allows the user to add a video game
* Edit Video Game - Allows the user to edit a video game

We'll be using the Angular CLI (`ng`) throughout this livestream series to build and run the Angular application.

## Week 1 (5/19/2017) Notes

* Created the backend ASP.NET Core project using the .NET Core CLI
* Added a simple API controller that utilizes (for the time being) in-memory data
* Created the frontend Angular project using the Angular CLI
* Updated the Angular `App` component to display a button that when clicked makes a call to our API and displays the list of retrieved video games

### Building and Running the API and Client Web App

By the end of this session, our overall project setup and build process was a little lacking, but functional. If we made a change to the Angular client web app, we needed to use the Angular CLI to build and deploy a production release into the ASP.NET Core project's `wwwroot` folder.

```
cd ClientApp
ng build --prod
```

Then, we used the .NET Core CLI to restore, build, and run the ASP.NET Core app.

```
cd WebApp
dotnet restore
dotnet build
dotnet run
```

Then we could browse to `http://localhost:5000/index.html` to view the web app. Clicking the "Get Video Games" button calls the ASP.NET Core Web API and displays the returned data.

## Week 2 (7/28/2017) Notes

* Fixed ASP.NET Core default file handling
* Improved our development workflow
* Improved the implementation of our API methods
* Updated the Angular `App` component to load data from the API when the component is initialized
* Improved the layout of the "Video Games" list page
* Added support for client-side routing
* Added "Add Video Game" page

### Improving Our Development Workflow

The first step in improving our development workflow was to enable CORS ([https://developer.mozilla.org/en-US/docs/Web/HTTP/Access_control_CORS](https://developer.mozilla.org/en-US/docs/Web/HTTP/Access_control_CORS)) for our ASP.NET Core API. Enabling CORS allowed us to use the Angular CLI development server to host our client app. Previously, this wasn't possible as using the Angular CLI development server meant that the client and API apps are hosted at different domains (respectively `http://localhost:4200` and `http://localhost:5000`).

#### Try It Out

Open a terminal/command window, browse to the root of the `src/WebApp` directory, and run the command:

```
dotnet watch run
```

Open another terminal/command window, browse to the root of the `src/ClientApp` directory, and run the command:

```
ng serve
```

Now you can make a change to the ASP.NET Core project and the `dotnet watch` command will stop the server, recompile your project, and restart the server. Correspondingly, making a change to the Angular project will cause the `ng serve` command to compile and package your project, then refresh the app in the browser.

This change vastly improves our development workflow by reducing the amount of repetitive work we have to do when making a change to our app.

## Resources

For a list of useful resources, see [this list](resources.md).

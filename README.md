# 🍎 BlazingApple's FontAwesome
## 🗚 FontSearchService
The `FontSearchService` is intended to be used by consumers who wish to _search_ FontAwesome icons. It uses FontAwesome's [GraphQL API]([url](https://fontawesome.com/docs/apis/graphql/get-started)) to search against the version of your choosing.

## 🔗 Resources
[BlazingApple]([url](https://github.com/BlazingApple))'s [Components]([url](https://github.com/BlazingApple/Components)) package uses `FontSearchService` in it's `IconChooser` component, pictured below:

![image](https://user-images.githubusercontent.com/3686217/171191937-5b620ca4-0e55-48c8-9255-1e669effc7e7.png)


If you're just looking for a Blazor-based (javascript-free) icon chooser for FontAwesome, use [that package]([url](https://www.nuget.org/packages/BlazingApple.Components/)).

## 🔧 Configuration
The configuration values are sourced from the ConfigurationRoot's `FontAwesome` section. Configure the following:
- `Version`
- `Memberships` - Just `Free`, or `Paid` icons as well?
- `BearerToken` - Used to provide authorization to FontAwesome

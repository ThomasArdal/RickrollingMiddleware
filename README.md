# RickrollingMiddleware

This package implements a piece of ASP.NET Core middleware, rick rolling anyone requesting invalid URLs. The code is inspired by this tweet: https://twitter.com/LiamHammett/status/1260984553570570240.

## Usage

Call the `UseRickrolling()` method in the `Configure` method:

```csharp
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    // ...

    app.UseRickrolling();

    // ...
}
```

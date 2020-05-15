# RickrollingMiddleware

This package implements a piece of ASP.NET Core middleware, rick rolling anyone requesting invalid URLs. The code is inspired by this tweet:

<blockquote class="twitter-tweet"><p lang="en" dir="ltr">🙃 Make sure to rickroll people trying to break into your site <a href="https://t.co/4cd80Pr9p9">pic.twitter.com/4cd80Pr9p9</a></p>&mdash; Liam Hammett (@LiamHammett) <a href="https://twitter.com/LiamHammett/status/1260984553570570240?ref_src=twsrc%5Etfw">May 14, 2020</a></blockquote> <script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>

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

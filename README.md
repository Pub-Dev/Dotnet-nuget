[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![nuget-url][nuget-url]][nuget-url]

## Dotnet-nuget

This project has as the main goal to show how to create project using .net core 6, pack and publish it on https://www.nuget.org/

## Packing the project

```
dotnet pack .\PubDev.Nuget.HttpMiddleware.csproj --configuration Release -p:Version=[VERSION]
```

## Installing package on your project

```
Install-Package PubDev.HttpMiddleware
```

## Use the package

```csharp
var app = builder.Build();
...
app.UsePubDev();
...
```

## Package Link on nuget

- https://www.nuget.org/packages/PubDev.HttpMiddleware/

## References

- https://docs.microsoft.com/en-us/nuget/reference/msbuild-targets#pack-target

<!-- CONTACT -->
## Contact

- Humberto Rodrigues - [@1bberto](https://instagram.com/1bberto) - humberto_henrique1@live.com
- Rafael Nagai - [@rafakenji23](https://instagram.com/rafakenji23) - rafakenji23@gmail.com

- Discord Server - https://discord.com/invite/EvD6Um5Jw2

- Project Link: https://github.com/Pub-Dev/Dotnet-nuget
- 📽 YouTube Video: https://youtu.be/0uu3l9Ln-b0

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/Pub-Dev/Dotnet-nuget.svg?style=for-the-badge
[contributors-url]: https://github.com/Pub-Dev/Dotnet-nuget/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Pub-Dev/Dotnet-nuget.svg?style=for-the-badge
[forks-url]: https://github.com/Pub-Dev/Dotnet-nuget/network/members
[stars-shield]: https://img.shields.io/github/stars/Pub-Dev/Dotnet-nuget.svg?style=for-the-badge
[stars-url]: https://github.com/Pub-Dev/Dotnet-nuget/stargazers
[issues-shield]: https://img.shields.io/github/issues/Pub-Dev/Dotnet-nuget.svg?style=for-the-badge
[issues-url]: https://github.com/Pub-Dev/Dotnet-nuget/issues
[nuget-url]: https://img.shields.io/nuget/v/PubDev.HttpMiddleware?style=for-the-badge

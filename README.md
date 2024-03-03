<h1 align="center">Jellyfin DuplicateFinder Plugin</h1>

<p align="center">
<img alt="Plugin Banner" src="https://git.madcreativestudios.com/Francesco.Maddaloni/DuplicateFinder/raw/commit/98f81b3a5c4d3d41e1a94e606906ae2d7fc741d2/jellyfin-plugin-duplicatefinder.png"/>
<br/>
<br/>
<h3 align="center">Based on <a href="https://github.com/jellyfin/jellyfin-plugin-reports">Jellyfin Reports Plugin</a></h3>
<div align="center"> 
<a href="https://github.com/jellyfin/jellyfin-plugin-reports">
<img alt="MIT License" src="https://img.shields.io/github/license/jellyfin/jellyfin-plugin-reports.svg"/>
</a>
</div>
</p>

## About

This plugin generates reports about the Duplicated Movies in your library.

These reports can be exported to Excel and CSV formats.

## Installation

[See the official documentation for install instructions](https://jellyfin.org/docs/general/server/plugins/index.html#installing).

## Build

1. To build this plugin you will need [.Net 5.x](https://dotnet.microsoft.com/download/dotnet/5.0).

2. Build plugin with following command
  ```
  dotnet publish --configuration Release --output bin
  ```

3. Place the dll-file in the `plugins/DuplicateFinder` folder (you might need to create the folders) of your JF install

## Licence

This plugins code and packages are distributed under the MIT License. See [LICENSE](./LICENSE) for more information.

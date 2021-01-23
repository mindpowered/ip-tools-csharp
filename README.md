
iptools
=======

Contents
========

* [Source Code and Documentation](#source-code-and-documentation)
* [Licensing](#licensing)
* [Requirements](#requirements)
* [Installation](#installation)
* [Usage](#usage)
* [Support](#support)

# Source Code and Documentation
- Source Code: [https://github.com/mindpowered/ip-tools-csharp](https://github.com/mindpowered/ip-tools-csharp)
- Documentation: [https://mindpowered.github.io/ip-tools-csharp](https://mindpowered.github.io/ip-tools-csharp)

# Licensing
This package is dual-licensed under the MIT and CPAL-1.0 licenses.

To obtain a version licensed under the MIT License, follow the instructions at [get a license][purchase].

# Requirements
## To import pre-compiled library
- nuget

## To build from source
- Visual Studio Build Tools
- Haxe 4.1.1
- Neko
- hxcs Haxelib
- nuget


Third-party dependencies may have additional requirements.

# Installation
## NuGet

nuget ...

## MSBuild

Add the following entry to your .csproj file:

```
<PackageReference Include="mindpowered.iptools" Version="0.0.13" />
```


# Usage

```csharp
global::mindpowered.iptools.IPTools ipt = new global::mindpowered.iptools.IPTools();
string decimal = ipt.IPToDecimal("192.168.1.1");

```


# Support
We are here to support using this package. If it doesn't do what you're looking for, isn't working, or you just need help, please [Contact us][contact].

There is also a public [Issue Tracker][bugs] available for this package.



[bugs]: https://github.com/mindpowered/ip-tools-csharp/issues
[contact]: https://mindpowered.dev/support.html?ref=ip-tools-csharp/
[docs]: https://mindpowered.github.io/ip-tools-csharp/
[licensing]: https://mindpowered.dev/?ref=ip-tools-csharp
[purchase]: https://mindpowered.dev/purchase/ip-tools-csharp

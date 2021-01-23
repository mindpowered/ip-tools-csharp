
iptools
=======
Tools for working with IP4/IP6 Addresses including IPv4, IPv6, CIDR, and Subnet Masks

![Build Status](https://mindpowered.dev/assets/images/github-badges/build-passing.svg)

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
To obtain a version of this package under the MIT License, follow the instructions to [get a license][purchase]. The MIT License has no restrictions on commercial use and permits reuse within proprietary software.

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
<PackageReference Include="mindpowered.iptools" Version="0.0.15" />
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
[purchase]: https://mindpowered.dev/purchase/

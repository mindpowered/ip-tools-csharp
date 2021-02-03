
iptools
=======
Tools for working with IP4/IP6 IP Addresses including IPv4, IPv6, CIDR, and Subnet Masks

![Build Status](https://mindpowered.dev/assets/images/github-badges/build-passing.svg)

Contents
========

* [Source Code and Documentation](#source-code-and-documentation)
* [About](#about)
* [Requirements](#requirements)
* [Installation](#installation)
* [Usage](#usage)
* [Support](#support)
* [Licensing](#licensing)

# Source Code and Documentation
- Source Code: [https://github.com/mindpowered/ip-tools-csharp](https://github.com/mindpowered/ip-tools-csharp)
- Documentation: [https://mindpowered.github.io/ip-tools-csharp](https://mindpowered.github.io/ip-tools-csharp)

# About
IPv4 uses a 32-bit address for its Internet addresses. All IPv4 addresses are now assigned. IPv6 utilizes 128-bit Internet addresses so there are 1028 times more addresses. Mappings exist for converting from an IPv4 address to an IPv6 addresses. This allows interoperability.

An IP address consists of octets delimited by dots (".") for IPv4 or colons (":") for IPv6. We can compress IPv6 addresses by removing extra zeros to make the address shorter. Computers store IP addresses as their corresponding integer values. The number represented by this integer is its decimal representation.

Subnetting is the process of dividing a network into smaller network sections. A part of the IP address is *masked* off to define a network. The remaining part of the address identifies a device on the network. CIDR is an alternative way of representing a subnet mask and IP address range.

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

## MSBuild

Add the following entry to your .csproj file:

```
<PackageReference Include="mindpowered.iptools" Version="0.0.17" />
```


# Usage

```csharp
global::mindpowered.iptools.IPTools ipt = new global::mindpowered.iptools.IPTools();
string decimal = ipt.IPToDecimal("192.168.1.1");

```


# Support
We are here to support using this package. If it doesn't do what you're looking for, isn't working, or you just need help, please [Contact us][contact].

There is also a public [Issue Tracker][bugs] available for this package.

# Licensing
This package is released under the MIT License.



[bugs]: https://github.com/mindpowered/ip-tools-csharp/issues
[contact]: https://mindpowered.dev/support/?ref=ip-tools-csharp/
[docs]: https://mindpowered.github.io/ip-tools-csharp/
[licensing]: https://mindpowered.dev/?ref=ip-tools-csharp
[purchase]: https://mindpowered.dev/purchase/

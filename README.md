# IAU.Constellations
A cross platform .NET library to work with IAU constellations

NuGet package
============
A [NuGet pacakge](https://www.myget.org/feed/laheller/package/nuget/IAU.Constellations) for easier integration of the library in the project is available.

Features
========
- Static methods and data, no need to instantiate classes
- All 88 IAU constellation boundary data as polygon points in both polar and XY coordinate format
- Constellation boundary independent line/arc segment data to prevent drawing twice the same line/arc
- Method to locate a constellation based on J2000 equatorial coordinate 

Build
=====
- Install Visual Studio 2017 Community Edition or newer
- Open solution file: Constellations.sln
- Build

Test
====
- Run Demo2D application to explore library feautres

Use
===
- Reference the library in your Windows, Xamarin or Linux/Mono project
- Use the static methods and data

Credits
=======
- International Astronomical Union (IAU),
http://iau.org/
- Constellation Boundaries data by Pierre Barbier,
http://pbarbier.com/constellations/boundaries.html

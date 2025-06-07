# Custom FluentUI Components
- This is a collection of custom FluentUI components and helper classes that I have created for my projects. 
- A demo of this and some of my other NuGet packages can be found [here](https://github.com/marqdouj/BlazorSandbox/).

# WARNING
This package is going to be depreciated and no longer maintained. 
Please update your projects to use one of the packages mentioned in the announcement below.

# ANNOUNCEMENT
- The ***CircleImage*** and ***SlideShow*** components do not require the FluentUI. 
  - These components have been added to the [Marqdouj.HtmlComponents](https://www.nuget.org/packages/Marqdouj.HtmlComponents/) NuGet package.
  - That package supports .NET 8.0 and does not include the Fluent UI packages.

- The ***Theme*** and ***ColorPicker*** components require the FluentUI. 
  - These components have been added to the [Marqdouj.HtmlComponents.FluentUI](https://www.nuget.org/packages/Marqdouj.HtmlComponents.FluentUI/) NuGet package.
  - That package supports .NET 8.0.


## NuGet Package
- https://www.nuget.org/packages/Marqdouj.FluentUI/

## Components
- **CircleImage** A custom component for displaying an image(photo) in a circle (i.e. Avatar).
- **ColorPicker** A custom component for selecting an HTML Color Name
  - see my [HTML Common](https://github.com/marqdouj/HTMLCommon) NuGet package.
- **SlideShow**: A custom component for displaying a list of images (i.e. Banner/Carousel).
- [**ThemeSwitch**](https://www.fluentui-blazor.net/DesignTheme): A custom component for toggling between light and dark themes.
- [**ThemeMode**](https://www.fluentui-blazor.net/DesignTheme): A custom component for selecting between system, light, and dark themes.
- [**ThemeColor**](https://www.fluentui-blazor.net/DesignTheme): A custom component for selecting theme color.

## Release Notes
**10.0.0-preview4.5**
- Added `WARNING` message to ReadMe

**10.0.0-preview4.3**
- Added `ANNOUNCEMENT` message to ReadMe

**10.0.0-preview4.2**
- Added `CircleImage` component

**10.0.0-preview4.1**
- Added `ColorPicker` component

**10.0.0-preview4**
- Upgrade to .NET 10 Preview 4
- Upgrade to Fluent UI 4.11.9

**10.0.0-preview3**
- Upgrade to .NET 10 Preview 3
- ThemeColor/ThemeMode: added checks to help prevent flicker before theme is applied

**9.1.0**
- Added ThemeColor component
- Added ThemeMode component
- Converted ThemeSwitch Appearance and Icon to Parameters

**9.0.4**
- Upgrade to Fluent UI 4.11.8
- Converted Theme properties StorageName and Title to Parameters

**9.0.3**
- Upgrade to Fluent UI 4.11.7

**9.0.2**
- Update NuGet packages

**9.0.1**
- Added NuGet pkg icon

**9.0.0 - Initial release

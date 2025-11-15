# AspNetCore.Components.WebView.Gtk

[![NuGet Version](https://img.shields.io/nuget/v/Yu-Core.AspNetCore.Components.WebView.Gtk.svg)](https://www.nuget.org/packages/Yu-Core.AspNetCore.Components.WebView.Gtk/) ![License](https://img.shields.io/badge/License-MIT-blue.svg)

AspNetCore.Components.WebView.Gtk is a library for building native clients using Blazor and WebView. It provides a BlazorWebView Widget for running the blazor hybird application on Linux. Use GTK and WebKitGTK, bound by [Gir.Core](https://github.com/gircore/gir.core)

## Start
Reference [Yu-Core.AspNetCore.Components.WebView.Gtk](https://www.nuget.org/packages/Yu-Core.AspNetCore.Components.WebView.Gtk)

```
<PackageReference Include="Yu-Core.AspNetCore.Components.WebView.Gtk" Version="*" />
```

Install `libwebkitgtk-6.0-4`

```bash
sudo apt update
sudo apt install libwebkitgtk-6.0-4
```

See [sample](src/BlazorWebView/sample)

## NOTE
- Only Support Linux platform
- Similarities and differences with WinForms/WPF BlazorWebView
    - Similarities

        UrlLoading, StartPath, BlazorWebViewInitializing, BlazorWebViewInitialized
    - Differences

        Cannot use Webview2 API, should consult WebKitGtk

## Dependencies
- [GirCore.Gtk-4.0](https://www.nuget.org/packages/GirCore.Gtk-4.0)
- [GirCore.WebKit-6.0](https://www.nuget.org/packages/GirCore.WebKit-6.0)
- [Microsoft.AspNetCore.Components.WebView](https://www.nuget.org/packages/Microsoft.AspNetCore.Components.WebView)

## Thanks
- [.NET MAUI](https://github.com/dotnet/maui)
- [ASP.NET Core](https://github.com/dotnet/aspnetcore)
- [DevToys](https://github.com/DevToys-app/DevToys)
- [Gir.Core](https://github.com/gircore/gir.core)
- [maui-linux](https://github.com/jsuarezruiz/maui-linux)
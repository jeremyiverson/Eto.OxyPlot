:set echo off

nuget pack ../Source/Eto.OxyPlot/Eto.OxyPlot.csproj -Prop Configuration=Release
nuget pack ../Source/Eto.OxyPlot.Wpf/Eto.OxyPlot.Wpf.csproj -Prop Configuration=Release
nuget pack ../Source/Eto.OxyPlot.Gtk/Eto.OxyPlot.Gtk.csproj -Prop Configuration=Release
nuget pack ../Source/Eto.OxyPlot.MonoMac/Eto.OxyPlot.MonoMac.csproj -Prop Configuration=Release
nuget push *.nupkg
del *.nupkg

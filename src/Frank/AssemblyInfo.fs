﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Frank")>]
[<assembly: AssemblyProductAttribute("Frank")>]
[<assembly: AssemblyDescriptionAttribute("A functional web application DSL for ASP.NET Web API.")>]
[<assembly: AssemblyVersionAttribute("2.0.2")>]
[<assembly: AssemblyFileVersionAttribute("2.0.2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "2.0.2"

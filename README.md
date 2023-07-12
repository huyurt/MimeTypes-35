# MimeTypes35

Provides mapping of file extensions to mime types and mime types to file extensions.



## Installation

A NuGet package is available for easy integration into VisualStudio and automatic updates. Alternatively, you can clone and reference or copy the class to your project.

```bash
Install-Package MimeTypes35
```

## Support Platform

Support .NET Framework 3.5 and above

## Usage

```cs
using MimeTypes35;
Console.WriteLine(MimeTypeMap.GetMimeType(".doc")); // "application/msword"
Console.WriteLine(MimeTypeMap.GetMimeType("docx")); // "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
Console.WriteLine(MimeTypeMap.GetMimeType("file.xls")); // "application/vnd.ms-excel"
```


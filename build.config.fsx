// --------------------------------------------------------------------------------------
// START TODO: Provide project-specific details below
// --------------------------------------------------------------------------------------

// Information about the project are used
//  - for version and project name in generated AssemblyInfo file
//  - by the generated NuGet package
//  - to run tests and to publish documentation on GitHub gh-pages
//  - for documentation, you also need to edit info in "docs/tools/generate.fsx"

// The name of the project
// (used by attributes in AssemblyInfo, name of a NuGet package and directory in 'src')
let project = "##ProjectName##"

// Short summary of the project
// (used as description in AssemblyInfo and as a short summary for NuGet package)
let summary = "##Summary##"

// Longer description of the project
// (used as a description for NuGet package; line breaks are automatically cleaned up)
let description = "##Description##"

// List of author names (for NuGet package)
let authors = [ "##Author##" ]

// Tags for your project (for NuGet package)
let tags = "##Tags##"

// File system information 
let solutionFile  = "##ProjectName##.sln"

// Pattern specifying assemblies to be tested using NUnit
let testAssemblies = "tests/**/bin/Release/*Tests*.dll"

// Git configuration (used for publishing documentation in gh-pages branch)
// The profile where the project is posted
let gitOwner = "##GitHome##" 
let gitHome = "https://github.com/" + gitOwner

// The name of the project on GitHub
let gitName = "##GitName##"

// The url for the raw files hosted
let gitRaw = environVarOrDefault "gitRaw" "https://raw.github.com/##GitHome##"

// --------------------------------------------------------------------------------------
// END TODO: The rest of the file includes standard build steps
// --------------------------------------------------------------------------------------
// include Fake lib
#r @"../packages/FAKE.4.8.0/tools/FakeLib.dll"
open Fake

let buildDir = "./_build/"
let baseDir = "./"
let name = "TestFake"

Target "Default" (fun _ ->
    trace "Hello World from FAKE"
)

Target "Clean" (fun _ ->
    CleanDir buildDir
)

Target "Build" (fun _ ->
    !! "TestFake.*/**/*.csproj"
      |> MSBuildRelease buildDir "Build"
      |> Log "AppBuild-Output: "
)

Target "QuietBuild" (fun _ ->
    !! "TestFake.*/**/*.csproj"
      |> MSBuildRelease buildDir "Build"
      |> Log "AppBuild-Quiet-Output: "
)

// dependancies
"Clean"
 ==> "Default"
 ==> "Build"

"Clean"
 ==> "Default"
 ==> "QuietBuild"


let loggerConfig : list<MSBuildFileLoggerConfig> = [
  {
    Number = 1
    Filename = Some (baseDir + name + "_build.log")
    Verbosity = Some MSBuildVerbosity.Minimal
    Parameters = Some [MSBuildLogParameter.Append]
  }
]

let buildMode = getBuildParamOrDefault "buildMode" "Release"

let setParams defaults =
    { defaults with
        Verbosity = Some MSBuildVerbosity.Quiet
        Targets = ["Build"]
        MaxCpuCount = Some (Some 4)
        FileLoggers = Some loggerConfig
        ToolsVersion = Some "12.0"
        Properties =
          [
            "Optimize", "True"
            "DebugSymbols", "True"
            "Configuration", buildMode
          ]
     }

//let setParams defaults =
//        { defaults with
//            Verbosity = Some(Quiet)
//            Targets = ["Build"]
//            Properties =
//                [
//                    "Optimize", "True"
//                    "DebugSymbols", "True"
//                    "Configuration", buildMode
//                ]
//         }

build setParams "./TestFake.sln"
      |> DoNothing

RunTargetOrDefault "QuietBuild"

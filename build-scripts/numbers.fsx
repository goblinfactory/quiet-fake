// include Fake lib
#r @"../packages/FAKE.4.8.0/tools/FakeLib.dll"
open Fake

printfn ""
printfn "NUMBERS.FSX"
printfn "==========="
printfn ""


let buildDir = "./_build/"
let baseDir = "./"
let name = "Numbers"

Target "Default" (fun _ ->
    printfn "Let's do some numbers"
)

Target "Clean" (fun _ ->
    CleanDir buildDir
)

Target "A1" (fun _ ->
    ()
)

Target "A2" (fun _ ->
    ()
)

Target "A3" (fun _ ->
    ()
)

Target "A4" (fun _ ->
    ()
)

Target "A5" (fun _ ->
    ()
)

Target "A6" (fun _ ->
    ()
)

Target "A7" (fun _ ->
    ()
)

Target "A8" (fun _ ->
    ()
)

Target "A9" (fun _ ->
    ()
)


Target "A10" (fun _ ->
    ()
)

Target "Even" (fun _ ->
    printfn "Even numbers finished!"
)

Target "Odd" (fun _ ->
    printfn "Odd numbers finished!"
)

Target "Some" (fun _ ->
    printfn "Some numbers finished!"
)

Target "Build" (fun _ ->
    !! "/**/*.csproj"
      |> MSBuildRelease buildDir "Build"
      |> Log "AppBuild-Output: "
)

// dependancies
"Clean"
  ==> "A2"
  ==> "A4"
  ==> "A6"
  ==> "A8"
  ==> "A10"
  ==> "Even"

"Clean"
  ==> "A1"
  ==> "A3"
  ==> "A5"
  ==> "A7"
  ==> "A9"
  ==> "Odd"


"Clean"
  ==> "A5"
  ==> "A6"
  ==> "Some"

RunTargetOrDefault "Even"


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

let A1 =
    printfn "one"
    ()

let A2 = 
    printfn "two"
    ()

let A3 = 
    printfn "three"
    ()

let A4 = 
    printfn "four"
    ()

let A5 = 
    printfn "five"
    ()

let A6 = 
    printfn "six"
    ()

let A7 = 
    printfn "seven"
    ()

let A8 =
    printfn "eight"
    ()

let A9 = 
    printfn "nine"
    ()

let A10 =
    printfn "ten"
    ()

Target "Even" (fun _ ->
    A2
    A4
    A6
    A8
    A10
)

Target "Odd" (fun _ ->
    A1
    A3
    A5
    A7
    A9
)

Target "Some" (fun _ ->
    A1
    A6
    A7
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
  ==> "Even"
  ==> "EvenBuild"

"Clean"
  ==> "Odd"
  ==> "OddBuild"

"Clean"
  ==> "Some"
  ==> "SomeBuild"

RunTargetOrDefault "EvenBuild"


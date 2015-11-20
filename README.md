# quiet-fake
My experiment to get a human readable build logfile showing only results or errors. Really rough spike. I hope that this can be used as a easy to clone spike to test other options. 

###Usage:
```
$ git clone https://github.com/goblinfactory/quiet-fake.git
$ qbuild.bat
```
Decent 'human readable' logfile is created in ``Testfake_build.log`` e.g.
```
  TestFake.Lib -> D:\spikes\TestFake\TestFake.Lib\bin\Release\TestFake.Lib.dll
Program.cs(17,6): error CS1513: } expected [D:\spikes\TestFake\TestFake.Console\TestFake.Console.csproj]
  TestFake.Lib.Tests -> D:\spikes\TestFake\TestFake.Lib.Test\bin\Release\TestFake.Lib.Test.dll
  TestFake.Lib -> D:\spikes\TestFake\TestFake.Lib\bin\Release\TestFake.Lib.dll
Program.cs(17,6): error CS1513: } expected [D:\spikes\TestFake\TestFake.Console\TestFake.Console.csproj]
  TestFake.Lib.Tests -> D:\spikes\TestFake\TestFake.Lib.Test\bin\Release\TestFake.Lib.Test.dll
  TestFake.Lib -> D:\spikes\TestFake\TestFake.Lib\bin\Release\TestFake.Lib.dll
  TestFake.Console -> D:\spikes\TestFake\TestFake.Console\bin\Release\TestFake.Console.exe
  TestFake.Lib.Tests -> D:\spikes\TestFake\TestFake.Lib.Test\bin\Release\TestFake.Lib.Test.dll
  TestFake.Lib -> D:\git-alan\quiet-fake\TestFake.Lib\bin\Release\TestFake.Lib.dll
  TestFake.Console -> D:\git-alan\quiet-fake\TestFake.Console\bin\Release\TestFake.Console.exe
  TestFake.Lib.Tests -> D:\git-alan\quiet-fake\TestFake.Lib.Test\bin\Release\TestFake.Lib.Test.dll
  TestFake.Lib -> D:\git-alan\quiet-fake\TestFake.Lib\bin\Release\TestFake.Lib.dll
  TestFake.Console -> D:\git-alan\quiet-fake\TestFake.Console\bin\Release\TestFake.Console.exe
  TestFake.Lib.Tests -> D:\git-alan\quiet-fake\TestFake.Lib.Test\bin\Release\TestFake.Lib.Test.dll
```
##References
- http://fsharp.github.io/FAKE/apidocs/fake-msbuildhelper.html
- http://stackoverflow.com/questions/27384227/easiest-way-to-set-msbuild-logging-verbosity-in-fake
- http://fsharp.github.io/FAKE/
- http://fsharp.github.io/FAKE/gettingstarted.html

###TODO
Still need to update the test fsk make files to do full builds with some options, e.g. dev build (only unit tests) and 'CI' build running slower tests, with suitable 'easy to read' console output as well as logfiles.

# quiet-fake
Rough spike to get a more readable build logfile showing only results or errors. I hope that this can be used as an easy to clone spike to test other options, ideally a mix between the decent parts of the build output, timings etc, together with the brevity of the shorter output. (will look at that shortly.)

What I'm busy with at the moment:
- post build log formatting. Possibly use some form of log template fomatter, RazorLogs lol! The output below is not a huge improvement; I want to make it much better.
- Test to make sure when complex builds fail, that the build fails fast. 
- Test getting quicker (formatted [ with a format string ] ) after each project is built.
 
###Usage:
```
$ git clone https://github.com/goblinfactory/quiet-fake.git
$ qbuild.bat
```
Decent 'human readable' logfile is created in ``Testfake_build.log`` e.g. below is the whole 'minimal' logfile that gets created for the checked in project as it is. It's checked in with a '}' commented out so the build will fail. This is  opposed to the many reams (pages) of verbose output you get by default, that no human can read on anything other than the most basic multi-project solutions.

###Rationale
If the build runs locally on your machine, you want to be able to instantly spot the error. 99% of the time, provided you are doing decent agile development with resonable acceptance tests, all you need is the simplest smallest error message and you know immediately what you did wrong. This project is about shortening the feedback cycle and making the build test an important development tool.

###Sample compile error fake build output (draft 1, shortened)
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

###Desired Build Error output
```
Building projects; 
 - TestFake.Lib (ERROR)
 - TestFake.Lib.Tests
 - TestFake.Console

 TestFake.Lib (ERROR)
 ---------------------
   Program.cs(17,6): error CS1513:  } expected 
   
```


###Sample succesful compile output (draft 1, shortened)
```

  TestFake.Lib -> D:\git-alan\quiet-fake\TestFake.Lib\bin\Release\TestFake.Lib.dll
  TestFake.Console -> D:\git-alan\quiet-fake\TestFake.Console\bin\Release\TestFake.Console.exe
  TestFake.Lib.Tests -> D:\git-alan\quiet-fake\TestFake.Lib.Test\bin\Release\TestFake.Lib.Test.dll
  TestFake.Lib -> D:\git-alan\quiet-fake\TestFake.Lib\bin\Release\TestFake.Lib.dll
  TestFake.Console -> D:\git-alan\quiet-fake\TestFake.Console\bin\Release\TestFake.Console.exe
  TestFake.Lib.Tests -> D:\git-alan\quiet-fake\TestFake.Lib.Test\bin\Release\TestFake.Lib.Test.dll
  TestFake.Lib -> D:\git-alan\quiet-fake\TestFake.Lib\bin\Release\TestFake.Lib.dll
  TestFake.Console -> D:\git-alan\quiet-fake\TestFake.Console\bin\Release\TestFake.Console.exe
  TestFake.Lib.Tests -> D:\git-alan\quiet-fake\TestFake.Lib.Test\bin\Release\TestFake.Lib.Test.dll
  TestFake.Lib -> D:\git-alan\quiet-fake\TestFake.Lib\bin\Release\TestFake.Lib.dll
  TestFake.Console -> D:\git-alan\quiet-fake\TestFake.Console\bin\Release\TestFake.Console.exe
  TestFake.Lib.Tests -> D:\git-alan\quiet-fake\TestFake.Lib.Test\bin\Release\TestFake.Lib.Test.dll
  TestFake.Lib -> D:\git-alan\quiet-fake\TestFake.Lib\bin\Release\TestFake.Lib.dll
  TestFake.Console -> D:\git-alan\quiet-fake\TestFake.Console\bin\Release\TestFake.Console.exe
  TestFake.Lib.Tests -> D:\git-alan\quiet-fake\TestFake.Lib.Test\bin\Release\TestFake.Lib.Test.dll
  TestFake.Lib -> D:\git-alan\quiet-fake\TestFake.Lib\bin\Release\TestFake.Lib.dll
  TestFake.Console -> D:\git-alan\quiet-fake\TestFake.Console\bin\Release\TestFake.Console.exe
  TestFake.Lib.Tests -> D:\git-alan\quiet-fake\TestFake.Lib.Test\bin\Release\TestFake.Lib.Test.dll
  TestFake.Lib -> D:\git-alan\quiet-fake\TestFake.Lib\bin\Release\TestFake.Lib.dll
  TestFake.Console -> D:\git-alan\quiet-fake\TestFake.Console\bin\Release\TestFake.Console.exe
  TestFake.Lib.Tests -> D:\git-alan\quiet-fake\TestFake.Lib.Test\bin\Release\TestFake.Lib.Test.dll
  TestFake.Lib -> D:\git-alan\quiet-fake\TestFake.Lib\bin\Release\TestFake.Lib.dll
  TestFake.Console -> D:\git-alan\quiet-fake\TestFake.Console\bin\Release\TestFake.Console.exe
  TestFake.Lib.Tests -> D:\git-alan\quiet-fake\TestFake.Lib.Test\bin\Release\TestFake.Lib.Test.dll
  TestFake.Lib -> D:\git-alan\quiet-fake\TestFake.Lib\bin\Release\TestFake.Lib.dll
  TestFake.Console -> D:\git-alan\quiet-fake\TestFake.Console\bin\Release\TestFake.Console.exe
  TestFake.Lib.Tests -> D:\git-alan\quiet-fake\TestFake.Lib.Test\bin\Release\TestFake.Lib.Test.dll
  TestFake.Lib -> D:\git-alan\quiet-fake\TestFake.Lib\bin\Release\TestFake.Lib.dll
  TestFake.Console -> D:\git-alan\quiet-fake\TestFake.Console\bin\Release\TestFake.Console.exe
  TestFake.Lib.Tests -> D:\git-alan\quiet-fake\TestFake.Lib.Test\bin\Release\TestFake.Lib.Test.dll

```

##Desired Succesful build output
```
PROJECT BUILDS; 
 - TestFake.Lib  (OK) 
 - TestFake.Lib.Tests (OK)
 - TestFake.Console (OK)
 All projects built.
```

###Sample log that Fake generates
For small projects, a human can read these, but for larger projects, this is unmanageable.
https://github.com/goblinfactory/quiet-fake/blob/master/standard-fake-build.log

##References
- http://fsharp.github.io/FAKE/apidocs/fake-msbuildhelper.html
- http://stackoverflow.com/questions/27384227/easiest-way-to-set-msbuild-logging-verbosity-in-fake
- http://fsharp.github.io/FAKE/
- http://fsharp.github.io/FAKE/gettingstarted.html
- http://dungpa.github.io/fsharp-cheatsheet/

###TODO
Still need to update the test fsx make files to do full builds with some options, e.g. dev build (only unit tests) and 'CI' build running slower tests, with suitable 'easy to read' console output as well as logfiles.

call packages\fake.4.8.0\tools\fake.exe build-scripts\build.fsx %1 > quiet.log
type TestFake_build.log

# Introduction
This is an introduction to GitHub Action focused on Continuous Integration or CI for building and unit testing .NET Web API.

# Steps
To run the demo, please follow the steps below.

1. [Fork](https://docs.github.com/en/get-started/quickstart/fork-a-repo) this git repo.
2. In your forked repo, go to settings, then Actions on the left blade, scroll down to the bottom and under Workflow permissions check the read and write permissions option.
3. Clone a local copy
4. Do a local test by running ```dotnet test``` in the MyWebApiTest directory. There should be all successful tests as seen in the example output below.
```
PS C:\dev\intro-to-github-action-continuous-integration\MyWebApiTest> dotnet test
  Determining projects to restore...
  All projects are up-to-date for restore.
  MyWebApi -> C:\dev\intro-to-github-action-continuous-integration\MyWebApi\bin\Debug\net6.0\MyWebApi.dll
  MyWebApiTest -> C:\dev\intro-to-github-action-continuous-integration\MyWebApiTest\bin\Debug\net6.0\MyWebApiTest.dll
Test run for C:\dev\intro-to-github-action-continuous-integration\MyWebApiTest\bin\Debug\net6.0\MyWebApiTest.dll (.NETCoreApp,Version=v6.0)
Microsoft (R) Test Execution Command Line Tool Version 17.2.0 (x64)
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     5, Skipped:     0, Total:     5, Duration: 18 ms - MyWebApiTest.dll (net6.0)
```
5. Create a branch
6. Push your branch and the GitHub Action workflow will run. Check out Actions tab to see it in action.

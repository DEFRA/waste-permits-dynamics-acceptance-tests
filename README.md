# waste-permits-dynamics-acceptance-tests
C# and selenium based acceptance tests for the Waste permits digital service

## Pre-requisites

This project is setup to run using Visual Studio 2017


## Installation

First clone the repository and then drop into your new local repo

```bash
git clone https://github.com/DEFRA/waste-permits-dynamics-acceptance-tests.git && cd waste-permits-dynamics-acceptance-tests
```
or Use Team --> Manage connections from within Visual Studio (you'll need the github extension installed)

## Configuration
The test framework has been seperated into two distinct areas Automation and Test.

Automation holds an abstraction of the systen under test (SUT), primarily:

Page objects held in the Pages folder, holding methods to replicate the functionality of SUT.

Driver class (driver.cs) help in the Selenium folder, holding driver specific configuration including the base address,
implicit wait timeout and startup/tear down methods.

The test sections holds the acceptance tests in the the Tests folder.

BaseTest.cs holds the before and after logic that runs for all tests (login, sign out and close browser)






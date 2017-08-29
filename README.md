# waste-permits-dynamics-acceptance-tests
C# and selenium based acceptance tests for the Waste permits digital service

## Pre-requisites

This project is setup to run using Visual Studio 2017
Needs firefox browser


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

Driver class (driver.cs) held in the Selenium folder, holding driver specific configuration including the base address,
implicit wait timeout and startup/tear down methods.

The test sections holds the acceptance tests in the the Tests folder.

BaseTest.cs holds the before and after logic that runs for all tests (login, sign out and close browser)

app.config is used to store usernames and passwords
example_app.config is supplied in the code to give an example

## Contributing to this project

If you have an idea you'd like to contribute please log an issue.

All contributions should be submitted via a pull request.

## License

THIS INFORMATION IS LICENSED UNDER THE CONDITIONS OF THE OPEN GOVERNMENT LICENCE found at:

http://www.nationalarchives.gov.uk/doc/open-government-licence/version/3

The following attribution statement MUST be cited in your products and applications when using this information.

> Contains public sector information licensed under the Open Government license v3

### About the license

The Open Government Licence (OGL) was developed by the Controller of Her Majesty's Stationery Office (HMSO) to enable information providers in the public sector to license the use and re-use of their information under a common open licence.

It is designed to encourage use and re-use of information freely and flexibly, with only a few conditions.






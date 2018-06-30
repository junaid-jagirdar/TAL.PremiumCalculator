Things To Improve

1.Error handling and error logging:
  I wanted to implement error habdling through global error attribute and also log errors using a loggin framework called serilog.
2.The validation and showing error messages to users could have been improved.
3.The UX and UI could have been imporoved using libraries like bootstarp or material.js.
4.I wanted to include a few functional tests using specflow.
5.I haven't taken into account the security aspects of the application.
6.The ideal way to develop was to use expose the premium calculator through API.The business logic could have been used to any mobile app or any third party client.
7.I would like to setup the CI/CD pipeline using XL deploy.

Things I have done:

1.seprated the calcuation logic to a different class library.
2.Used rules pattern to implement the premium calculation logic so that it is easy to add new rules.
3.Used fluent assertions in unit testing.
4.Used structure map for dependency injection.
# Application Description
'ValidationProject' is a console application that is used in data validation purposes.
Target framework of the main project and the test project is .NET6.
Data that is unrelated to the codebase is located in the repository root folder.

# Regex Implementation Description
The implementation was designed to match a specific rules within a string. 
It was placed in the 'IsValid' method of 'StringValidator' class.
This method validates whether string contains at least one uppercase letter, 
one lowercase letter, one digit and one special character. Also, it checks whether 
the string contain any whitespaces or exceed the max length.
This implementation can be easily integrated into other projects by adding reference to 'ValidationProject'
and using the 'StringValidator' class.

# How to run the developed application locally
- Open the 'ValidationProject.sln' file with Visual Studio 2022.
- Build and run your app by pressing F5 or selecting the green arrow next to the 'ValidationProject' in the top toolbar.
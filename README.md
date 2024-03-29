# AssessmentTest

## To clone project from Github to local machine

Step 1: Open Visual Studio Code

Step 2: Open the folder where you want this project to be

Step 3: Open a new terminal

Step 4: Run the following command to clone the project:

&nbsp;&nbsp;&nbsp;&nbsp;git clone https://github.com/Jack-Code2024/AssessmentTest.git

Step 5: Run the following command to go to the project folder: 

&nbsp;&nbsp;&nbsp;&nbsp;cd AssessmentTest

Step 6: Run the following command to build all projects: 

&nbsp;&nbsp;&nbsp;&nbsp;dotnet build

Step 7: Run the following command to run the project

&nbsp;&nbsp;&nbsp;&nbsp;dotnet run --project .\ConvertTest\

Step 8: Point the cursor to this link in terminal: http://localhost:5174

Step 9: Press [Ctrl+Click]

#### How to use the page

- "Number to Text Convertor" page will pop-up after [Ctrl+Clik]
- We can now try entering number to the text box
- Click "Convert" button to convert the number to text
- We can also click on the copy icon to copy the text

## To run the unit test

Step 1: Open "AssessmentTest" folder with Visual Studio Code

Step 2: Open a new terminal

Step 3: Run the following command to go to UnitTest project: 

&nbsp;&nbsp;&nbsp;&nbsp;cd UnitTest

Step 4: Run the following command to run the unit test: 

&nbsp;&nbsp;&nbsp;&nbsp;dotnet run --project .

#### How to deploy UnitTest to other machine

- Since, we have already built the projects when cloning them from Github
- We can find the executable file in this path:
  {your loca path}\AssessmentTest\UnitTest\bin\Debug\net6.0
- Files inside this folder (i.e. \AssessmentTest\UnitTest\bin\Debug\net6.0) are needed to run the unit test on other machine where .NET runtime is installed
- We can copy "net6.0" folder to the target machine and change it to an appropriate name (make sure .NET runtime is installed on the target machine)

## To deploy the web project

Step 1: Open "AssessmentTest" folder with Visual Studio Code

Step 2: Run the following command to go to ConvertTest project: 

&nbsp;&nbsp;&nbsp;&nbsp;cd ConvertTest

Step 3: Run the following command to build the project: 

&nbsp;&nbsp;&nbsp;&nbsp;dotnet build

Step 4: Run the following command to publish the project: 

&nbsp;&nbsp;&nbsp;&nbsp;dotnet publish -c Release

Note: The "publish" folder will be generated in the following disrectory after running the command:<br>
{your local path}\AssessmentTest\ConvertTest\bin\Release\net6.0\publish
		
Step 5: Copy "publish" folder to the target environment

&nbsp;&nbsp;&nbsp;&nbsp;Note: For example, copy the "publish" folder to C drive on the target environment

Step 6: Open PowerShell or Command Prompt in the target environment

Step 7: Run the following command to go to publish folder: 

&nbsp;&nbsp;&nbsp;&nbsp;cd c:\publish

Step 8: Run the following command to run the web server: 

&nbsp;&nbsp;&nbsp;&nbsp;dotnet ConvertTest.dll

&nbsp;&nbsp;&nbsp;&nbsp;Note: We have two files to run the server:
- dotnet ConvertTest.dll - run this when .NET runtime is not available in the target environment<br>
- dotnet ConvertTest.exe - run this when .NET runtime is available in the target environment

Step 9: Point cursor to this link: https://localhost:5001

Step 10: Press [Ctrl+Click] to run the site

## Remarks

The approach I am using is very straight forward. It is quite easy to understand and maintain. Even junior can easily maintain it. This will reduce the maintain cost. If we do it with too many loops, too complex, to understand the looping will take some time. This makes the maintenance much more difficult. The approach I am using, I am very sure that the maximum of loop is five loops or lesser.

For the services, I split the ConvertService to another project because I want to call the functions in the UnitTest project. And also, we can change the service much more easier in the future if we do it in seperate project.

For the index.html, I put it in "wwwroot" because we can easily change to other technologies like React, Vue or Angular in the future. Another reason is that, if we have any changes in UI, we can update it without effect the dlls.

This is the simplest way I can think of. I wash I can make it more simpler.




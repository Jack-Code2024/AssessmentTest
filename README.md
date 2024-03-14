# AssessmentTest

## To clone project from Github to local machine

Step 1: Open Visual Studio Code

Step 2: Open the folder where you want this project to be

Step 3: Open a new terminal

Step 4: Type the following command to clone the project:

&nbsp;&nbsp;&nbsp;&nbsp;git clone https://github.com/Jack-Code2024/AssessmentTest.git

Step 5: Type the following command to go to the project folder: 

&nbsp;&nbsp;&nbsp;&nbsp;cd AssessmentTest

Step 6: Type the following command to build all projects: 

&nbsp;&nbsp;&nbsp;&nbsp;dotnet build

Step 7: Type the following command to run the project

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

Step 3: Type the following command to go to UnitTest project: 

&nbsp;&nbsp;&nbsp;&nbsp;cd UnitTest

Step 4: Type the following command to run the unit test: 

&nbsp;&nbsp;&nbsp;&nbsp;dotnet run --project .

#### How to deploy UnitTest to other machine

- Since, we have already built the projects when cloning them from Github
- We can find the executable file in this path:
  {your loca path}\AssessmentTest\UnitTest\bin\Debug\net6.0
- Files inside this folder (i.e. \AssessmentTest\UnitTest\bin\Debug\net6.0) are needed to run the unit test on other machine where .NET runtime is installed
- We can copy "net6.0" folder to the target machine and change it to an appropriate name (make sure .NET runtime is installed on the target machine)

## To deploy the web project

Step 1: Open "AssessmentTest" folder with Visual Studio Code

Step 2: Type the following command to go to ConvertTest project: 

&nbsp;&nbsp;&nbsp;&nbsp;cd ConvertTest

Step 3: Type the following command to build the project: 

&nbsp;&nbsp;&nbsp;&nbsp;dotnet build

Step 4: Type the following command to publish the project: 

&nbsp;&nbsp;&nbsp;&nbsp;dotnet publish -c Release

&nbsp;&nbsp;&nbsp;&nbsp;Note: The "publish" folder will be generated in the following disrectory after running the command:<br>
&nbsp;&nbsp;&nbsp;&nbsp;{your local path}\AssessmentTest\ConvertTest\bin\Release\net6.0\publish
		
Step 5: Copy "publish" folder to the target environment

&nbsp;&nbsp;&nbsp;&nbsp;Note: For example, copy the "publish" folder to C drive on the target environment

Step 6: Open PowerShell or Command Prompt in the target environment

Step 7: Type the following command to go to publish folder: 

&nbsp;&nbsp;&nbsp;&nbsp;cd c:\publish

Step 8: Type the following command to run the web server: 

&nbsp;&nbsp;&nbsp;&nbsp;dotnet ConvertTest.dll

&nbsp;&nbsp;&nbsp;&nbsp;Note: We have two files to run the server:
- dotnet ConvertTest.dll - run this when .NET runtime is not available in the target environment<br>
- dotnet ConvertTest.exe - run this when .NET runtime is available in the target environment

Step 9: Point cursor to this link: https://localhost:5001

Step 10: Press [Ctrl+Click] to run the site




# Pierre's Bakery II

#### A website for adding treats and flavors to a database so that Pierre knows what his customers are after. Add Flavors, add treats, create and see the associations between them. Unauthorized users may view the contents of the website however only logged in account holders may add, edit or delete entries.

## Authored by:
Hans Ellis January 2023

***

## Table of Contents
1. [Technologies Used](#technologies-used)
2. [Setup Instructions](#installation-and-setup)
4. [Known Bugs](#known-bugs)
5. [License Information](#license)


## Technologies Used

- C#
- .NET
- Bootstrap
- Git
- Github
- Markdown
- MySQL Workbench
- Razor
- Notepad
- VS Code


## Installation And Setup

### Installation Steps
1. To begin, the user must install a compatible version of .NET 6. An acceptable version can be found [here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
2. Follow the prompts throught the installation of the program. Using default settings as they originally appear in the setup.
3. In the terminal (ex: Git Bash) install dotnet-script by runing the following command
```bash
$ dotnet tool install -g dotnet-script
```
4. Configure your local environment to use this. Details for which can be found [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-dotnet-script).
5. Then, install MySQL. Follow further detailed instructions on accomplishing that [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

### Repository Setup
1. Clone this repository.
2. Open your shell (e.g. Terminal or GitBash) and navigate to this project's production directory called "FactoryRepair".
3. Within the FactoryRepair folder, create a file titled appsettings.json
4. Open your file editor and navigate to appsettings.json
5. In the appsettings.json file, paste the following code:
```javascript
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurant_list;uid=[uid];pwd=[pwd];"
  }
}
```
6. Replace [uid] and [pwd] with your created SQL username and password respectively (including the braces).

### Import the Database
1. Open MySQL Workbench and find the Navigator pane (with the screen full, it appears on the left hand side.)
2. Select "Data Import/Restore", which opens Data Import page.
3. Select the option labeled "Import from Self Contained File". Navigate to the top level of directory of files you downloaded from this repository ("RecipeBox.Solution").
4. Within "RecipeBox.Solution", select the file named recipe_box.sql.
5. Underneath "Default Schema to be Imported To", click the "New..." button, input the database name (recipe_box.sql), and click "OK".
6. Go to the "Start Import" button in the lower right corner of the Data Import Pane.
7. On the Navigator panel, select the "Schemas" tab. Click the "refresh" icon (two arrows arranged in a circle in the top right corner of the pane), and the database should appear.

### Execute the Program
1. Open the terminal and navigate to the production directory titled "RecipeBox.Solution."
2. Run `dotnet watch run` in the command line to start the project in development mode with a watcher.
3. Open the browser to _https://localhost:7121_. If you cannot access localhost:7121 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs
- Weird styling on Flavor and Treat index pages.


## License
*Hans Ellis, January 2023. Available for distribution, modification, inspection, and application under [GPLv3 License](https://www.gnu.org/licenses/gpl-3.0.en.html)*

This application makes previous work from the Epicodus staff as a reference for learning material. It has been used with permission of the staff.
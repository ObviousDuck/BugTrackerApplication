# BugTrackerApplication

Welcome to BugTracker.
BugTracker is a handy little application wherein users can log bugs and view these in detail, as well as add comments and alter source code.
This readme will hopefully answer any questions you may have about how to use it to its full extent. Please keep reading for a tutorial.

# 0. Database Files and Prerequisites.
Before you use the application you need to check that a few things are up and running. First off, make sure the BugTrackerDB.mdf file is established as a Data Connection in Visual Studio.

Also, this application needs an external library for it's colour syntax functions which can be found here:
https://colorcode.codeplex.com/

Please download this and create a Reference to the Project to ColorCode.dll.

# 1. Main Menu
On the main menu, you can press the menu buttons at the top to exit the application or to view some information about the app. The help page will send you to this GitHub page.

First you must select your role:
  # Tester
  - This role is purely for testing purposes, as such a Tester will not need to worry about the code itself when dealing with bugs.
  # Tester/Developer
  - This role shares all the features of the Tester, but has access to more advanced Report a Bug, as well as access to Find A Bug.

Clicking either button will display your current selected choice underneath.

# 2. Logging In
To access the Find a Bug feature, you must be logged in. Clicking Log In will open a new window prompting for a Username and Password. 
For testing purposes, please use:
Username: admin
Password: sa

This should prompt a messagebox saying you have been logged in successfully.

# 3. Register new user
This feature is only available to a user with admin right. The test user is set to be an admin so you can use this feature.

# 4. Report a bug
Clicking this will open one of two menus, depending on the choice of Tester or Tester/Developer. If no choice has been made, a message will pop up asking you to make a choice.

  # Tester Report Bug
  This is the simpler version of Reporting bugs. Here you are required to fill out the fields marked by a red asterisk, otherwise your     bug will not be logged. On sucessfully filling out the required field, a messagebox will pop up saying the bug has been successfully     logged. 
  # PLEASE NOTE: The Upload Attachment button works and a selection can be made, but nothing will be stored in the database. This is a     prototype feature only.
  
  # Tester/Developer Report Bug
  This is the advance version of Reporting Bugs. Here you are required to fill out the fields marked by a red asterisk, otherwise the     bug will not be logged. A Code Snippet can optionally be added here and viewed later, formatted correctly.
  The formatted code types supported are currently CSharp, Java and HTML.
  # PLEASE NOTE: The Upload Attachment button works and a selection can be made, but nothing will be stored in the database. This is a     prototype feature only.

# 5. Find a bug
This part of the BugTracker allows you to search for Bugs logged in the database. By clicking Search, you will get an unfiltered Search and as such you will be shown all non-archived entries currently in the database and vice versa.
By applying filters, it is possible to narrow down your search to these criteria.
The bugs searched for will appear in the list box to the right, where they will be displayed with the following parameters in the following order:

ID - Project Name - Summary

By clicking one of these and pressing the View Details button you will be able to view details about a particular bug.

# 5. View Bug Details
Here you will be shown all available details for a bug, including any source code if available. 
It is possible to add Comments which will be stored in a separate table. As soon as a new comment is added, the Comments box will update immediately with a timestamp of the Comment as well as the name of the current logged in user.

On the right side, underneath any source code, it is possible to select a language and click 'Format Code' to display the code snippet formatted. This will be shown in a separate window. Furthermore, this will be written to a file as shown by the messagebox that appears.

Changes can also be made to the code, and by clicking 'Save Changes' these will be saved to the database. 

Please note: Even if changing code here, clicing 'Format Code' will format  the code that is currently in the textbox. In other words, it is possible to add to existing code and view it formatted.

******************
Happy BugTracking!
******************

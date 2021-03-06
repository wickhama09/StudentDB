StudentDB
===

StudentDB is a Windows application I am developing that stores and retrieves student information using a local MSSQL database.
When this project is completed the user will be able to add/edit student information as well as add/view registered courses for each student.
Each student's GPA will be calculated by the grades received in their registered courses.


Selecting a student:  
![Nature](https://cloud.githubusercontent.com/assets/19334063/25262478/4a2b7d0a-2626-11e7-87c0-33d8fbb7018a.jpg)

Adding a student:  
![add](https://cloud.githubusercontent.com/assets/19334063/25262482/4e060e86-2626-11e7-93ad-d7ac8efdc7aa.jpg)

  
Features (completed)
---

- Search For Students by ID #
- Storing, Editing, & Retrieving Information 
    - ID #
    - Name
    - Address
    - Birthdate
    - Phone
- Storing & Retrieving Information
    - Courses
    - Grades
- Relational Data Tables
    - Student
    - Course
    - Subject
    - StudentCourse
- Event-Driven Textboxes
    - Example text is removed/returned to/from each textbox when necessary
    - Real-time string formatting for phone number
    - Instant rejection of non-numeric input for phone number, zip code, birthdate
    - Instant rejection of numeric input for state combo box
- Additional User Input Validation
    - Reject the user's entry if any fields are outside of the range of characters allowed within the database
    - Check for null values and handle them accordingly
    - Reject impossible date selection (including support for leap years)
    - Confirmation boxes before any database queries that would add/change information
    - Generate a realistic range of drop-down options for birthdate and term based on the current year
    
    
        
 Features (in development)
 ---
 
- Removing & Editing Data
  - Courses
  - Grades









Code
---

You can view the code I wrote for this application 
[here](https://github.com/wickhama09/StudentDB/blob/master/StudentDB/frmMain.cs).  


Thoughts
---

I chose to develop this application because I am graduating this year and will be pursuing a career in programming. Realizing that database programming is an essential skill for any business, I wanted to expand my knowledge. I also wanted to challenge myself to learn
a new language. With plenty of practice with C++ and Visual Basic, learning C# has been a lot easier than anticipated! Through this 
process I have reinforced my knowledge on relational data and how to implement it correctly in a programming environment.







Author
---

This Visual C# project was created by Anthony Wickham. The project is still in development as of April 20, 2017.


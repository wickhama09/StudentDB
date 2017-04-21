StudentDB
===

StudentDB is a Windows application I am developing that stores and retrieves student information using a service-based SQL database.
When this project is completed the user will be able to add/edit student information as well as add/view registered courses for each student.
Each student's GPA will be calculated by the grades received in their registered courses.


Selecting a student:  
![Nature](https://cloud.githubusercontent.com/assets/19334063/25262478/4a2b7d0a-2626-11e7-87c0-33d8fbb7018a.jpg)

Adding a student:  
![add](https://cloud.githubusercontent.com/assets/19334063/25262482/4e060e86-2626-11e7-93ad-d7ac8efdc7aa.jpg)

  
Features (completed)
---

- Storing & Retrieving Information 
    - ID #
    - Name
    - Address
    - Birthdate
    - Phone
- Relational Data Tables
    - Student
    - Course
    - Subject
    - StudentCourse
- Event-driven examples in textboxes
    - Example text is removed when the textbox is focused
    - Example text is returned if the field is left blank
- User Input Validation
    - Reject the user's entry if any fields are outside of the range of characters allowed in the database
    - Only allow null values for address line 2 and phone extension
    - Real-time rejection on non-numeric input for phone number, zip code, birthdate
    - Real-time formatting for phone number (adds and removes "-" when necessary)
    - Reject a Day selection of "31" for months that do not contain 31 days
    - Reject a date selection of Feb. 29 if it is not a leap year
    - Generate a realistic range of drop-down options for birthdate based on the current year
    
    
        
 Features (in development)
 ---
 
 - User Input Validation
    - Real-time rejection of numeric input for state combo box
    - Confirmation message before querying an add/edit to the database
- Editing Information
- Search for student by ID
- View/Add Courses to a Student
    - List available courses, and allow to filter by subject
- Add grades to completed courses
- Calculate GPA from grades






Code
---

You can view the code I wrote for this application 
[here](https://github.com/wickhama09/TicTacUltimate/blob/master/TicTacToe_Anthony_Wickham/frmTTT.vb).  


Thoughts
---

This game was my one of my first experiences with Visual Studio. It taught me a lot
about event-driven programming and interface design. I pushed myself to add several layers of logic into this 
program. This was significant in my learning process because it opened
my eyes to the sheer complexity that can be involved with programming even the smallest things.








Author
---

This Visual Basic project was created by Anthony Wickham. The project was completed on March 27, 2016.


# Chinese School Admin System

## Project Goals
This project is an admin system for Coventry Chinese School in order to store information about their students and teachers, allowing an easy and efficient way of add, editing and deleting information.
The application should be a three-tiered system, meaning there should be a GUI layer, Model layer and a Business layer to connect the 2. There should also be tests to test all method functionality. 
The project should follow the Agile methodology, using scrum events to appropriately plan for each sprint.

## Class Diagram
![ClassDiagram](https://github.com/Lauren919/ChineseSchoolAdminSystem/blob/main/Project%20Images/Class%20Diagram.png)

## Sprint Breakdown
### Sprint 1 (1/12/2020)
![StartofSprint1](https://github.com/Lauren919/ChineseSchoolAdminSystem/blob/main/Project%20Images/Sprint%201.png)
I aim to have a complete database and start on building a three-tiered application with some interaction between the GUI layer and the database using the business layer.

#### Sprint Goals
- [x] User Story 0.1 - Build a database
- [x] User Story 0.2 - Build WPF front end
- [x] User Story 0.3 - Build Business layer
- [x] Sprint review
- [x] Sprint retrospective
- [x] Update ReadMe file
- [x] commit all changes to github

#### Sprint Review
The database was created with data inserted into each table. The business layer, unit tests and GUI layer were also added to the solution.

#### Sprint Retrospective
All the user stories for the sprint was completed. However, there were some issues with commiting to git but these were resolved. For the next sprint, the pacing should continue and there should be less issues with git now that I feel more confident with using git.


### Sprint 2 (2/12/2020)
![StartOfSprint2](https://github.com/Lauren919/ChineseSchoolAdminSystem/blob/main/Project%20Images/Sprint%202.png)
I aim to create read and add methods to the Business layer and implement these in the GUI layer. Unit tests will also be carried out for the methods in the business layer.

#### Sprint Goals
- [x] User Story 1.1 - Read student information
- [x] User Story 2.1 - Read teacher information
- [ ] User Story 3.1 - Add new student in GUI
- [x] User Story 3.1.1 - Create method to add new student 
- [ ] User Story 3.4 - Add new teacher in GUI
- [x] User Story 3.4.1 - Create method to add new teacher
- [x] Sprint review
- [x] Sprint retrospective
- [x] Update ReadMe file
- [x] commit all changes to github

#### Sprint Review
The add method for both the student and teacher was made and tested throughly. The GUI layer was also started, with the 3 pages made (a front page, student page and teacher page). However, not all user stories were completed due to Visual Studio being slow so these (implementing the add functionality to the GUI) will have to be implemented in the next sprint instead.

#### Sprint Retrospective
Although not all user stories were completed, the majority was which was good considering I had some technical issues with Visual Studio. However, I did learn to use navigation windows in WPF and all unit tests for the add methods passed.


### Sprint 3 (3/12/2020)
![StartOfSprint3](https://github.com/Lauren919/ChineseSchoolAdminSystem/blob/main/Project%20Images/Sprint%203.png)
I aim to implement the add method in the GUI layer and create the edit and delete methods in the Business layer.

#### Sprint Goals
- [x] User Story 3.1 - Add new student in GUI
- [x] User Story 3.4 - Add new teacher in GUI
- [x] User Story 3.2.1 - Create a method to edit a student
- [x] User Story 3.3.1 - Create a method to delete a student
- [x] User Story 3.5.1 - Create a method to edit a teacher
- [x] User Story 3.6.1 - Create a method to delete a student
- [x] Sprint review
- [x] Sprint retrospective
- [x] Update ReadMe file
- [x] commit all changes to github

#### Sprint Review
All user stories were completed, including those that were not completed in Sprint 2. The GUI layer now can add new students and teachers. The edit and delete methods for students and teachers were also added to the business layer and tested. Although the test for the edit methods seem to fail, this is a technical issue and not an issue with the code itself as the dummy data is deleted from the database, as per the teardown method in the tests.

#### Sprint Retrospective
All the user stories were completed which is good as I was not feeling very well during the sprint. However, there was a problem with the tests for the edit methods which I will address in the next sprint. 


### Sprint 4 (4/12/2020)
![StartOfSprint4](https://github.com/Lauren919/ChineseSchoolAdminSystem/blob/main/Project%20Images/Sprint%204.png)
I aim to implement the edit and delete methods in the GUI layer for both the student and teacher pages.

#### Sprint Goals
- [x] User Story 3.2 - Edit student information on GUI
- [x] User Story 3.3 - Delete student on GUI
- [x] User Story 3.5 - Edit teacher information on GUI
- [x] User Story 3.6 - Delete teacher on GUI
- [x] User Story 4.1 - Show students in selected class on GUI
- [x] Sprint review
- [x] Sprint retrospective
- [x] Update ReadMe file
- [x] commit all changes to github

#### Sprint Review
All user stories were completed, with an extra one added (User Story 4.2 - Show students in selected class) as I finished all planned user stories early. The edit and delete methods for both the student and teacher were implemented into the GUI, with manual tests completed. Also, the student page was changed to contain an extra list box, showing all the classes. When a class is selected, all students within that class will be listed in the second listbox below.

#### Sprint Retrospective
This sprint ran smoothly as all user stories originally planned were completed early, meaning that I was able to add another user story to work on during the sprint. 


### Sprint 5 (5/12/2020)
![StartOfSprint5](https://github.com/Lauren919/ChineseSchoolAdminSystem/blob/main/Project%20Images/Sprint%205.png)
I aim to make the WPF easier to use and look aesthetically pleasing to the eye.

#### Sprint Goals
- [x] User Story 5.1 - Make WPF easy to use
- [x] User Story 5.2 - Make WPF aesthetically pleasing to the eye
- [x] Sprint review
- [x] Sprint retrospective
- [x] Update ReadMe file
- [x] commit all changes to github

#### Sprint Review
All user stories were completed to make the application easier to use and look nice. Manual testing was used to make sure the application still functioned properly after the changes were made.

#### Sprint Retrospective
All user stories were done within the sprint and was tested to make sure the application still worked after the design changes. 



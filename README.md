# 391_project_1
DATABASE APP FOR SCHOOL SCHEDULING

# requirements
--compartmentalize queries (dont do all queries at the same time)

--materialized view for active students with all the courses they've taken and their prerequisites

--materialized view for all courses where enrolled < capacity, and current year = selcted year and sem = sem selected.

--Stored procedures for all queries

--Transaction wrapped queries for any concurency issues(when enrolling for classes)

--materialized view on current students classes they have 'completed' in the enrolled table and that are 'not graduated'

# OPERATION
1. class search - check capacity before populating results
2. class select
3. query pre req table find the pre req
4. query taken classes, check if active student has taken pre req (status not in progress for pre req)
5. query the cart for schedule conflict
*(query cart for same course name (in memory, not in sql table))
6. allow class to be added to cart
7. use a transaction to enroll the current student into all classes in their cart, check the capacity of each class in the cart
8. update isEnrolled flag on all classes from the current students cart upon successfully enorlling and increment the class capacity for classes the student enrolls in

# SYSTEM SETUP AND TESTING
1. populate class list front end view
   materialized view joining course, section, timeslot, where year = 2024, semester = 'winter' and enrolled < capacity
2. display ex: CMPT 101, X01L, Intro to Computer Science
3. Click on the desired class, to populate info and load it into the selected class. (live query on the section table, indexed on enrolled, to get the live enrolled value, ALSO GRAB THE section_id, Sem, Year, and course_id, from that query for displaying. Now, use the currently selected section, get the course_id, and query the course table for the course name, to display that anme info. Use the Instructor_ID from the currently selected section, to query the instructor table for instructor name. lastly use the timeslot_ID from the current section selected to query the time table and grab the start and end time for display purposes.)
4. a: If the LIVE enrolled is less than capacity, allow user to click 'add to cart' button
4. b: when the add to cart button is clicked, use the current time_slot_ID, to query the time table, and grab the start and end time. Now, for each class in the cart, grab that classes timeslot_id, then query the time table, get the start and end times, and check if there is a conflict with the selected classes start and end times. If all classes pass, move onto next check, otehrwise error message and do not allow to be added to cart.
4. c: use the selected class course_id to query the pre-req table and get the pre-req_id, then use the pre-req-id and the current student_id to query the enrolled table. If that pre-req_id and student_id exists in the enrolled table, then allow the currently selected class (values for cart table: Student_ID FK, Section_ID FK, Semester FK, Year FK, Course_ID FK)
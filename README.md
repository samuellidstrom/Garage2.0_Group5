Exercise 12: Garage 2.0 - Part 1

The Garage goes online with ASP.NET MVC! Since this is the first MVC-based version of the garage, we will focus on the user interface and functionality. The task description is provided in order of priority. As this is your first group assignment, it's a good idea to start by planning what needs to be done and in what order. How will you divide the tasks? When does your group consider an implementation to be complete? Do you have a strategy for working with GitHub?

It's important, especially when working remotely, that you have good communication. You may want to establish your own guidelines for how to collaborate effectively.

Every morning, you should have a brief 15-minute meeting where each team member informs others about their progress. In turn, each member should answer the following questions:
What have you done since the last update?
What are your plans for the day?
Is there anything that is hindering your progress?

Single Model
In this version, we want to use a single model, which means not having a model for each type of vehicle as we did in the console version, but only one class - "ParkedVehicle" with properties that correspond to vehicle type, registration number, color, make, model, number of wheels, and arrival time.

Core Functionality

Vehicles should be able to be parked and retrieved.
Vehicles should be editable after being parked.
The arrival time of a vehicle should not be editable or manipulated.
When parking a vehicle, the user should be able to enter the vehicle's data.
There should be an overview view where all parked vehicles are displayed with basic data: Type, RegNo, Arrival Time, (Parked Time).
A detailed view for each vehicle showing all information, such as the number of wheels, make, color, and model.
The registration number should be unique.
When retrieving a vehicle, a receipt should be provided.
Bonus Task: Display how long the vehicle has been parked in the garage.

Appearance
The application should have a consistent, clear, and user-friendly appearance. Language and instructions should be adapted for use. For example, we are not creating a car; we are parking/checking in the car. We should not delete a car; we should retrieve/check out the car, and so on. You can choose to make the application in Swedish or English.

Input Control / Validation
Some inputs should not allow the user to type freely. For example, names should not be too long, and negative values for the number of wheels should not be allowed.

Vehicle Types
Vehicle type should not be entered manually; it should be available as a dropdown list containing valid vehicle types.

Overview View
This should be implemented with a ViewModel containing the data the view needs.

Timestamp
A timestamp for when the vehicle was parked (stored in the database along with other vehicle information) should not be entered manually but should be generated and saved automatically when the user checks in a vehicle.

Receipt
When checking out, some customers require a receipt to report how long they have parked. Implement a new view that displays vehicle information, RegNo, check-in/check-out times, total parking period, and price (automatically calculated) after a car is checked out. The receipt should use a ViewModel as a model. You can make the receipt printer-friendly. You can set your own price.

Filtering and Sorting
As the number of parked vehicles grows, the need for a search function increases. Implement a search feature for the registration number.

Bonus Task: If time allows, expand the search to other fields. Implement sorting buttons above the columns in the overview view so that the user can choose a column to sort in ascending or descending order. You can choose whether to sort on the backend or frontend.

Feedback
After parking, editing, or any similar action, we, as users, want feedback on whether it went well or not. This way, we can avoid having to check the list ourselves to see if the vehicle has indeed been updated.

Good luck!

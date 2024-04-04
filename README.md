# SVG Rectangle Editor

## Description
This is a challenge that allows users to visualize and resize an SVG rectangular figure. The initial dimensions are loaded from a JSON file on the backend, and the user can resize the figure using the mouse. The new dimensions are then saved back to the JSON file. The system also calculates and displays the perimeter of the SVG figure.

## Perimeter Calculation
The perimeter of a rectangle is calculated using the formula `2 * (width + height)`. For example, if the initial dimensions loaded from the backend are `{"Width":80,"Height":100}`, the perimeter will be `2 * (80 + 100) = 360`. This calculation is automatically reflected on the frontend whenever there is a change in the rectangle's dimensions.

## Technologies Used
- Frontend: Angular | version 16.2.13.
- Backend: ASP.NET Core | 7.0.10

## Features
1. **Load Initial Dimensions**: The initial dimensions of the rectangle are loaded from the backend.
2. **Mouse Resizing**: Users can resize the rectangle by dragging a handler at the corner of the rectangle.
3. **Perimeter Display**: The perimeter of the rectangle is calculated and displayed in real-time.
4. **Save New Dimensions**: The new dimensions are saved to the backend after resizing.

## Setup and Execution

### Backend
To run the backend:
1. Navigate to the backend folder.
2. Run `dotnet watch run`.
3. You will be redirected to Swagger at the URL: https://localhost:5001/swagger/index.html.

### Frontend
To run the frontend:
1. Navigate to the frontend folder.
2. Run `ng serve`.
3. Open a web browser and go to `http://localhost:4200`.

## How to Use (As a User)
1. Open the application in a web browser.
2. View the initial dimensions loaded from the backend.
3. To resize the rectangle, click and drag the yellow handle at the corner of the rectangle.
4. The perimeter will be calculated and displayed in real-time as you drag the rectangle.

## Project Structure
- Frontend (Angular): Contains the components and services for the user interface.
- Backend (ASP.NET Core): Provides the API for loading and saving dimensions.

## Author
Johnny A. Andrade

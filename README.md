# Calculator

## Assumptions
I chose to ignore sphericity of the earth and applied Pythagoras to get the distance between two points.<br/>
I structure the application, though small, following some Domain Driven Design patterns.

## Additional Packages
I used AutoMapper and realted dependencies to avoid exposing the domain model.

## Additional Unit of Measure
Distance in Nautical miles can also be calculated by specifying "N" string in the Unit of Measure field when inputting values in the body
before calling the only end point in the API project.
If the Unit of Measure field is empty or has a value other than "N" string, value in Kilometers will be returned from the API

## Tools used
Visual Studio

## Framework used
.NET 6

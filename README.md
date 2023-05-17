# Work Departure Time Calculator

This program helps you calculate your departure time from work based on your lunch break and the requirement of working exactly 6 hours daily. It takes into account your class schedule during the workday.

## Getting Started

1. Clone the repository or download the program files.
2. Make sure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
3. Open a terminal or command prompt and navigate to the directory containing the program files.

## Usage

1. Run the program by executing the following command:
   dotnet run

The program will ask if you are leaving for your class now. Enter y if you are leaving now or n if you have already left for your class.
If you entered n, the program will prompt you to enter the time you left for your class in the format HH:mm. Make sure to enter the time correctly.
The program will calculate your departure time from work based on your lunch break and the requirement of working exactly 6 hours daily.
The calculated departure time will be displayed.

## Examples

### Example 1:

Are you leaving for your class now? (y/n): n
Enter the time you left for your class (in HH:mm format): 11:30

Your departure time should be: 16:00
In this example, the user has already left for their class at 11:30, and the program calculates the departure time as 16:30.

## Example 2:

Are you leaving for your class now? (y/n): y

Your departure time should be: <calculated departure time> based on current time.
In this example, the user is leaving for their class at the current time (when running the program), and the program calculates the departure time accordingly.

## Reason

This program was created to address a specific work scenario. The user's job allows working for only 6 hours daily, with a mandatory break from 11:30 a.m. to 1:30 p.m. The original departure time was set at 4:00 p.m. However, the user had the opportunity to enroll in morning classes at UTFPR university and desired to attend them by adjusting their work schedule. The classes started at 10:20 a.m. and ended at 12:00 p.m. To accommodate the classes, the HR department reached an agreement with the user, recognizing the mutual benefits of the arrangement, to allow a longer break and a return to work at 1:30 p.m. The exact time of leaving for classes varied, depending on work commitments, ranging from 10:00 a.m. to 11:00 a.m. The user also made arrangements with teachers to complete school projects in advance. As a result, the user had to adjust their work departure time in the payroll system to comply with legal requirements and record exactly 6 hours daily. Even if the user left at 6:00 p.m., which is the closing time of their workplace, they had to register the exact hours worked to meet the 6-hour daily requirement.

## Contributing

Contributions are welcome! If you find any issues or want to enhance the program, feel free to open an issue or submit a pull request.

## License

This improved version provides clearer instructions for getting started and using the program. It also includes separate examples to demonstrate different scenarios, making it easier for users to understand how to input their information. Feel free to further customize the ReadMe.md file to suit your specific needs.
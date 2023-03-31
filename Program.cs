/**       
 *--------------------------------------------------------------------
 * 	   File name: Program.cs
 * 	Project name: Lab 8
 *--------------------------------------------------------------------
 * Author’s name and email:	Preston Workman, pworkman@etsu.edu			
 *          Course-Section: CSCI1250
 *           Creation Date:	03/30/2023		
 * -------------------------------------------------------------------
 */


static void DisplayCircleInformation(double radius){
    Circles circle = new Circles();
    circle.Circle(radius);
    Console.WriteLine($"The Circle's Diameter is {circle.GetDiameter()}");
    Console.WriteLine($"The Circle's Circumference is {circle.GetCircumference()}");
    Console.WriteLine($"The Circle's Area is {circle.GetArea()}");

}

void Main(){
    //Using the Circle Class
    Console.Write("Please enter the radius of your Circle: ");
    double user_radius = Convert.ToDouble(Console.ReadLine());
    DisplayCircleInformation(user_radius);
    Console.WriteLine("");

    //User Input for the Personal Information Class
    Console.Write("Please enter your Name: ");
    string user_name = Console.ReadLine();
    Console.Write("Please enter your Address: ");
    string user_address = Console.ReadLine();
    Console.Write("Please enter your Age: ");
    int user_age = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please enter your Phone Number: ");
    string user_phoneNumber = Console.ReadLine();
    Console.WriteLine("");

    //Using the Personal Information
    PersonalInformation userInfo = new PersonalInformation(user_name, user_address, user_age, user_phoneNumber);
    Console.WriteLine($"Your name is {userInfo.GetName()}");
    Console.WriteLine($"Your age is {userInfo.GetAge()}");
    Console.WriteLine($"Your address is {userInfo.GetAddress()}");
    Console.WriteLine($"Your phone number is {userInfo.GetPhoneNumber()}");

}


Main();
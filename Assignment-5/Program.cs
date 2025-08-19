using Assignment_5.Classes;
using Assignment_5.Interfaces;
using Assignment_5.Q_2_Classes;
using Assignment_5.Q_2_interfaces;
using Assignment_5.Q_3_Classes;
using Assignment_5.Q_3_Interfaces;
using System;
using System.Net;
using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {

        #region Q_1
        //	Define an interface named IShape with a property Area and a method DisplayShapeInfo.
        //Create two interfaces, ICircle and IRectangle, that inherit from IShape.
        //Implement these interfaces in classes Circle and Rectangle.
        //Test your implementation by creating instances of both classes and displaying their shape information.


        //sol

        // Question 01 implementation

        //ICircle circle = new Circle();
        //circle.Radius = 5.0;
        //circle.DisplayShapeInfo();

        //IRectangle rectangle = new Rectangle();
        //rectangle.Width = 4.0;
        //rectangle.Height = 6.0;
        //rectangle.DisplayShapeInfo(); 
        #endregion
         
        #region Q_2
        ///1-We start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser.
        ///The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.

        ///2 - In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username and password with the stored credentials.
        ///It returns true if the user is authenticated and false otherwise.The AuthorizeUser method checks if the user with the given username has the specified role.
        ///It returns true if the user is authorized and false otherwise.

        ///3-In the Main method, we create an instance of the BasicAuthenticationService  and assign it to the authService variable of type IAuthenticationService.
        ///We then call the AuthenticateUser and AuthorizeUser methods using this interface reference.


        //sol

        /*Q_2 implementation*/

        //BasicAS BAS = new BasicAS();
        //BAS.AuthenticateUser("karem", 1234);
        //BAS.AuthorizeUser("karem", "Gust");

        #endregion

        #region Q_3
        //	1-we define the INotificationService interface with a method SendNotification ‎that takes a recipient and a message as parameters.‎
        //2 - We then create three classes: EmailNotificationService, SmsNotificationService, ‎and PushNotificationService, which implement the INotificationService interface.‎
        //3-In each implementation, we provide the logic to send notifications through the ‎respective communication channel:‎
        //4-The EmailNotificationService class simulates sending an email by outputting a ‎message to the console.‎
        //5-The SmsNotificationService class simulates sending an SMS by outputting a ‎message to the console.‎
        //6-The PushNotificationService class simulates sending a push notification by ‎outputting a message to the console.‎
        //7-In the Main method, we create instances of each notification service class and call ‎the SendNotification method with sample recipient and message values.‎



        //sol

        /// Question 03 implementation
        ///INotificationS SmsNotification = new SmsNS();
        ///INotificationS PushNotification = new PushNS();
        ///INotificationS EmailNotification = new EmaliNS();
        ///EmailNotification.SendNotification("karem", "Hello, this is an email notification!");
        ///SmsNotification.SendNotification("Hoda", "Hello, this is an SMS notification!");
        ///PushNotification.SendNotification("Ali", "Hello, this is a push notification!");
        #endregion

    }
}
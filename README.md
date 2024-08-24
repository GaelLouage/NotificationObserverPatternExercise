# Simple Notification System - Observer Pattern Implementation

This repository contains a basic implementation of the Observer design pattern using C#. The goal is to demonstrate how to create a simple notification system where users (observers) can subscribe to receive updates from a notification service (subject).

## Objective

Implement the Observer pattern to create a notification system where users can subscribe to receive updates.

## Features

- **INotificationService Interface**: Defines methods to add, remove, and notify observers.
- **NotificationService Class**: Maintains a list of observers (e.g., `User` class instances) and sends notifications to them.
- **IObserver Interface**: Ensures that any observer class implements the `Notify()` method to receive updates.
- **User Class**: Implements the `IObserver` interface and processes the notifications it receives.

## Structure

```plaintext
├── NotificationSystemEx.Observers.Interfaces
│   ├── INotificationService.cs  // Interface for the notification service
│   ├── NotificationService.cs   // Implementation of the notification service
│   ├── IObserver.cs             // Interface for observers
│   ├── User.cs                  // Implementation of the User class as an observer
├── Program.cs                   // Entry point to demonstrate the functionality

Getting Started
Prerequisites

    .NET 7 or higher installed on your machine.
    A code editor such as Visual Studio or Visual Studio Code.

Running the Application

    Clone this repository:

    sh

git clone https://github.com/your-username/simple-notification-system.git
cd simple-notification-system

Open the solution in your preferred IDE.

Run the application:

sh

    dotnet run

    Access the application at http://localhost:5000/ (or the port specified in your configuration).

Example Output

When you run the application and navigate to the root URL, you should see a notification message sent to two users:

plaintext

Notification received: Hello, User 1 and 2!
Notification received: Hello, User 1 and 2!

Design Details
INotificationService Interface

Defines the contract for the notification service:

    Add(User user): Adds a user to the list of subscribers.
    Remove(User user): Removes a user from the list of subscribers.
    Notify(string message): Sends a notification message to all subscribed users.

NotificationService Class

Implements the INotificationService interface. It keeps track of subscribed users and iterates through them to send notifications.
IObserver Interface

Ensures that any class acting as an observer (e.g., User) implements the Notify() method to receive messages from the notification service.
User Class

Implements the IObserver interface and handles the receipt of notifications by printing the message to the console and storing it.
Contributing

Feel free to fork this repository and submit pull requests. Suggestions for improvements are always welcome!

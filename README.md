# 🚗 Parking Lot Management System

A scalable and extensible Object-Oriented Parking Lot Management System built using C# and .NET principles. This project demonstrates Low-Level Design (LLD), SOLID principles, and commonly used design patterns such as Singleton, Factory, and Strategy Pattern.

---

# 📌 Problem Statement

Design a Parking Lot System capable of:

- Parking Bikes, Cars, and Trucks
- Managing Parking Spots based on Vehicle Type
- Generating Parking Tickets
- Processing Vehicle Exit
- Calculating Parking Charges
- Updating Display Boards
- Supporting Multiple Parking Strategies
- Managing Parking Lot Administration

---

# 🏗️ System Architecture

```text
                    +----------------+
                    |     Admin      |
                    +----------------+
                             |
                             v
                    +----------------+
                    |  Parking Lot   |
                    +----------------+
                     /      |      \
                    /       |       \
                   v        v        v

           +----------+ +----------+ +--------------+
           | Entrance | | ExitGate | | DisplayBoard |
           +----------+ +----------+ +--------------+
                 |             |
                 v             v

          +-------------+   +-------------+
          | Ticket      |   | Payment     |
          | Generation  |   | Processing  |
          +-------------+   +-------------+

                 |
                 v

         +------------------+
         | Parking Strategy |
         +------------------+
            /          \
           /            \
          v              v

 +----------------+  +----------------+
 | Nearest Spot   |  | Farthest Spot  |
 +----------------+  +----------------+

                 |
                 v

          +---------------+
          | Parking Spots |
          +---------------+
          | Mini    Bike  |
          | Compact Car   |
          | Large   Truck |
          +---------------+
```

---

# 🎯 Features

### Vehicle Management

- Bike Parking
- Car Parking
- Truck Parking

### Spot Allocation

- Mini Spot → Bike
- Compact Spot → Car
- Large Spot → Truck

### Parking Ticket Generation

- Unique Ticket ID
- Entry Timestamp
- Assigned Spot

### Exit Management

- Ticket Validation
- Spot Release
- Payment Calculation

### Display Board

Shows available spots:

```text
Mini    : 10
Compact : 20
Large   : 5
```

### Parking Strategies

Supports different parking allocation algorithms:

- Nearest Available Spot
- Farthest Available Spot

Future strategies can be added without modifying existing code.

---

# 📂 Folder Structure

```text
ParkingLotSystem
│
├── Program.cs
│
├── Admin
│   └── ParkingAdmin.cs
│
├── Enums
│   ├── VehicleType.cs
│   ├── SpotType.cs
│   ├── SpotStatus.cs
│   └── PaymentType.cs
│
├── Models
│   ├── Vehicle.cs
│   ├── Bike.cs
│   ├── Car.cs
│   ├── Truck.cs
│   ├── ParkingSpot.cs
│   ├── ParkingTicket.cs
│   ├── EntranceGate.cs
│   ├── ExitGate.cs
│   ├── Payment.cs
│   └── DisplayBoard.cs
│
├── Interfaces
│   ├── IParkingStrategy.cs
│   └── IPaymentProcessor.cs
│
├── Factory
│   └── VehicleFactory.cs
│
├── Strategies
│   ├── NearestParkingStrategy.cs
│   └── FarthestParkingStrategy.cs
│
├── Services
│   ├── ParkingLot.cs
│   ├── TicketService.cs
│   ├── PaymentService.cs
│   └── DisplayService.cs
│
└── README.md
```

---

# 🚘 Vehicle Types

| Vehicle | Spot Type |
|----------|------------|
| Bike | Mini |
| Car | Compact |
| Truck | Large |

---

# 🎫 Entry Flow

```text
Vehicle Arrives
       |
       v
Select Parking Strategy
       |
       v
Find Available Spot
       |
       v
Assign Spot
       |
       v
Generate Parking Ticket
       |
       v
Update Display Board
```

---

# 🚪 Exit Flow

```text
Vehicle Exit
      |
      v
Validate Ticket
      |
      v
Calculate Parking Fee
      |
      v
Process Payment
      |
      v
Release Parking Spot
      |
      v
Update Display Board
```

---

# 💳 Payment Calculation

Current Pricing:

```text
₹20 per hour
```

Example:

```text
Parking Duration = 3 Hours

Amount = 3 × ₹20
       = ₹60
```

Can easily be extended for:

- Dynamic Pricing
- Weekend Pricing
- Peak Hour Pricing
- EV Charging Fees

---

# 🧠 Design Patterns Used

## Singleton Pattern

Used in:

```csharp
ParkingLot
```

Ensures only one parking lot instance exists.

---

## Factory Pattern

Used in:

```csharp
VehicleFactory
```

Responsible for creating:

- Bike
- Car
- Truck

without exposing creation logic.

---

## Strategy Pattern

Used in:

```csharp
IParkingStrategy
```

Implementations:

```csharp
NearestParkingStrategy
FarthestParkingStrategy
```

Allows changing parking allocation algorithm at runtime.

---

# 🔥 SOLID Principles Applied

### Single Responsibility Principle

Each class has one responsibility.

Examples:

- TicketService
- PaymentService
- DisplayService

---

### Open Closed Principle

New parking strategies can be added without changing existing code.

---

### Liskov Substitution Principle

Bike, Car, Truck can replace Vehicle.

---

### Interface Segregation Principle

Small focused interfaces:

```csharp
IParkingStrategy
IPaymentProcessor
```

---

### Dependency Inversion Principle

High-level modules depend on abstractions.

```csharp
IParkingStrategy
```

instead of concrete implementations.

---

# 📊 Sample Output

```text
Vehicle Entered

Ticket Generated:
ID : 5f7f7d1e-3e17

Allocated Spot : 3

Display Board

Mini    : 2
Compact : 1
Large   : 2


Vehicle Exited

Amount : ₹20

Display Board

Mini    : 2
Compact : 2
Large   : 2
```

---

# 🔄 Future Enhancements

### Parking Lot

- Multiple Floors
- Multiple Buildings

### Vehicle

- Electric Vehicles
- VIP Vehicles

### Payment

- UPI
- Credit Card
- Debit Card
- Cash

### Notifications

- SMS
- Email
- Push Notifications

### Reservations

- Pre-book Parking Spot
- Slot Expiry

### Real-Time Monitoring

- Dashboard
- Analytics
- Occupancy Tracking

### Concurrency

- Thread-Safe Spot Allocation
- Distributed Locking

---

# 📈 Scalability Considerations

For large-scale systems:

### Database

- SQL Server
- PostgreSQL

### Caching

- Redis

### Messaging

- RabbitMQ
- Azure Service Bus
- Kafka

### Cloud

- Azure App Service
- Azure SQL
- Azure Functions

---

# 🛠️ Tech Stack

- C#
- .NET 8
- Object-Oriented Programming
- SOLID Principles
- Design Patterns
- Console Application

---

# 👨‍💻 Author

**Tapan Ray**

Software Engineer | .NET Developer

Skills:
- ASP.NET Core
- C#
- SQL Server
- Azure
- ADO.NET
- System Design
- Low Level Design

---

# ⭐ Interview Topics Covered

This project demonstrates:

- Object Oriented Design
- Low Level Design
- SOLID Principles
- Design Patterns
- Parking Lot System Design
- Strategy Pattern
- Factory Pattern
- Singleton Pattern
- Dependency Injection Concepts
- Extensible Architecture

Perfect for Amazon, Microsoft, Walmart, Visa, Adobe, Atlassian, Uber, and other SDE-1/SDE-2 LLD interviews.
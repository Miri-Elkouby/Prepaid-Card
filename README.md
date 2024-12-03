# Prepaid Cards Project - API in C# and SQL

This project is based on an API written in C# with SQL used for data management. The project is a system for managing prepaid cards, including store management, customers, card sales, and top-up points.

## Project Description

The system allows for the management of prepaid cards, from issuance and sale of cards to loading and managing balances. Each entity in the system has a controller and service handling its related actions. All data is stored in an SQL database, and the system is exposed through an API for management and data retrieval.

### Entities in the system:
- **Store**: Each store can sell cards and manage its inventory.
- **Customer**: Registered users who can load and use cards.
- **Card**: A prepaid card with a balance that can be loaded and used for transactions.
- **Top-up Points**: Locations where customers can load balances onto their cards.
- **Card Sale**: The process by which a customer purchases a card from a store.

## Key Features

- Manage stores, customers, cards, and top-up points.
- RESTful API providing access to information and actions such as card sales and balance top-ups.
- Data is stored and updated in an SQL database.
- Controllers and services separate the business logic from handling API requests.

## Installation

1. Download the code.
2. Run the SQL database and import the necessary schemas.
3. Use Visual Studio or any other IDE with C# support to run the project.
4. Ensure all dependencies are installed (if needed via NuGet packages).

## Usage

The system is based on an API exposed via HTTP. Each entity (such as Store, Customer, Card) can be managed through API calls with JSON as the input/output format.


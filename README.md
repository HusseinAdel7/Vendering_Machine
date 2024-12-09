> #  Vending Machine Project

This is a Vending Machine system with three types of user accounts: **Customer**, **Technical Support**, and **Admin**. Each account type has different functionalities, allowing for seamless interaction with the vending machine, managing finances, and tracking machine issues.

---

## Features

### 1. **Account Types:**

#### **Customer:**
- **Order Drinks**: The customer selects a drink from the machine.
- **Payment Process**: The machine prompts the customer to enter money. If the customer enters less than the required amount, the machine will keep asking for more money until the customer enters the full price of the drink.
- **Drink Dispense**: Once the full payment is received, the machine prepares and dispenses the ordered drink.

#### **Technical Support:**
- **Report Issues**: Technical Support can log a report if the machine encounters a problem (e.g., malfunction or low stock).

#### **Admin:**
- **Check Machine's Current Money**: The admin can view the current balance of money in the vending machine.
- **Deposit Money**: The admin can deposit money into the machine to ensure it has sufficient funds.
- **Withdraw Money**: The admin can withdraw money from the machine.
- **View Technical Support Reports**: The admin can view all reports submitted by technical support to track any issues with the machine.
- **View Order Statistics**: The admin can view how many orders were placed on that day, providing insights into the machine’s performance.

---

### 2. **Functional Flow:**

#### **Customer Interaction:**
1. The customer selects a drink from the available options.
2. The machine prompts the customer to insert money.
3. If the entered amount is insufficient, the machine asks for more money.
4. This continues until the customer inserts the full amount.
5. Once the full amount is entered, the machine prepares and dispenses the selected drink.

#### **Technical Support Interaction:**
- Technical Support staff can log a report if any issues occur with the vending machine (e.g., drink not dispensing, payment errors, etc.).

#### **Admin Interaction:**
- Admins have full control over the machine, including:
  - Checking the current balance of money in the machine.
  - Depositing or withdrawing money from the machine as needed.
  - Viewing technical support reports to keep track of any machine problems.
  - Viewing daily order statistics to understand the machine's performance.

---

### 3. **Reports & Statistics:**

- **Technical Support Reports**: These reports document any issues identified by technical support, helping with troubleshooting and maintenance.
- **Daily Orders Report**: Admin can view the total number of orders made during the day. This helps in tracking the machine’s usage and performance.

---

## Used Technologies 
- C#
- OOP 

---
## Installation

To run the Vending Machine system, follow these steps:

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/vending-machine.git

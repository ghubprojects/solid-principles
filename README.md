# SOLID-Principles

This is an implementation of real-life examples of the five principles known as SOLID, which are used when designing classes in object-oriented programming (OOP).

<p align="center">
  <img width="360" src="https://media.geeksforgeeks.org/wp-content/cdn-uploads/20191012234920/SOLID-Principle-in-Programming-Understand-With-Real-Life-Examples.png" />
</p>

## Single Responsibility Principle (SRP)

<blockquote align="center">
A module should be responsible to one, and only one, actor.
</blockquote>

Let’s understand SRP using an example:

**Imagine a baker who is responsible for baking bread. The baker’s role is to focus on the task of baking bread, ensuring that the bread is of high quality, properly baked, and meets the bakery’s standards.**

- However, if the baker is also responsible for managing the inventory, ordering supplies, serving customers, and cleaning the bakery, this would violate the SRP.
- Each of these tasks represents a separate responsibility, and by combining them, the baker’s focus and effectiveness in baking bread could be compromised.
- To adhere to the SRP, the bakery could assign different roles to different individuals or teams. For example, there could be a separate person or team responsible for managing the inventory, another for ordering supplies, another for serving customers, and another for cleaning the bakery.

## Open-Closed Principle (OCP)

<blockquote align="center">
A software artifact should be open for extension but closed for modification.
</blockquote>

Let’s understand OCP using an example:

**Imagine you have a class called <code>PaymentProcessor</code> that processes payments for an online store. Initially, the <code>PaymentProcessor</code> class only supports processing payments using credit cards. However, you want to extend its functionality to also support processing payments using PayPal.**

Instead of modifying the existing `PaymentProcessor` class to add PayPal support, you can create a new class called `PayPalPaymentProcessor` that extends the `PaymentProcessor` class. This way, the `PaymentProcessor` class remains closed for modification but open for extension, adhering to the Open-Closed Principle.

## Liskov Substitution Principle (LSP)

<blockquote align="center">
Subclasses must be substitutable for their parent classes or super classes without any unexpected behavior.
</blockquote>

Let’s understand LSP using an example:

**One of the classic examples of this principle is a rectangle having four sides. A rectangle’s height can be any value and width can be any value. A square is a rectangle with equal width and height. So we can say that we can extend the properties of the rectangle class into square class.**

In order to do that you need to swap the child (square) class with parent (rectangle) class to fit the definition of a square having four equal sides but a derived class does not affect the behavior of the parent class so if you will do that it will violate the Liskov Substitution Principle.

## Interface Segregation Principle (ISP)

<blockquote align="center">
Clients should not be forced to implement interfaces or methods they do not use.
</blockquote>

Let’s understand ISP using an example:

**Suppose if you enter a restaurant and you are pure vegetarian. The waiter in that restaurant gave you the menu card which includes vegetarian items, non-vegetarian items, drinks, and sweets.**

- In this case, as a customer, you should have a menu card which includes only vegetarian items, not everything which you don’t eat in your food. Here the menu should be different for different types of customers.
- The common or general menu card for everyone can be divided into multiple cards instead of just one. Using this principle helps in reducing the side effects and frequency of required changes.

## Dependency-Inversion Principle (DIP)

<blockquote align="center">
High-level modules should not depend on low-level modules. Instead, they should both depend on abstractions.
</blockquote>

Let’s understand DIP using an example:

**In a software development team, developers depend on an abstract version control system (e.g., Git) to manage and track changes to the codebase. They don’t depend on specific details of how Git works internally.**

This allows developers to focus on writing code without needing to understand the intricacies of version control implementation.
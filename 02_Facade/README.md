# Facade

---
## Components
 * Client
 * Subsystems
 * Facade

---

## Idea
When there are several Subsystems even with diffirent levels for clients, function calls may be complicated and difficult to maintain.
Using Facade to simplify communications between clients and Subsystems can solve the problem.

---

## Advantages
 * Simplify client
 * Increase client reusablity
 * Save time
 * Easier to co-work
 * Increase System security
----

### Simplify client
Client only calls Facade, needn't access Subsystems.

----

### Increase client reusablity
Client can easily be reused by changing the related Facade instead of the whole Subsystems

----

### Save time
Revising only interferes small amount of files. Re-Compiling takes time.

----

### Easier to co-work
When designing Client, designer needn't know every step of process.

----

### Increase System security
Avoid Client making an error function call to Subsystem accidently.

---

## Disadvantege :
When numbers of Subsystems increases, numbers of interfaces in Facade will be a lot. Revising and rebuilding Facade is suggested.

---

## Structure

----

### Client
member m_Facade;

----

### Facade


----

### State
member Context; // the state controller
function Handle ( var value ); // handle request from Context by value, may update state

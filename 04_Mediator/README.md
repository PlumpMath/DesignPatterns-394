# Mediator

---
## Components
 * Mediator
 * Collegue1
 * Collegue2
 * Collegue3

---

## Idea
To help commutication between Collegues.

---

## Advantages
 * Collegues needn't includes too many Collegues' references.
 * Collegues are more independent. Only related with Mediator.

---

## Disadvantege
 * When number of Collegues is too large, there might be too many interfaces.

---

## Facing Changings
 * Facing changings
 * Facing appending
The files to modify is little. Mainly on Mediator and the modified collegue.

----

### Changings
In addition to the changes of collegue, the only thing to do is adding a related function in Mediator.

----

### Appending
Appending a class inherits from one of the collegues in the Mediator, just add to be member of Mediator and implement related function in Mediator.

---

## Structure

----

### Mediator

member Collegue1;
member Collegue2;
member Collegue3;

function RequestToCol1() { return Collegue1.Handle(); }
function RequestToCol2() { return Collegue2.Handle(); }
function RequestToCol3() { return Collegue3.Handle(); }

----

### CollegueX
//need only one member
member Mediator;

function Handle(){ handle request; }

function RequestToColX() { return Mediator.RequestToColX(); }

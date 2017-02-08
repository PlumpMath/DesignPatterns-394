# Bridge

---
## Components
 * Abstraction Class
 * Implementor

---

## Idea
Decouple an Abstraction  from Implementor.
Make implementations independent.

---

## Advantages
 * Keep Abstraction and Implementor independent.
 * Abstractions don't have to care about the expansion of Implementors.

---

## Facing Changings
 * Facing expansion

----

### Expansion
Expansion on Abstraction or Implementor don't interfere the other.

---

## Structure

----

### Abstraction
member Implementor
function Operation() { Implementor.Operation(); }

----

### Implementor
function Operation() { } ;

# Template

---

## Components
 * AbstractClass
 * ConcreteClass_A
 * ConcreteClass_B

---

## Idea
When Classes have same operation procedure but diffirent detial, add a function for ordering operations.

---

## Advantages
 * Designing Operation procedure only happens once, detail designed in subclasses.
 * Easy to modify operation order.

---

## Structure

----

### AbstractClass
abstract function Operation_A () {};
abstract function Operation_B () {};
function Template () { Operation_A; Operation_B;}

----

### ConcreteClass_X
override function Operation_A () {};
override function Operation_B () {};

# Strategy
### Very similar to State
---

## Components
 * Context
 * Strategy
 * ConcreteStrategy_A
 * ConcreteStrategy_B
 * ConcreteStrategy_C

---

## Idea
When there are several algorithms, instead of using switch case / if else to decide between diffirent algorithm, just call algorithm by condition.

---

## Advantages
 * Easy to maintain
     * related algorithms are in the class.
 * Don't need switch case / if else for each case
 * Easy to change algorithms

---

## Structure

----

### Context
member Strategy;

----

### Strategy
abstract function Algorithm( Condition ) { } ;

----
### ConcreteStrategy_X
override function Algorithm ( Condition )
{ if Condition not match for Strategy_X : return;
else do } ;

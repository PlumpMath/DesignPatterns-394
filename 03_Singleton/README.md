# Somgleton

---
## Components
 * Singleton

---

## Idea
Define a unique object that can be accessed by global.Remind to restrict to number of the object to be unique.

---

## Advantages
 * Easy to access.
 * Unique

---

## Disadvantege
Difficult to append children classes since it uses a global static member.

---

## Structure

----

### Singleton
private static Singleton _instance;
public static Singleton Instance
{
    get if( _instance == null ) _instance = new Singleton();
    return _instance
}

---

## Reducing Singleton
The disadvantage is critical, using singleton abusingly may enhance the difficulty of adding features by appending children.
To reduce singleton, there are :
 * Add a static counter in the class to restrict creating new object.
     * This keep it unique.
 * Set to be others reference.
     * Easy to access

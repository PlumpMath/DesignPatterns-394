# Factory
Often using with Builder

---

## Components
 * Creator ( Factory )
 * ConcreteCreator
 * Product
 * ConcreteProduct

---

## Idea
Define a interface to create product. Type of created product decided by subclasses.
Use Factory when product :
 * Has complex procedure
 * Limited numbers
 * Can be reuse

---

## Advantages

 * The code only deal with Product interface, needn't bind application-specific classes.
    * Can work on any user-defined ConcreteProduct.
 * Subclassing Creator for creating a particular ConcreteProduct is easy since Creator is interface-based..

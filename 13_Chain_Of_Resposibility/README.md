# Chain Of Responsibility
---

## Components
 * Handler
 * ConcreteHandler
 * Client

---

## Idea
Client sends request to a Handler. If the Handler can't handle the request, it will pass it to next handler.

---

## Advantages
 * Reduced coupling
     * Client doesn't have to know which object can handle the request. An object in the chain doesn't have to know about the structure of chain.
 * Easy to modify the chain. ( as link list )

# Composite

---

## Components
 * Component
 * Composite ( node )
 * Leaf


---

## Idea
Composite a group of components by a tree structure. Client only has to deal with the top interface even though some components may have sub-components.
That is, client can ignore the difference between compositions of objects and individual objects.

---

## Advantages
 * Make client simple.
 * Easier to add component. Clients don't have to be changed for new component.
 * Make design general. All components can share interface.

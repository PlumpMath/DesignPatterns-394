# State

---

## Components
 * Game Loop
 * Context ( state controller, owns current state )
 * State ( state interface )
 * Concrete State ( implement state interface )

---

## Idea
Using concrete states to decide next state of context instead of using context control itself.

----

### Advantage :
In this way, maintainance would be easier since appending a new state will only have to do :
 * Add a new concrete state and implement related functions.
 * Decide next state of the the concrete state.
 * Decide previous state of the new concrete state.

----

### Disadvantege :
When there's a lot of concrete states, may occur a class burst.

---

## Structure

----

### Game loop
member Context; // owns current state

----

### Context
member State; // current state
function Request( var value ); // request current state handle by value
function SetState( var state ); // update current state

----

### State
member Context; // the state controller
function Handle ( var value ); // handle request from Context by value, may update state

void UnitTest() {
    // add root
    Component root = new Composite("root");
    root.Add(new Leaf("Leaf1"));
    root.Add(new Leaf("Leaf2"));

    Component child = new Composite("child");
    child.Add(new Leaf("child Leaf1"));
    child.Add(new Leaf("child Leaf2"));
}

/*
root.Operation();

console :
Leaf1
Leaf2
child Leaf1
child Leaf2
*/

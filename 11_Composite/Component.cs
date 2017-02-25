public abstract class Component {
    protected string m_Value;
    // Every component has Operation
    public abstract void Operation();

    /*
    *   Leaves do not have any child
    */
    public void Add ( Component component ) { Warning : did not Implement ! }
    public void Remove ( Component component ) { Warning : did not Implement ! }
    public Component GetChild ( int index ) { Warning : did not Implement ! }
}

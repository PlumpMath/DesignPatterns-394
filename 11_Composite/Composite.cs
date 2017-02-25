public class Composite : Component {
    // node has children
    List < Component > m_childrenList = new List < Component >();

    public Composite( string value ) { m_Value = value; }
    // Operate every child
    public override void Operation() {
        foreach ( Component component in m_childrenList ) component.Operation();
    }

    /*
    *   Implement functions related with children
    */
    public override void Add( Component component ) { m_childrenList.Add( component ); }
    public override void Remove( Component component ) { m_childrenList.Remove( component ); }
    public override Component Add( int index ) { return m_childrenList[index]; }
}

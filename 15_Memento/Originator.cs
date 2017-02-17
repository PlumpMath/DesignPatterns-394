public class Originator {
    string m_state;
    public void SetState ( string state ) {
        m_state = state;
    }
    //Store data initiatively
    public Memento CreateMemento () {
        Memento memento = new Memento ();
        memento.SetState ( m_state );
        return memento;
    }
    //Load data from Memento
    public void SetMemento ( Memento memento ) {
        m_state = memento.GetState;
    }
}

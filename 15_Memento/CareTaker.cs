public class CareTaker {
    Dictionary < string, Memento > m_mementoList = new Dictionary < string, Memento > ();
    public void AddMemento ( string version, Memento memento ) {
        if ( m_mementoList.ContainsKey (version) == false )
            m_mementoList.Add ( version, memento );
        else
            m_mementoList[version] = memento;
    }

    public Memento GetMemento ( string version ) {
        return m_mementoList[version];
    }
}

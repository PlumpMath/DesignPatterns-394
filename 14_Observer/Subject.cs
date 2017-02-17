public abstract class Subject {
    List < Observer > m_observerList = new List < Observer > () ;
    public void AttachObserver ( Observer observer ) {
        m_observerList.Add ( observer );
    }
    public void RemoveObserver ( Observer observer ) {
        m_observerList.Remove ( observer );
    }

    //Notify all observers
    public void Notify() {
        foreach ( Observer observer in m_observerList )
            observer.Update();
    }
}

public class ConcreteSubject {
    string m_state;
    public void SetState ( string state ) { m_state = state; }
    public string GetState() { return m_state; }
}

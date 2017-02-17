public abstract class Observer {
    public abstract void Update () {};
}

public class ConcreteObserverX {
    string m_state;
    ConcreteSubject m_subject = null;
    public ConcreteObserverX ( ConcreteSubject subject ) { m_subject = subject; }

    //Notify Observer to be updated by subject
    public override void Update () {
        m_state = m_subject.state;
    }
}

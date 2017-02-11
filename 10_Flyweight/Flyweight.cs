public abstract class Flyweight {
    string m_Content;
    public Flyweight(string content) { m_Content = content; }
    public string GetContent() { return m_Content; }
    public abstract void Operation();
}

// Can create a object that can be shared.
public class ConcreteFlyweight : Flyweight {
    public override void Operation() {
        do Operation on content;
    }
}

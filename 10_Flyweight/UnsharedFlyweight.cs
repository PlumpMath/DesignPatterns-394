// Need not enherit from Flyweight
public class UnsharedConcreteFlyweight /*: Flyweight*/ {
    Flyweight m_Flyweight;
    string m_UnsharedContent;
    public UnsharedConcreteFlyweight(string content) { m_UnsharedContent = content; }
    public void SetSharedFlyweight(Flyweight flyweight) { m_FlyweightDict = flyweight; }
    public void Operation () {

    }
}

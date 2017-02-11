public class FlyweightFactory {
    Dictionary <string, Flyweight> m_FlyweightDict = new Dictionary <string, Flyweight>();
    public Flyweight GetSharedFlyweight (string key, string content) {
        if ( m_FlyweightDict.ContainsKey(key) ) return m_FlyweightDict[key];
        // Create new Flyweight and add to Dictionary
        ConcreteFlyweight concreteFlyweight = new ConcreteFlyweight( content );
        m_FlyweightDict[key] = concreteFlyweight;

        return concreteFlyweight;
    }
    // Get unsharedFlyweight with shared content
    public UnsharedConcreteFlyweight GetUnsharedFlyweight(string key, string sharedContent, string unsharedContent) {
        Flyweight sharedFlyweight = GetSharedFlyweight(key, sharedContent);
        UnsharedConcreteFlyweight unsharedFlyweight = new UnsharedConcreteFlyweight(unsharedContent);
        unsharedFlyweight.SetSharedFlyweight(sharedFlyweight);
        return unsharedFlyweight;
    }
}

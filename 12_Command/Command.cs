public abstract class Command {
    public abstract void Execute();
}

public class ConcreteCommand1 {
    Receiver1 m_receiver = null;
    public ConcreteCommand1( Receiver1 receiver ) { m_receiver = receiver; }
    public override Execute() { m_receiver.Action(); }
}


public class ConcreteCommand2 {
    Receiver2 m_receiver = null;
    public ConcreteCommand2( Receiver2 receiver ) { m_receiver = receiver; }
    public override Execute() { m_receiver.Action(); }
}

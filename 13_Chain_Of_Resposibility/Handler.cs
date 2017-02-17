public abstract class Handler {
    //if can't handle, pass to next
    protected Handler m_nextHandler = null;

    public Handler ( Handler nextHandler ) { m_nextHandler = nextHandler; }
    public virtual void HandleRequest ( int cost ) {
        if ( m_nextHandler != null )
            m_nextHandler.HandleRequest ( cost ) ;
    }
}

public class ConcreteHandlerX : Handler {
    private int m_costCheck = x;
    public ConcreteHandlerX ( Handler nextHandler ) : base ( nextHandler ) {};
    public override void HandleRequest ( int cost ) {
        if ( cost <= m_costCheck )
            Answer request
        else
            base.HandleRequest ( cost ) ;
    }
}

public class Invoker {
    List < Command > m_commandList = new List < Command > ();
    public void AddCommand( Command command ) { m_commandList.Add(command); }
//    public void RemoveCommand( Command command ) { m_commandList.Remove(command); }
    public void ExecuteCommand() {
        foreach ( Command command ) in m_commandList command.Execute();
        m_commandList.Clear();
    }
}

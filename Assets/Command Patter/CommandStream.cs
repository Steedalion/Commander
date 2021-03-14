using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandStream : MonoBehaviour
{
    public void AddCommand(Command command)
    {
        commands.Enqueue(command);
    }
    
    private readonly Queue<Command> commands = new Queue<Command>();
private readonly Queue<Command> commandsExecuted = new Queue<Command>();

    // Update is called once per frame
    void Update()
    {
        if(commands.Count <=0) return;
            Command command = commands.Dequeue();
            commandsExecuted.Enqueue(command);
            command.Execute();

            if (commandsExecuted.Count <= 5) return;
            StartCoroutine(UndoAll());

    }

    private IEnumerator UndoAll()
    {
        while (commandsExecuted.Count >0)
        {
            commandsExecuted.Dequeue().Unexecute();
                            yield return new WaitForSeconds(0.1f);

        }
            yield return null;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandQueue : MonoBehaviour
{
    public void AddCommand(Command command)
    {
        commands.Enqueue(command);
    }
    
    private readonly Queue<Command> commands = new Queue<Command>();

    // Update is called once per frame
    void Update()
    {
        if(commands.Count <=0) return;
            Command command = commands.Dequeue();
            command.execute();

    }
}

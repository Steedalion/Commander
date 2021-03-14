using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirection : Command
{
    public MoveDirection(GameObject gameObject, Vector3 direction)
    {
        this.gameObject = gameObject;
        this.direction = direction;
    }

    private readonly GameObject gameObject;

        private readonly Vector3 direction;
public void Execute()
    {
        gameObject.transform.position += direction;
    }

public void Unexecute()
{
    gameObject.transform.position -= direction;
}
}

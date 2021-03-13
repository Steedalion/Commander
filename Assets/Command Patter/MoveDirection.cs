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

    private GameObject gameObject;

        private Vector3 direction;
public void execute()
    {
        gameObject.transform.position += direction;
    }
}

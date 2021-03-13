using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : Command
{
    public MoveLeft(GameObject gameObject)
    {
        this.gameObject = gameObject;
    }

    private GameObject gameObject;
    public void execute()
    {
        gameObject.transform.position += Vector3.left;
    }
}

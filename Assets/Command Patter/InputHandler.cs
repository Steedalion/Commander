using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class InputHandler : MonoBehaviour
{
    [FormerlySerializedAs("commandQueue")] [SerializeField] private CommandStream commandStream;


    // Update is called once per frame
    void Update()
    {
        Command move;
        if (Input.GetKeyDown(KeyCode.A))
        {
            move = new MoveDirection(gameObject, Vector3.left);
                                                    commandStream.AddCommand(move);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            move = new MoveDirection(gameObject, Vector3.right);
                                                    commandStream.AddCommand(move);
        }

        

    }
    
}

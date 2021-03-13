using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private CommandQueue commandQueue;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Command move = new MoveLeft(gameObject);
            commandQueue.AddCommand(move);
        }
    }
    
}

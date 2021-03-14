using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MoveToGoal : MonoBehaviour
{

    [SerializeField] private float delay;
    
    [SerializeField] private Transform goal;
    [FormerlySerializedAs("commandQueue")] [SerializeField] private CommandStream commandStream;
    private WaitForSeconds wait;
    
    
    // Start is called before the first frame update
    void Start()
    {
        wait = new WaitForSeconds(delay);
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        yield return wait;
            Vector3 to = goal.position - transform.position;

                Vector3 direction = to.x > 0 ? Vector3.right : Vector3.left;
                commandStream.AddCommand(new MoveDirection(gameObject, direction));
                yield return Move();
                
    }

}

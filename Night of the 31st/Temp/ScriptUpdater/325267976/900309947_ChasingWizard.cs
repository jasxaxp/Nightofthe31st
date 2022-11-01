using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasingWizard : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent Enemy;
	GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
       Target = GameObject.FindWithTag("Player");
	   Enemy = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Enemy.SetDestination(Target.transform.position);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform target; 
    Rigidbody rig;
    public float speed = 4f;
    public float enemyDamageAmount;
    public float timeBetweenAttacks;
    private bool alreadyAttacked;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
        rig.MovePosition(pos);
        transform.LookAt(target);
    }

   // private void OnTriggerEnter(Collider col)
    //{
       // if (col.CompareTag("Player"))
       // {
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       // }
        
   // }
}

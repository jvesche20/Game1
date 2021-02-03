using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{

    public GameObject rock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "rock")
        {
            Destroy(this.gameObject);
        }
    }
}

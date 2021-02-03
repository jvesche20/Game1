using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject button;
    public GameObject floor;

    public ParticleSystem particle;
    
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
        if (other.gameObject.tag == "button")
        {
            Destroy(button);
            Destroy(floor);
            particle.Play();
            
        }
    }
    
}

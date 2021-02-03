using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    public ParticleSystem wallParticle;
    public GameObject buttonObj;
    public GameObject wallObj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wallButton")
        {
            wallParticle.Stop();
            Destroy(buttonObj);
            Destroy(wallObj);


        }
    }
}

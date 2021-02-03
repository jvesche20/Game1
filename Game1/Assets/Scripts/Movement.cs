using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode left;
    public KeyCode right;
    public KeyCode space;
    public float speed;
    public float jumpSpeed = 10f;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right))
        {
            Player.transform.Translate(new Vector2(speed * Time.deltaTime, 0));

        }
        if (Input.GetKey(left))
        {
            Player.transform.Translate(new Vector2(-speed * Time.deltaTime, 0));

        }

        if (Input.GetKey(space))
        {
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y + (Time.deltaTime * jumpSpeed), this.transform.position.z);
        }
       

    }
}

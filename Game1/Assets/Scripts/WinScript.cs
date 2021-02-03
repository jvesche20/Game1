using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "win")
        {
            
            LoadScene("Win Screen 1");

        }
        
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class controller : MonoBehaviour
{

    void Start()
    {
        SceneManager.LoadScene("Starter Level", LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

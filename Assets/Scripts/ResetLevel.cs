using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ResetLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public void ResetGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

   
}

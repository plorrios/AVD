using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class laodNextLevel : MonoBehaviour
{

    public void loadLevel()
    {
        SceneManager.LoadScene(2);
    }

}

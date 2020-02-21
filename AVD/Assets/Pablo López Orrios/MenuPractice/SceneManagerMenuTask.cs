using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerMenuTask : MonoBehaviour
{
    [SerializeField]
    private Canvas Menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { ChangeMenu(); }
    }

    public void ChangeMenu() { Menu.enabled = !Menu.enabled; }

    public void LoadScene() { SceneManager.LoadScene(1); }
}

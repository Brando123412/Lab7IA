using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(name);
    }
    public void QuitApplication()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void Restarcik()
    {
        SceneManager.LoadScene(1);
    }
    public void Majster()
    {
        SceneManager.LoadScene(0);
    }
}
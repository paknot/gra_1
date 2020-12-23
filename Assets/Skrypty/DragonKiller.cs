using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonKiller : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 6.3) 
            SceneManager.LoadScene(11);
        if(transform.position.y < -5.6) 
            SceneManager.LoadScene(11);
        if(transform.position.x > 9)
            SceneManager.LoadScene(11);
        if(transform.position.x < -9)
            SceneManager.LoadScene(11);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      SceneManager.LoadScene(11);
    }
}

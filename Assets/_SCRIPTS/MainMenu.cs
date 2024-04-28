using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour

{

    public AudioClip Music;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(Music);
    }

    public void PlayGame()
    {

        SceneManager.LoadSceneAsync(1);
        gameObject.GetComponent<AudioSource>().Stop();
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

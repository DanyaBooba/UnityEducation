using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public void Menu()
    {
        Load("Menu");
    }

    public void Game()
    {
        Load("Game");
    }

    private void Load(string name)
    {
        SceneManager.LoadScene(name);
    }
}

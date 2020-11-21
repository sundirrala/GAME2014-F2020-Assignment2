using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnInstructionButtonPressed()
    {
        SceneManager.LoadScene("Instruction Screen");
    }

    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene("Menu Screen");
    }

    public void onPlayAgainButtonPressed()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnMenuButtonPressed()
    {
        SceneManager.LoadScene("Menu Screen");
    }

}

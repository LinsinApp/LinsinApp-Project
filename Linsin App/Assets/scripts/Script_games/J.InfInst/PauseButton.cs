using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public PauseMenu pauseMenu;

    public void OnClick()
    {
        pauseMenu.Pause();
    }
}

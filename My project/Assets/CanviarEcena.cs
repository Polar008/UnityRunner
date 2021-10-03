using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanviarEcena : MonoBehaviour
{
    public void loadSeen(string Name) {
        SceneManager.LoadScene(Name);
    }
    
}

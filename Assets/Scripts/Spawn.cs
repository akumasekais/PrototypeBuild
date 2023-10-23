using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.SceneManager;


public class Spawn : MonoBehaviour
{

  public void OpenScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
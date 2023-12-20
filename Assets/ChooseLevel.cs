using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void LevelBtnClick1()
    {
        Application.LoadLevel("SampleScene");
    }

    public void LevelBtnClick2()
    {
        Application.LoadLevel("Level2");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    private void Start()
    {
        SoundManager.Instance.PlayBGMSound("VSQSE_0666_forest");
        CooparationJudge.Instance.CooperationInit();
    }


    public void StartGeme()
    {
        SceneManager.LoadScene("Show");
    }

}

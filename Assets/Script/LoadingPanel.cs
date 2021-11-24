using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingPanel : MonoBehaviour
{
    public static LoadingPanel Instance;

    private Image img_LoadingBar;
    private AsyncOperation m_Ao;
    private bool m_IsLoad = false;
    private void Awake()
    {
        Instance = this;
        transform.localScale = Vector3.zero;
        img_LoadingBar = transform.Find("img_LoadingBar").GetComponent<Image>();
    }
    public void LoadScene()
    {
        transform.DOScale(Vector3.one, 0.3f).OnComplete(() =>
        {
            //                        StartCoroutine("Load");
            int displayprogress = -1;
            int toprogress = 1000000;

            while (displayprogress < toprogress)
            {
                displayprogress++;
                ShowProgress(displayprogress);

                if (m_IsLoad == false)
                {
                    m_Ao = SceneManager.LoadSceneAsync("mainPlay");
                    m_Ao.allowSceneActivation = false;
                    m_IsLoad = true;
                }
            }
            if (displayprogress == 1000000)
            {
                m_Ao.allowSceneActivation = true;
            }
        });
    }
    //IEnumerable Load()
    //{
    //    int displayProgress = -1;
    //    int toProgress = 100;

    //    while (displayProgress < toProgress)
    //    {
    //        displayProgress++;
    //        ShowProgress(displayProgress);

    //        if (m_IsLoad == false)
    //        {
    //            m_Ao = SceneManager.LoadSceneAsync("mainPlay");
    //            m_Ao.allowSceneActivation = false;
    //            m_IsLoad = true;
    //        }
    //        yield return new WaitForEndOfFrame();
    //    }
    //    if (displayProgress == 100)
    //    {
    //        m_Ao.allowSceneActivation = true;
    //        StopCoroutine("Load");
    //    }
    //}
    private void ShowProgress(int progress)
    {
        img_LoadingBar.fillAmount = progress*0.000001f;
    }
}

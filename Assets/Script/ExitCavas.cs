using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitCavas : MonoBehaviour
{

    private Button ExitButton;

    private void Awake()
    {
        Init();
    }
    private void Init()
    {
        ExitButton = transform.Find("Button").GetComponent<Button>();
        ExitButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("mainPlay");
        }
            );
    }
}

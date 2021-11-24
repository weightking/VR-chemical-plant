using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameItemSelectPanel : MonoBehaviour {

    private Button Glove;
    private Button Helmet;
    private Button Mask;
    private Button shoes;
    private Button close;
    private Button glasses;
    private Button btn_Select;

    private void Awake()
    {
        btn_Select = transform.Find("btn_Select").GetComponent<Button>();
        btn_Select.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
        btn_Select.GetComponent<BoxCollider>().size = new Vector3(0, 0, 0);
        transform.Find("Glove").GetComponent<Image>().color = Color.gray;
        transform.Find("Helmet").GetComponent<Image>().color = Color.gray;
        transform.Find("Mask").GetComponent<Image>().color = Color.gray;
        transform.Find("shoes").GetComponent<Image>().color = Color.gray;
        transform.Find("close").GetComponent<Image>().color = Color.gray;
        transform.Find("glasses").GetComponent<Image>().color = Color.gray;
        Init();
    }
    private void Init()
    {
        Glove = transform.Find("Glove").GetComponent<Button>();
        Glove.onClick.AddListener(() =>
        {
            ValueStore.countToStar1 = ValueStore.countToStar1 + 1;
            if (ValueStore.countToStar1>=1)
            {
                transform.Find("Glove").GetComponent<Image>().color = Color.white;
            }
            if (ValueStore.countToStar1 >= 1 && ValueStore.countToStar2 >= 1 && ValueStore.countToStar3 >= 1 && ValueStore.countToStar4 >= 1 && ValueStore.countToStar5 >= 1 && ValueStore.countToStar6 >= 1)
            {
                btn_Select.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);
                btn_Select.GetComponent<BoxCollider>().size = new Vector3(100, 100, 1);
            }
        }
        );
        Helmet = transform.Find("Helmet").GetComponent<Button>();
        Helmet.onClick.AddListener(() =>
        {
            ValueStore.countToStar2 = ValueStore.countToStar2 + 1;
            if (ValueStore.countToStar2 >= 1)
            {
                transform.Find("Helmet").GetComponent<Image>().color = Color.white;
            }
            if (ValueStore.countToStar1 >= 1 && ValueStore.countToStar2 >= 1 && ValueStore.countToStar3 >= 1 && ValueStore.countToStar4 >= 1 && ValueStore.countToStar5 >= 1 && ValueStore.countToStar6 >= 1)
            {
                btn_Select.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);
                btn_Select.GetComponent<BoxCollider>().size = new Vector3(100, 100, 1);
            }
        }
        );
        Mask = transform.Find("Mask").GetComponent<Button>();
        Mask.onClick.AddListener(() =>
        {
            ValueStore.countToStar3 = ValueStore.countToStar3 + 1;
            if (ValueStore.countToStar3 >= 1)
            {
                transform.Find("Mask").GetComponent<Image>().color = Color.white;
            }
            if (ValueStore.countToStar1 >= 1 && ValueStore.countToStar2 >= 1 && ValueStore.countToStar3 >= 1 && ValueStore.countToStar4 >= 1 && ValueStore.countToStar5 >= 1 && ValueStore.countToStar6 >= 1)
            {
                btn_Select.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);
                btn_Select.GetComponent<BoxCollider>().size = new Vector3(100, 100, 1);
            }
        }
        );
        shoes = transform.Find("shoes").GetComponent<Button>();
        shoes.onClick.AddListener(() =>
        {
            ValueStore.countToStar4 = ValueStore.countToStar4 + 1;
            if (ValueStore.countToStar4 >= 1)
            {
                transform.Find("shoes").GetComponent<Image>().color = Color.white;
            }
            if (ValueStore.countToStar1 >= 1 && ValueStore.countToStar2 >= 1 && ValueStore.countToStar3 >= 1 && ValueStore.countToStar4 >= 1 && ValueStore.countToStar5 >= 1 && ValueStore.countToStar6 >= 1)
            {
                btn_Select.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);
                btn_Select.GetComponent<BoxCollider>().size = new Vector3(100, 100, 1);
            }
        }
        );
        close = transform.Find("close").GetComponent<Button>();
        close.onClick.AddListener(() =>
        {
            ValueStore.countToStar5 = ValueStore.countToStar5 + 1;
            if (ValueStore.countToStar5 >= 1)
            {
                transform.Find("close").GetComponent<Image>().color = Color.white;
            }
            if (ValueStore.countToStar1 >= 1 && ValueStore.countToStar2 >= 1 && ValueStore.countToStar3 >= 1 && ValueStore.countToStar4 >= 1 && ValueStore.countToStar5 >= 1 && ValueStore.countToStar6 >= 1)
            {
                btn_Select.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);
                btn_Select.GetComponent<BoxCollider>().size = new Vector3(100, 100, 1);
            }
        }
        );
        glasses = transform.Find("glasses").GetComponent<Button>();
        glasses.onClick.AddListener(() =>
        {
            ValueStore.countToStar6 = ValueStore.countToStar6 + 1;
            if (ValueStore.countToStar6 >= 1)
            {
                transform.Find("glasses").GetComponent<Image>().color = Color.white;
            }
            if (ValueStore.countToStar1 >= 1 && ValueStore.countToStar2 >= 1 && ValueStore.countToStar3 >= 1 && ValueStore.countToStar4 >= 1 && ValueStore.countToStar5 >= 1 && ValueStore.countToStar6 >= 1)
            {
                btn_Select.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);
                btn_Select.GetComponent<BoxCollider>().size = new Vector3(100, 100, 1);
            }
        }
        );
        btn_Select.onClick.AddListener(() =>
        {
            LoadingPanel.Instance.LoadScene();
        });
    }
}

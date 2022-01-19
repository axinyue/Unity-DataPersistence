using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserManager : MonoBehaviour
{
    public Button button;
    public ScrollRect scrollRect;
    public GameObject scrollContent;
    // Start is called before the first frame update
    void Start()
    {
        Text[] texts = scrollContent.transform.GetComponentsInChildren<Text>();
        int firstPosition = -25;
        int spacing = 30;
        int i = 0;
        bool first = true;
        foreach (Text text in texts)
        {
            RectTransform textTransForm = text.GetComponent<RectTransform>();
            Vector2 pos = textTransForm.anchoredPosition;
            if (first) {
                pos.y = (1 + i) * firstPosition;
            }
            else {
                pos.y = (1 + i) * firstPosition + spacing;

            }

            pos.x = textTransForm.sizeDelta.x / 2 + 3;
            //textTransForm.position = pos;
            textTransForm.localPosition = pos;


            Debug.Log(pos);
            i++;


        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

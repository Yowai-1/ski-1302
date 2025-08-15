using UnityEngine;
using UnityEngine.UI;
using TMPro;
using TMPro.EditorUtilities;
public class UIManeger : MonoBehaviour
{
    [SerializeField]
    private TMP_Text notiText;


    public static UIManeger instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowNotitext(string s)
    {
        notiText.text = s;
    }


}

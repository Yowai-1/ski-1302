using UnityEngine;

public class Trees : MonoBehaviour
{
    private Renderer rd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;

        Player player = collision.gameObject.GetComponent<Player>();
        player.HP -= 15;

        string s = string.Format("Hit!(-15)\nRemaining HP : {0}", player.HP);
        UIManeger.instance.ShowNotitext(s);

        if (player.HP <= 0)
        {
            player.HP = 0;
            UIManeger.instance.ShowNotitext("You Are Dead!");
            Time.timeScale = 0;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32 (255 , 104 , 0 ,255);
    }
}

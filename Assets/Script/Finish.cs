using UnityEngine;

public class Script : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Player p = other.GetComponent<Player>();
        p.Score += 100;

        string s = string.Format("You Win !\nScore : {0}",p.Score);
        UIManeger.instance.ShowNotitext(s);
    }
}

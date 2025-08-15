using UnityEngine;

public class Reward : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.Score += 5;

        string s = string.Format("+5 point\nScore {0}", player.Score);

        UIManeger.instance.ShowNotitext(s);

        Destroy(gameObject);
    }

}

using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float forcepower;

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private float xInput;

    [SerializeField]
    private int score;
    public int Score { get { return score; } set {score = value;} }

    [SerializeField]
    private int hp;
    public int HP {  get { return hp; } set {hp = value;} }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb  = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        LeftOrRight();
    }
    private void LeftOrRight()
    {
        xInput = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.right * forcepower * xInput);
    }
}

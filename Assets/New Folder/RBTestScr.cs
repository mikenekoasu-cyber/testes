using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Rigidbody rb;
    private bool isGround = false;
    [SerializeField] private float jumpForce = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        if(Input.GetKeyDown(KeyCode.Space) && isGround){
            Debug.Log("test2");
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
            isGround = false;
        }
    }

    void OnCollisionEnter(Collision collision){
        //Debug.Log("衝突中");
        rb = GetComponent<Rigidbody>();
        //Debug.Log("test");
        isGround = true;
        //rb.ForceMode = ForceMode.Impulse;
    }
}

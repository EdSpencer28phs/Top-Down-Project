using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public bool buttonPressed;
    public GameObject keyPrefab;
    public Vector3 keySpawn1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            buttonPressed = true;
        }
        else
        {
            buttonPressed = false;
        }
        if(buttonPressed == true)
        {
            Instantiate(keyPrefab,keySpawn1,Quaternion.identity);
        }
    }
}

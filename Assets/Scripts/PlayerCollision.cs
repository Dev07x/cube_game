using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    public PlayerSccript playerSccript;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag==("collectables"))
        {
           Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
            playerSccript.enabled = false;
           
        }
    }
}

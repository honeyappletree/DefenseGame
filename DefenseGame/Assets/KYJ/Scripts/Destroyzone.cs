using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyzone : MonoBehaviour
{
    [SerializeField] private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            float x = player.transform.localPosition.x;
            x = Mathf.Clamp(player.transform.localPosition.x, -436, 435);
            float y = player.transform.localPosition.y;
            y = Mathf.Clamp(player.transform.localPosition.y, -865, 859);
            player.transform.localPosition = new Vector3(x, y, player.transform.localPosition.z);
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] private GameObject enemyThings;
    [SerializeField] private Text enemyThingsText;
    int thingsCount = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("EnemyThings"))
        {
            enemyThings.SetActive(false);
            thingsCount++;
            enemyThingsText.text = thingsCount.ToString();
        }
    }
}

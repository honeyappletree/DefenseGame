using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] private GameObject playerBullet;
    [SerializeField] private GameObject bulletPosition;

    // Start is called before the first frame update
    void Start()
    {
        //bulletPosition.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("AttackEnemy", 2f);
    }

    void AttackEnemy()
    {
        playerBullet.transform.position = Vector2.left;
    }
}

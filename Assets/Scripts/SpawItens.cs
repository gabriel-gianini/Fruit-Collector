using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawItens : MonoBehaviour
{
    [SerializeField]
    private GameObject[] itens;
    private GameManager GameManager;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        InvokeRepeating("CreateObject", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateObject() 
    {
        if (GameManager.startGame==true)
        {
            Instantiate(itens[Random.Range(0, 3)], new Vector3(Random.Range(-8f, 8.1f), 10f, 0f), (Quaternion.identity));
        }
        
    
    }
    
}
